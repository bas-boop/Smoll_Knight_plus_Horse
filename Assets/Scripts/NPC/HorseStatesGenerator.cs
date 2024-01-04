using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Baz_geluk9.SKPH
{
    public sealed class HorseStatesGenerator : MonoBehaviour
    {
        [Serializable]
        private struct DifficultyRange
        {
            public NpcDifficulty difficulty;
            public float min;
            public float max;
        }

        [SerializeField] private HorseType horseType;
        [SerializeField] private NpcDifficulty npcDifficulty;
        [SerializeField] private List<DifficultyRange> difficultyRanges;

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The percentage of how well the NPC did. And the NPC difficulty it has.</returns>
        public (double, HorseType) GetNpcHorseStates() => (GetRandomNumber(npcDifficulty), horseType);

        public HorseType GetHorseType() => horseType;

        private double GetRandomNumber(NpcDifficulty difficulty)
        {
            return difficultyRanges.Where(range => range.difficulty == difficulty)
                .Select(range => UnityEngine.Random.Range(range.min, range.max))
                .Select(randomValue => Math.Round(randomValue, 2)).FirstOrDefault();
        }

        /// <summary>
        /// Do not use, old function. Use GetRandomNumber(NpcDifficulty) instead. This is still here because I like how the code looks :D
        /// </summary>
        private double GetRandomNumber(string difficulty)
        {
            Dictionary<string, (float, float)> ranges = new ()
            {
                { "easy", (0f, 60f) },
                { "medium", (30f, 60f) },
                { "hard", (50f, 80f) },
                { "very hard", (70f, 99f) }
            };
            
            return ranges.TryGetValue(difficulty, out (float, float) range) 
                ? UnityEngine.Random.Range(range.Item1, range.Item2) 
                : 0.0;
        }
    }
}
