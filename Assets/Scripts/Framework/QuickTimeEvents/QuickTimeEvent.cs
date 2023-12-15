using System;
using Baz_geluk9.Extensions;
using UnityEngine;
using UnityEngine.Events;

namespace Baz_geluk9.HKU
{
    public sealed class QuickTimeEvent : MonoBehaviour
    {
        [HideInInspector] public BaseQuickTimeEventHolder parent;

        [Tooltip("The assigned key to press to succeed the quick time event.")]
        public KeyCodeQTE keyToPress;

        [Tooltip("The time assigned to the timer.")]
        [Range(0, 10)] private const float QTE_TIME = 5;

        [Space]
        [SerializeField] private UnityEvent onWin = new();
        [SerializeField] private UnityEvent onLose = new();
        
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
                onLose?.Invoke();
                StopQte();
                return;
            }
            
            foreach (KeyCodeQTE keyCode in Enum.GetValues(typeof(KeyCodeQTE)))
            {
                if (Input.GetAxis(keyCode.GetStringValue()) <= 0)
                    continue;

                UnityEvent unityEvent = keyCode != keyToPress ? onLose : onWin;
                unityEvent?.Invoke();

                StopQte();
                return;
            }

            if (parent is QuickTimeEventSystem)
                _timer -= Time.deltaTime;
        }

        public void StartQte()
        {
            Debug.Log(keyToPress.GetStringValue());
        
            if (parent is QuickTimeEventSystem)
                _timer = QTE_TIME;

            _isStarted = true;
        }

        private void StopQte()
        {
            _isStarted = false;
        }
    }
}
