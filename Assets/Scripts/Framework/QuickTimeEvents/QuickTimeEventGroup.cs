using UnityEngine;

namespace Baz_geluk9.SKPH
{
    /// <summary>
    /// This class is unused and not working as intended.
    /// </summary>
    public sealed class QuickTimeEventGroup : BaseQuickTimeEventHolder
    {
        [Range(0, 15)] private const float QTE_TIME = 5;
        private float _timer;

        private void Update()
        {
            if (!p_isStarted) return;
            
            if (_timer <= 0)
            {
                Debug.Log("lose time");
                p_isStarted = false;
                return;
            }
            
            if (p_successfulQte == quickTimeEvents.Length)
            {
                Debug.Log("yassss");
                p_isStarted = false;
                return;
            }
            
            if (p_currentQteToCall == quickTimeEvents.Length + 1)
            {
                Debug.Log("lose");
                p_isStarted = false;
                return;
            }
            
            _timer -= Time.deltaTime;
        }

        public void StartQteGroup()
        {
            p_isStarted = true;
            _timer = QTE_TIME;
            StartNextQte();
        }

        public override void StartNextQte()
        {
            if (quickTimeEvents.Length == 0)
                return;
             
            if (p_currentQteToCall < quickTimeEvents.Length)
                quickTimeEvents[p_currentQteToCall].StartQte();
            
            p_currentQteToCall++;
        }
    }
}
