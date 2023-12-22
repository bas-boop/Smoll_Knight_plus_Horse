using UnityEngine;

namespace Baz_geluk9.HKU
{
    
    public class GetPlayerSettings : MonoBehaviour
    {
        protected PlayerSettings p_playerSettings;
            
        private void Awake() => p_playerSettings = FindObjectOfType<PlayerSettings>();
    }
}
