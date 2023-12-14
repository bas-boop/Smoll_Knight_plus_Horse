using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Baz_geluk9.HKU
{
    public sealed class ScoreCalculator : MonoBehaviour
    {
        private enum GameResult
        {
            DRAW,
            PLAYER_WON,
            NPC_WON
        }

        [SerializeField] private QuickTimeEventSystem qteSystem;
        [SerializeField] private HorseStatesGenerator horseStates;

        [SerializeField] private float scoreMultiplier = 0.15f;
        [Tooltip("Temp player horse type."), SerializeField] private HorseType playerType;

        private GameResult _gameResult;

        public void CalculateScore()
        {
            (double npcScore, HorseType npcType) = horseStates.GetNpcHorseStates();
            double playerScore = qteSystem.GetSuccessfulQtePercentage();

            switch (GetHorseTypeResult(playerType, npcType))
            {
                case GameResult.DRAW:
                    break;
                case GameResult.PLAYER_WON:
                    playerScore *= scoreMultiplier;
                    break;
                case GameResult.NPC_WON:
                    playerScore *= -scoreMultiplier;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            if (playerScore > npcScore)
                _gameResult = GameResult.PLAYER_WON;
            else if (playerScore == npcScore)
                _gameResult = GameResult.DRAW;
            else if (playerScore < npcScore)
                _gameResult = GameResult.NPC_WON;
        }

        /// <summary>
        /// Determines the result of the game based on player and NPC horse types.
        /// </summary>
        /// <param name="player">The player's horse type.</param>
        /// <param name="npc">The NPC's horse type.</param>
        /// <returns>The result of the game: DRAW, PLAYER_WON, or NPC_WON.</returns>
        private GameResult GetHorseTypeResult(HorseType player, HorseType npc)
        {
            if (player == npc)
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
        {
            return player switch
            {
                HorseType.POWER => npc == HorseType.SPEED,
                HorseType.SPEED => npc == HorseType.DEFENCE,
                HorseType.DEFENCE => npc == HorseType.POWER,
                _ => false
            };
        }
    }
}