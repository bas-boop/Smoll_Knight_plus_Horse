using System.Collections;
using Baz_geluk9.Extensions;
using UnityEngine;
using UnityEngine.Events;

namespace Baz_geluk9.SKPH
{
    [RequireComponent(typeof(Rigidbody2D))]
    public sealed class HorseMovement : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rigidbody;
        [SerializeField] private Transform player;
        [SerializeField, Range(0, -30)] private float speed;
        [SerializeField, Range(0, 10)] private float speedMultiplier;
        [SerializeField, Range(0, 10)] private float stopFlyingWaitTime = 5;
        [SerializeField] private Vector2 flyBackDirection;
        [SerializeField] private bool isAllowedToMove;
        
        [Space(20)]
                
        [SerializeField] private UnityEvent onStartWalking = new();
        [SerializeField] private UnityEvent onStopWalking = new();
        [SerializeField] private UnityEvent onFlyingBack = new();

        private void FixedUpdate()
        {
            if (!isAllowedToMove
                || !transform.position.CompareX(player.position, 1f))
                return;
            
            StopWalking();
        }

        public void StartWalking(bool checkToWin)
        {
            isAllowedToMove = checkToWin;
            rigidbody.ChangeVelocityX(checkToWin ? speed : speed * speedMultiplier);
            onStartWalking?.Invoke();
        }

        public void StopWalking()
        {
            isAllowedToMove = false;
            rigidbody.ChangeVelocityX(0);
            onStopWalking?.Invoke();
        }

        public void FlyBack()
        {
            rigidbody.AddForce(flyBackDirection);
            rigidbody.gravityScale = 0.1f;
            StartCoroutine(StopFlying());
            onFlyingBack?.Invoke();
        }

        private IEnumerator StopFlying()
        {
            yield return new WaitForSeconds(stopFlyingWaitTime);
            rigidbody.velocity = Vector2.zero;
            rigidbody.gravityScale = 0;
        }
    }
}
