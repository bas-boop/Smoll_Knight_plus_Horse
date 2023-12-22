using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Baz_geluk9.SKPH
{
    public sealed class ScoreCalculator : GetPlayerSettings
    {
        [SerializeField] private QuickTimeEventSystem qteSystem;
        [SerializeField] private HorseStatesGenerator horseStates;

        [SerializeField] private float scoreMultiplier = 0.15f;

        [SerializeField] private UnityEvent onDraw;
        [SerializeField] private UnityEvent onPlayerWon;
        [SerializeField] private UnityEvent onNpcWon;
        [SerializeField] private UnityEvent onLater;

        private bool _isCalled;

        private enum GameResult
        {
            DRAW,
            PLAYER_WON,
            NPC_WON
        }
        
        public void CalculateScore()
        {
            if(_isCalled)
                return;
            _isCalled = true;
            
            (double npcScore, HorseType npcType) = horseStates.GetNpcHorseStates();
            double playerScore = qteSystem.GetSuccessfulQtePercentage();
                
            Debug.Log("1, Player score: " + playerScore + "\nNPC score: " + npcScore);

            switch (GetHorseTypeResult(p_playerSettings.PlayerHorseType, npcType))
            {
                case GameResult.DRAW:
                    break;
                case GameResult.PLAYER_WON:
                    playerScore *= scoreMultiplier;
                    break;
                case GameResult.NPC_WON:
                    playerScore /= scoreMultiplier;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Debug.Log("2, Player score: " + playerScore + "\nNPC score: " + npcScore);

            UnityEvent onGameResult = new();
            
            if (playerScore > npcScore)
                onGameResult = onPlayerWon;
            else if (playerScore < npcScore)
                onGameResult = onNpcWon;
            else
                onGameResult = onDraw;

            onGameResult?.Invoke();
            StartCoroutine(CallLaterEvent());
        }

        /// <summary>
        /// Determines the result of the game based on player and NPC horse types.
        /// </summary>
        /// <param name="player">The player's horse type.</param>
        /// <param name="npc">The NPC's horse type.</param>
        /// <returns>The result of the game: DRAW, PLAYER_WON, or NPC_WON.</returns>
        private GameResult GetHorseTypeResult(HorseType player, HorseType npc)
        {
            if (player == HorseType.NONE
                || npc == HorseType.NONE
                || player == npc)
                return GameResult.DRAW;

            return DetermineWinner(player, npc) ? GameResult.PLAYER_WON : GameResult.NPC_WON;
        }

        /// <summary>
        /// Determines the winner based on horse types.
        /// </summary>
        /// <param name="player">The player's horse type.</param>
        /// <param name="npc">The NPC's horse type.</param>
        /// <returns>True if the player wins, false otherwise.</returns>
        private bool DetermineWinner(HorseType player, HorseType npc) 
            => player switch
            {
                HorseType.POWER => npc == HorseType.SPEED,
                HorseType.SPEED => npc == HorseType.DEFENCE,
                HorseType.DEFENCE => npc == HorseType.POWER,
                _ => false
            };

        private IEnumerator CallLaterEvent()
        {
            yield return new WaitForSeconds(2);
            onLater?.Invoke();
        }
    }
}