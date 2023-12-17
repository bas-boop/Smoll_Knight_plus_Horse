using System;
using Baz_geluk9.Extensions;
using Baz_geluk9.HKU.UI;
using UnityEngine;
using UnityEngine.Events;

namespace Baz_geluk9.HKU
{
    public sealed class QuickTimeEvent : MonoBehaviour
    {
        [Header("References")]
        [HideInInspector] public BaseQuickTimeEventHolder parent;
        [SerializeField] private QuickTimeEventBar bar;
        [SerializeField] private QuickTimeEventKey key;

        [Header("Values")]
        [Tooltip("The assigned key to press to succeed the quick time event.")]
        public KeyCodeQTE keyToPress;

        [Tooltip("The time assigned to the timer.")]
        [Range(0, 10)] private const float QTE_TIME = 5;

        [Space(20)]
        [SerializeField] private UnityEvent onWin = new();
        [SerializeField] private UnityEvent onLose = new();
        
        private float _timer;
        private bool _isStarted;

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

            if (parent is not QuickTimeEventSystem) 
                return;
            
            _timer -= Time.deltaTime;
            SetUi();
        }

        public void StartQte()
        {
            if (parent is QuickTimeEventSystem)
                _timer = QTE_TIME;

            key.SetText(keyToPress.GetStringValue());
            bar.SetupBar();
            _isStarted = true;
        }

        private void StopQte()
        {
            _isStarted = false;
            key.TurnOffText();
            bar.ToggleVisibility();
        }

        private void SetUi()
        {
            float a = _timer / QTE_TIME;
            bar.SetFillAmount(a);
        }
    }
}
