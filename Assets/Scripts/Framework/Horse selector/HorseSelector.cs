using System;
using UnityEngine;

namespace Baz_geluk9.HKU
{
    public sealed class HorseSelector : GetPlayerSettings
    {
        public void SetPlayerHorseType(int targetType)
        {
            if (Enum.IsDefined(typeof(HorseType), targetType))
                SetPlayerHorseType((HorseType)targetType);
            else
                Debug.LogError($"Invalid HorseType value: {targetType}");
        }

        public void SetPlayerHorseType(HorseType targetType) => p_playerSettings.PlayerHorseType = targetType;
    }
}