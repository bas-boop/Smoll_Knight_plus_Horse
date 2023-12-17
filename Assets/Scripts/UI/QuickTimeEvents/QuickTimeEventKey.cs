using TMPro;
using UnityEngine;

namespace Baz_geluk9.HKU.UI
{
    public sealed class QuickTimeEventKey : MonoBehaviour
    {
        [SerializeField] private TMP_Text text;

        private void Awake() => TurnOffText();

        public void SetText(string targetText)
        {
            gameObject.SetActive(true);
            text.text = targetText;
        }
        
        public void TurnOffText() => gameObject.SetActive(false);
    }
}
