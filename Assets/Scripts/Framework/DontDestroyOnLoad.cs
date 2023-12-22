using UnityEngine;

namespace Baz_geluk9.SKPH
{
    public sealed class DontDestroyOnLoad : MonoBehaviour
    {
        private void Awake() => DontDestroyOnLoad(this);
    }   
}