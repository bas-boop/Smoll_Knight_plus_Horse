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
        private GameObject _currentVisual;
        private const string ANIMATION_TO_PLAY = "End";
        
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
                    _currentVisual = horseVisuals[0];
                    break;
                case HorseType.SPEED:
                    _currentVisual = horseVisuals[1];
                    break;
                case HorseType.POWER:
                    _currentVisual = horseVisuals[2];
                    break;
                case HorseType.DEFENCE:
                    _currentVisual = horseVisuals[3];
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            _currentVisual.SetActive(true);
        }

        public void PlayLance() => _currentVisual.GetComponentInChildren<Animator>().Play(ANIMATION_TO_PLAY);
    }
}
