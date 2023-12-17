using Baz_geluk9.Extensions;
using UnityEngine;
using UnityEngine.UI;

namespace Baz_geluk9.HKU.UI
{
    public sealed class QuickTimeEventBar : MonoBehaviour
    {
        [SerializeField] private float fadeOutTime;
        [Space]
        [SerializeField] private Color startColor;
        [SerializeField] private Color endColor;

        private Image _image;
        private RectTransform _fill;
        private Vector3 _barScale;
        private bool _isColorChanging;
        
        private void Awake()
        {
            _image = GetComponent<Image>();
            _fill = GetComponent<RectTransform>();
            _barScale = Vector3.one;
            ToggleVisibility();
        }

        /// <summary>
        /// Sets the amount of the fill bar to the percentage of the items delivered.
        /// </summary>
        /// <param name="fillAmount">The the fill.</param>
        public void SetFillAmount(float fillAmount)
        {
            _barScale.ChangeX(fillAmount);
            _fill.localScale = _barScale;
            ChangeColor();
        }

        public void SetupBar()
        {
            ToggleVisibility();
            _image.CrossFadeColor(startColor, 0, false, false);
            _fill.localScale = Vector3.one;
            _isColorChanging = false;
        }

        public void ToggleVisibility() => _image.enabled = !_image.enabled;
        
        private void ChangeColor()
        {
            if (_isColorChanging)
                return;

            _isColorChanging = true;
            _image.CrossFadeColor(endColor, fadeOutTime, false, false);
        }
    }
}
