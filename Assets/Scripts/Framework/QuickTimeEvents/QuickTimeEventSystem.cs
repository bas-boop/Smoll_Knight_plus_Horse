using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Baz_geluk9.HKU
{
    public sealed class QuickTimeEventSystem : BaseQuickTimeEventHolder
    {
        [SerializeField] private QuickTimeEventGroup quickTimeEventsGroup;

        private int _currentQteToCall;

        private void Awake()
        {
            if (quickTimeEvents.Length > 0)
                Init();
            
            if (quickTimeEventsGroup.quickTimeEvents.Length > 0)
                quickTimeEventsGroup.Init();
        }

        private new void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
                StartNextQTE();
            
            if (Input.GetKeyDown(KeyCode.Backspace)) 
                quickTimeEventsGroup.StartNextQTE();
        }
    }
}
