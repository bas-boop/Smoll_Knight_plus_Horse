using UnityEngine;

namespace Baz_geluk9.HKU
{
    public abstract class BaseQuickTimeEventHolder : MonoBehaviour
    {
        public QuickTimeEvent[] quickTimeEvents = {};
        
        protected bool p_isStarted;
        protected int p_successfulQte = -1;
        protected int p_currentQteToCall;

        public void Init()
        {
            foreach (var qte in quickTimeEvents)
            {
                qte.parent = this;
            }
        }

        public void IncreaseSuccessful()
        {
            p_successfulQte++;
        }

        public abstract void StartNextQte();
        
        public double GetSuccessfulQtePercentage()
        {
            if (quickTimeEvents.Length == 0)
                return 0.0;
            
            double successPercentage = (double)(p_successfulQte + 1)/ quickTimeEvents.Length * 100.0;
            return successPercentage;
        }
    }
}
