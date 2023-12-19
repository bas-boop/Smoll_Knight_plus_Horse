using UnityEngine;

namespace Baz_geluk9.HKU
{
    public sealed class DontDestroyOnLoad : MonoBehaviour
    {
        private void Awake() => DontDestroyOnLoad(this);
    }   
}