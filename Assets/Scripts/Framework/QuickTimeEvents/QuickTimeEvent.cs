using System;
using System.Collections;
using System.Collections.Generic;
using Baz_geluk9.Extensions;
using UnityEngine;

namespace Baz_geluk9.HKU
{
    // [Serializable] // todo: check if MonoBehaviour is needed
    public sealed class QuickTimeEvent : MonoBehaviour
    {
        [HideInInspector] public BaseQuickTimeEventHolder parent;

        [Tooltip("The assigned key to press to succeed the quick time event.")]
        public KeyCodeQTE keyToPress;

        [Tooltip("The time assigned to the timer.")]
        [Range(0, 10)] public float qteTime = 5;

        private float _timer;
        private bool _isStarted;

        private void Awake()
        {
            // todo: key image
        }

        private void Update()
        {
            if (!_isStarted)
                return;
            
            if (parent is QuickTimeEventSystem
                && _timer <= 0)
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
            
            if (parent is QuickTimeEventSystem)
                _timer -= Time.deltaTime;
        }

        public void StartQte()
        {
            if (parent is QuickTimeEventSystem)
                _timer = qteTime;
            
            _isStarted = true;
        }

        private void StopQte()
        {
            _isStarted = false;
        }
    }
}
