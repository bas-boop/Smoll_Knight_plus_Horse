using UnityEngine;

namespace Baz_geluk9.Extensions
{
    public static class Rigidbody2DExtensions
    {
        public static void ChangeVelocity(this Rigidbody2D rigidbody, Vector2 v)
        {
            Vector2 newVelocity = rigidbody.velocity;
            newVelocity.ChangeX(v.x).ChangeY(v.y);
            rigidbody.velocity = newVelocity;
        }
        
        /// <summary>
        /// Change the X axis of the velocity of this Rigidbody2D.
        /// </summary>
        /// <param name="rigidbody">This Rigidbody2D.</param>
        /// <param name="x">Target value for the X axis of the velocity.</param>
        public static void ChangeVelocityX(this Rigidbody2D rigidbody, float x)
        {
            Vector2 newVelocity = rigidbody.velocity;
            rigidbody.velocity = newVelocity.ChangeX(x);
        }
        
        /// <summary>
        /// Change the Y axis of the velocity of this Rigidbody2D.
        /// </summary>
        /// <param name="rigidbody">This Rigidbody2D.</param>
        /// <param name="y">Target value for the Y axis of the velocity.</param>
        public static void ChangeVelocityY(this Rigidbody2D rigidbody, float y)
        {
            Vector2 newVelocity = rigidbody.velocity;
            rigidbody.velocity = newVelocity.ChangeY(y);
        }
    }
}
