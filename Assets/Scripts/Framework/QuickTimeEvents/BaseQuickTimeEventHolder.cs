using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Baz_geluk9.HKU
{
    public abstract class BaseQuickTimeEventHolder : MonoBehaviour
    {
        public QuickTimeEvent[] quickTimeEvents = {};
        
        private float _timer;
        private bool _isStarted;

        private int _currentQteToCall;

        /// <summary>
        /// Misschien weg
        /// </summary>
        protected void Update()
        {
            if (!_isStarted)
                return;
            
            quickTimeEvents[0].StartQte();
        }

        public void StartNextQTE()
        {
            if (quickTimeEvents.Length < _currentQteToCall)
                return;

            _isStarted = true;
            quickTimeEvents[_currentQteToCall].StartQte();
            _currentQteToCall++;
        }

        public void Init()
        {
            foreach (var qte in quickTimeEvents)
            {
                qte.parent = this;
            }
        }
    }
}
