using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Baz_geluk9.SKPH
{
    public sealed class QuickTimeEventCaller : MonoBehaviour
    {
        [SerializeField] private QuickTimeEventSystem system;
        [SerializeField, Range(0, 20)] private float timeBetweenQte;
        [SerializeField] private UnityEvent onCalledEveryQte;
        
        private void Start() => StartCoroutine(CallQtesSequentially());

        private IEnumerator CallQtesSequentially()
        {
            float currentTimeBetweenQte = timeBetweenQte;
            int qteListLength = system.GetQteListLength();

            for (int i = 0; i < qteListLength; i++)
            {
                yield return StartCoroutine(CallQte(currentTimeBetweenQte));

                if (i != qteListLength - 1)
                    continue;
                
                yield return new WaitForSeconds(timeBetweenQte);
                onCalledEveryQte?.Invoke();
            }
        }

        private IEnumerator CallQte(float timeBetween)
        {
            yield return new WaitForSeconds(timeBetween + 0.001f);
            system.StartNextQte();    
        }
    }
}
