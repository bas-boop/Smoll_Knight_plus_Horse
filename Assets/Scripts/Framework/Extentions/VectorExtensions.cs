using UnityEngine;

namespace Baz_geluk9.Extensions
{
    /// <summary>
    /// This script provide Vector2 & Vector3 extensions. Can be used in any project.
    /// 
    /// Done list:
    /// Change Axis
    /// Divide Vector & Axis
    /// Combine Vector
    /// Separate Vector
    /// Multiple Vector
    /// 
    /// Todo list:
    /// Compare, optinal margin
    /// Combine Axis
    /// Separate Axis
    /// Multiple Axis
    /// Randomize Vector & Axis
    /// Inverd Vector & Axis
    /// Midpoint between 2 vectors - (a + b) / 2
    /// WeightedAverage Vector - (a * weightA + b * weightB) / (weightA + weightB)
    /// </summary>
    public static class VectorExtensions
    {
        #region Vector 3

        #region Change Axis

        /// <summary>
        /// Change the X vector of this Vector3
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="x">Target value for the X vector.</param>
        public static Vector3 ChangeX(this Vector3 v, float x)
        {
            return new Vector3(x, v.y, v.z);
        }

        /// <summary>
        /// Change the Y vector of this Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="y">Target value for the Y vector.</param>
        public static Vector3 ChangeY(this Vector3 v, float y)
        {
            return new Vector3(v.x, y, v.z);
        }

        /// <summary>
        /// Change the Z vector of this Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="z">Target value for the Z vector.</param>
        public static Vector3 ChangeZ(this Vector3 v, float z)
        {
            return new Vector3(v.x, v.y, z);
        }

        #endregion

        #region Divide Axis

        /// <summary>
        /// Divide the X vector of this Vector3
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="x">Divider for the X vector.</param>
        public static Vector3 DivideX(this Vector3 v, float x)
        {
            return new Vector3(v.x / x, v.y, v.z);
        }

        /// <summary>
        /// Change the Y vector of this Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="y">Divider value for the Y vector.</param>
        public static Vector3 DivideY(this Vector3 v, float y)
        {
            return new Vector3(v.x, v.y / y, v.z);
        }

        /// <summary>
        /// Change the Z vector of this Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="z">Divider value for the Z vector.</param>
        public static Vector3 DivideZ(this Vector3 v, float z)
        {
            return new Vector3(v.x, v.y, v.z / z);
        }

        #endregion

        /// <summary>
        /// Combine the 2 Vectors3 into one.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="f">Second Vector3.</param>
        public static Vector3 CombineVector(this Vector3 v, Vector3 f)
        {
            return new Vector3(v.x + f.x, v.y + f.y, v.z + f.z);
        }
        
        /// <summary>
        /// Remove the the given Vector3 form this Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="f">Second Vector3.</param>
        public static Vector3 SeparateVector(this Vector3 v, Vector3 f)
        {
            return new Vector3(v.x - f.x, v.y - f.y, v.z - f.z);
        }
        
        /// <summary>
        /// Multiple this Vector3 with the given Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="f">Second Vector3.</param>
        public static Vector3 MultipleVector(this Vector3 v, Vector3 f)
        {
            return new Vector3(v.x * f.x, v.y * f.y, v.z * f.z);
        }
        
        /// <summary>
        /// Divide this Vector3 with the given Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="f">Second Vector3.</param>
        public static Vector3 DivideVector(this Vector3 v, Vector3 f)
        {
            return new Vector3(v.x / f.x, v.y / f.y, v.z / f.z);
        }

        #endregion

        #region Vector 2

        #region Change Axis
        
        /// <summary>
        /// Change the X vector of this Vector2.
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="x">Target value for the X vector.</param>
        public static Vector2 ChangeX(this Vector2 v, float x)
        {
            return new Vector2(x, v.y);
        }

        /// <summary>
        /// Change the Y vector of this Vector2.
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="y">Target value for the Y vector.</param>
        public static Vector2 ChangeY(this Vector2 v, float y)
        {
            return new Vector2(v.x, y);
        }

        #endregion

        #region Divide Axis

        /// <summary>
        /// Divide the X vector of this Vector2
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="x">Divider for the X vector.</param>
        public static Vector2 DivideX(this Vector2 v, float x)
        {
            return new Vector2(v.x / x, v.y);
        }

        /// <summary>
        /// Change the Y vector of this Vector2.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="y">Divider value for the Y vector.</param>
        public static Vector2 DivideY(this Vector2 v, float y)
        {
            return new Vector2(v.x, v.y / y);
        }

        #endregion
        
        /// <summary>
        /// Combine the 2 Vectors2 into one.
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="f">Second Vector2.</param>
        public static Vector2 CombineVector(this Vector2 v, Vector2 f)
        {
            return new Vector2(v.x + f.x, v.y + f.y);
        }
        
        /// <summary>
        /// Remove the the given Vector2 form this Vector2.
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="f">Second Vector2</param>
        public static Vector2 SeparateVector(this Vector2 v, Vector2 f)
        {
            return new Vector2(v.x - f.x, v.y - f.y);
        }
        
        /// <summary>
        /// Multiple this Vector2 with the given Vector2.
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="f">Second Vector2.</param>
        public static Vector2 MultipleVector(this Vector2 v, Vector2 f)
        {
            return new Vector2(v.x * f.x, v.y * f.y);
        }
        
        /// <summary>
        /// Divide this Vector2 with the given Vector2.
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="f">Second Vector2.</param>
        public static Vector2 DivideVector(this Vector2 v, Vector2 f)
        {
            return new Vector2(v.x / f.x, v.y / f.y);
        }

        #endregion
    }
}
