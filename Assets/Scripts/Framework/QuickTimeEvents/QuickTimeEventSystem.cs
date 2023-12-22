using UnityEngine;

namespace Baz_geluk9.HKU
{
    public sealed class QuickTimeEventSystem : BaseQuickTimeEventHolder
    {
        private int _currentQteToCall;

        private void Awake()
        {
            if (quickTimeEvents.Length > 0)
                Init();
            
            /*if (quickTimeEventsGroup.quickTimeEvents.Length > 0)
                quickTimeEventsGroup.Init();*/
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
