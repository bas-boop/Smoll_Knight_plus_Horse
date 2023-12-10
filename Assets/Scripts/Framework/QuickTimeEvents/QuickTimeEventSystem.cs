using UnityEngine;

namespace Baz_geluk9.HKU
{
    public sealed class QuickTimeEventSystem : BaseQuickTimeEventHolder
    {
        // [SerializeField] private QuickTimeEventGroup quickTimeEventsGroup;

        private int _currentQteToCall;

        private void Awake()
        {
            if (quickTimeEvents.Length > 0)
                Init();
            
            /*if (quickTimeEventsGroup.quickTimeEvents.Length > 0)
                quickTimeEventsGroup.Init();*/
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
                StartNextQte();
            
            /*if (Input.GetKeyDown(KeyCode.Backspace)) 
                quickTimeEventsGroup.StartQteGroup();*/
        }

        public override void StartNextQte()
        {
            if (p_isStarted
                && quickTimeEvents.Length < _currentQteToCall)
                return;

            p_isStarted = true;
            quickTimeEvents[_currentQteToCall].StartQte();
            _currentQteToCall++;
        }
    }
}
