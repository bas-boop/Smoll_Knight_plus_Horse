using System.Collections.Generic;
using Baz_geluk9.Extensions;
using UnityEngine;

namespace Baz_geluk9.SKPH
{
    [System.Serializable]
    public struct ParallaxLayer
    {
        public Transform layer;
        public float speed;
    }

    public sealed class ParallaxEffect : MonoBehaviour
    {
        [SerializeField] private bool followCamera;
        [SerializeField] private ParallaxLayer[] layers;
        [SerializeField] private float scrollSpeed;
        [SerializeField] private float accelerationTime = 2f;

        private readonly Dictionary<Transform, float> _parallaxScales = new ();
        private Transform _cam;
        private Vector2 _followPoint;
        private Vector2 _previousFollowPoint;
        private bool _canScroll = true;
        private bool _isAccelerating = true;
        private float _elapsedTime;
        private float _currentScrollSpeed;

        private void Awake()
        {
            foreach (ParallaxLayer layer in layers)
            {
                _parallaxScales.Add(layer.layer, layer.speed);
            }
        }

        private void Update()
        {
            if (!followCamera)
                UpdateFollowPoint();

            if (!_canScroll)
                return;
            
            UpdateElapsedTime();
            ScrollBackgrounds();
        }
        
        public void InvertScroll()
        {
            scrollSpeed = -scrollSpeed;
            SetScrolling(true);
        }

        public void SetScrolling(bool target)
        {
            _canScroll = target;
            _elapsedTime = 0f;
            _isAccelerating = true;
        }

        private void ScrollBackgrounds()
        {
            Vector2 currentFollowPoint = followCamera ? _cam.position : _followPoint;

            foreach (Transform layer in _parallaxScales.Keys)
            {
                float parallaxScale = _parallaxScales[layer];
                Vector3 currentPosition = layer.position;

                Vector3 backgroundTargetPos = new Vector3(
                    currentPosition.x + (_previousFollowPoint.x - currentFollowPoint.x) * parallaxScale,
                    currentPosition.y + (_previousFollowPoint.y - currentFollowPoint.y) * parallaxScale,
                    currentPosition.z);

                layer.position = Vector3.Lerp(currentPosition, backgroundTargetPos, Time.deltaTime * _currentScrollSpeed);
            }

            _previousFollowPoint = currentFollowPoint;
        }

        private void UpdateFollowPoint() => _previousFollowPoint.SubtractX(scrollSpeed);
        
        private void UpdateElapsedTime()
        {
            if (!_isAccelerating)
                return;
            
            _elapsedTime += Time.deltaTime;
            float targetScrollSpeed = Mathf.Abs(scrollSpeed);

            if (_elapsedTime >= accelerationTime)
            {
                _currentScrollSpeed = targetScrollSpeed;
                _isAccelerating = false;
            }
            else
            {
                float time = _elapsedTime / accelerationTime;
                _currentScrollSpeed = Mathf.Lerp(_currentScrollSpeed, targetScrollSpeed, time);
            }
        }
    }
}