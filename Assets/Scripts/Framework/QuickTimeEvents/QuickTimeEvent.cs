using System;
using System.Collections;
using System.Collections.Generic;
using Baz_geluk9.Extensions;
using UnityEngine;

namespace Baz_geluk9.HKU
{
    // [Serializable] todo: check if MonoBehaviour is needed
    public sealed class QuickTimeEvent : MonoBehaviour
    {
        
        [SerializeField] private KeyCodeQTE keyToPress;
        
        [Tooltip("The time assigned to the timer.")]
        [SerializeField, Range(0, 10)] private float QteTime = 5;

        private float _timer;
        private bool _isStarted;

        private void Awake() => _timer = QteTime;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) StartQte();

            if (!_isStarted)
                return;
            
            if (_timer <= 0)
            {
                // todo: Failed QTE
                Debug.Log("You lose QTE");
                StopQte();
                return;
            }

            if (Input.GetAxis(keyToPress.GetStringValue()) > 0)
            {
                Debug.Log("You won QTE");
                StopQte();
            }
            
            _timer -= Time.deltaTime;
        }

        public void StartQte() => _isStarted = true;
        private void StopQte() => _isStarted = false;
    }
}
