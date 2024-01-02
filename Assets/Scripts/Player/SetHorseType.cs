using System;
using System.Collections.Generic;
using UnityEngine;

namespace Baz_geluk9.SKPH
{
    public sealed class SetHorseType : GetPlayerSettings
    {
        [SerializeField] private List<GameObject> horseVisuals;
        [SerializeField] private bool isPlayer;

        private HorseType _horseType;
        
        private new void Awake()
        {
            if (isPlayer)
            {
                base.Awake();
                _horseType = p_playerSettings.PlayerHorseType;
            }
            else
                _horseType = GetComponent<HorseStatesGenerator>().GetHorseType();
        }
        
        private void Start()
        {
            switch (_horseType)
            {
                case HorseType.NONE:
                    horseVisuals[0].SetActive(true);
                    break;
                case HorseType.SPEED:
                    horseVisuals[1].SetActive(true);
                    break;
                case HorseType.POWER:
                    horseVisuals[2].SetActive(true);
                    break;
                case HorseType.DEFENCE:
                    horseVisuals[3].SetActive(true);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
