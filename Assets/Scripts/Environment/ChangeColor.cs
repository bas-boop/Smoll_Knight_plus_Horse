using UnityEngine;

namespace Baz_geluk9.SKPH
{
    public sealed class ColorChanger : MonoBehaviour
    {
        [SerializeField] private Color[] colorOptions;
    
        private SpriteRenderer _spriteRenderer;

        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            SetColor();
        }

        private void SetColor()
        {
            if (colorOptions.Length > 0)
            {
                Color randomColor = colorOptions[Random.Range(0, colorOptions.Length)];
                _spriteRenderer.color = randomColor;
            }
            else
                Debug.LogWarning("Color options list is empty. Please add colors to the list.");
        }
    }
}