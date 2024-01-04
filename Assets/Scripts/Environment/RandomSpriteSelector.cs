using UnityEngine;

namespace Baz_geluk9.SKPH
{
    public sealed class RandomSpriteSelector : MonoBehaviour
    {
        [SerializeField] public Sprite[] sprites;

        private SpriteRenderer _spriteRenderer;

        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        
            if (sprites.Length > 0)
                SetRandomSprite();
            else
                Debug.LogError("No sprites found in the sprites array. Please assign some sprites.");
        }

        private void SetRandomSprite()
        {
            int randomNumber = Random.Range(0, sprites.Length);
            _spriteRenderer.sprite = sprites[randomNumber];
        }
    }
}