using System;
using Baz_geluk9.Extensions;
using UnityEngine;
using UnityEngine.Events;

namespace Baz_geluk9.HKU
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class HorseMovement : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rigidbody;
        [SerializeField] private Transform player;
        [SerializeField, Range(0, -30)] private float speed;
        [SerializeField] private bool isAllowedToMove;
        
        [Space(20)]
                
        [SerializeField] private UnityEvent onStartWalking = new();
        [SerializeField] private UnityEvent onStopWalking = new();

        private void Update() // temp
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
                StartWalking();
        }

        private void FixedUpdate()
        {
            if (!isAllowedToMove
                || !transform.position.CompareX(player.position, 1f))
                return;
            
            StopWalking();
        }

        public void StartWalking()
        {
            isAllowedToMove = true;
            rigidbody.ChangeVelocityX(speed);
            onStartWalking?.Invoke();
        }

        public void StopWalking()
        {
            isAllowedToMove = false;
            rigidbody.ChangeVelocityX(0);
            onStopWalking?.Invoke();
        }
    }
}
