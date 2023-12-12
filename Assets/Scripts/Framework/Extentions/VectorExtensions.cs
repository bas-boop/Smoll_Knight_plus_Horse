using UnityEngine;

namespace Baz_geluk9.Extensions
{
    /// <summary>
    /// Provides versatile extensions for Vector2 and Vector3, enhancing functionality for various operations.
    /// Ideal for integration into any Unity project.
    /// Features:
    /// - Change Axis
    /// - Divide Vector & Axis
    /// - Combine Vector & Axis
    /// - Separate Vector & Axis
    /// - Multiply Vector & Axis
    /// - Compare Vector & Axis (with optional margin)
    /// - Randomize Vector & Axis
    /// - Invert Vector & Axis
    /// - Calculate Midpoint between 2 vectors
    /// - Calculate Weighted Average Vector
    /// - IsWithinRange Vector & Axis
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
        public static ref Vector3 ChangeX(ref this Vector3 v, float x)
        {
            v.x = x;
            return ref v;
        }

        /// <summary>
        /// Change the Y vector of this Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="y">Target value for the Y vector.</param>
        public static ref Vector3 ChangeY(ref this Vector3 v, float y)
        {
            v.y = y;
            return ref v;
        }

        /// <summary>
        /// Change the Z vector of this Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="z">Target value for the Z vector.</param>
        public static ref Vector3 ChangeZ(ref this Vector3 v, float z)
        {
            v.z = z;
            return ref v;
        }

        #endregion

        #region Combine

        /// <summary>
        /// Combine the 2 Vectors3 into one.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 that is a combination.</returns>
        public static ref Vector3 CombineVector(ref this Vector3 v, Vector3 f)
        {
            v += f;
            return ref v;
        }
        
        /// <summary>
        /// Combine the X axis of two Vector3 into one.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 with combined X axis.</returns>
        public static ref Vector3 CombineX(ref this Vector3 v, Vector3 f)
        {
            v.x += f.x;
            return ref v;
        }

        /// <summary>
        /// Combine the Y axis of two Vector3 into one.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 with combined Y axis.</returns>
        public static ref Vector3 CombineY(ref this Vector3 v, Vector3 f)
        {
            v.y += f.y;
            return ref v;
        }

        /// <summary>
        /// Combine the Z axis of two Vector3 into one.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 with combined Z axis.</returns>
        public static ref Vector3 CombineZ(ref this Vector3 v, Vector3 f)
        {
            v.z += f.z;
            return ref v;
        }

        #endregion

        #region Separate

        /// <summary>
        /// Remove the the given Vector3 form this Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 that is a separation.</returns>
        public static ref Vector3 SeparateVector(ref this Vector3 v, Vector3 f)
        {
            v -= f;
            return ref v;
        }
        
        /// <summary>
        /// Separate the X axis of the second Vector3 from the first Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 with separated X axis.</returns>
        public static ref Vector3 SeparateX(ref this Vector3 v, Vector3 f)
        {
            v.x -= f.x;
            return ref v;
        }

        /// <summary>
        /// Separate the Y axis of the second Vector3 from the first Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 with separated Y axis.</returns>
        public static ref Vector3 SeparateY(ref this Vector3 v, Vector3 f)
        {
            v.y -= f.y;
            return ref v;
        }

        /// <summary>
        /// Separate the Z axis of the second Vector3 from the first Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 with separated Z axis.</returns>
        public static ref Vector3 SeparateZ(ref this Vector3 v, Vector3 f)
        {
            v.z -= f.z;
            return ref v;
        }

        #endregion

        #region Multiple

        /// <summary>
        /// Multiple this Vector3 with the given Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 that is multiplied.</returns>
        public static ref Vector3 MultipleVector(ref this Vector3 v, Vector3 f)
        {
            v.x *= f.x;
            v.y *= f.y;
            v.z *= f.z;
            return ref v;
        }
        
        /// <summary>
        /// Multiply the X axis of this Vector3 by the X axis of another Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 with multiplied X axis.</returns>
        public static ref Vector3 MultipleX(ref this Vector3 v, Vector3 f)
        {
            v.x *= f.x;
            return ref v;
        }

        /// <summary>
        /// Multiply the Y axis of this Vector3 by the Y axis of another Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 with multiplied Y axis.</returns>
        public static ref Vector3 MultipleY(ref this Vector3 v, Vector3 f)
        {
            v.y *= f.y;
            return ref v;
        }

        /// <summary>
        /// Multiply the Z axis of this Vector3 by the Z axis of another Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 with multiplied Z axis.</returns>
        public static ref Vector3 MultipleZ(ref this Vector3 v, Vector3 f)
        {
            v.z *= f.z;
            return ref v;
        }

        #endregion
        
        #region Divide

        /// <summary>
        /// Divide this Vector3 with the given Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="f">The f Vector3.</param>
        /// <returns>A new Vector3 that is division.</returns>
        public static ref Vector3 DivideVector(ref this Vector3 v, Vector3 f)
        {
            v.x /= f.x;
            v.y /= f.y;
            v.z /= f.z;
            return ref v;
        }
        
        /// <summary>
        /// Divide the X vector of this Vector3
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="x">Divider for the X vector.</param>
        public static ref Vector3 DivideX(ref this Vector3 v, float x)
        {
            v.x /= x;
            return ref v;
        }

        /// <summary>
        /// Change the Y vector of this Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="y">Divider value for the Y vector.</param>
        public static ref Vector3 DivideY(ref this Vector3 v, float y)
        {
            v.y /= y;
            return ref v;
        }

        /// <summary>
        /// Change the Z vector of this Vector3.
        /// </summary>
        /// <param name="v">This vector3.</param>
        /// <param name="z">Divider value for the Z vector.</param>
        public static ref Vector3 DivideZ(ref this Vector3 v, float z)
        {
            v.z /= z;
            return ref v;
        }

        #endregion

        #region Compare

        /// <summary>
        /// Compare two Vector3 with an optional margin for floating-point precision.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3 to compare with.</param>
        /// <param name="margin">Optional margin for floating-point precision. Default is 0.</param>
        /// <returns>True if the vectors are approximately equal within the specified margin.</returns>
        public static bool Compare(this Vector3 v, Vector3 f, float margin = 0.0001f)
        {
            return Mathf.Abs(v.x - f.x) < margin
                   && Mathf.Abs(v.y - f.y) < margin
                   && Mathf.Abs(v.z - f.z) < margin;
        }
        
        /// <summary>
        /// Compare the X axis of two Vector3 with an optional margin for floating-point precision.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3 to compare with.</param>
        /// <param name="margin">Optional margin for floating-point precision. Default is 0.</param>
        /// <returns>True if the X axes are approximately equal within the specified margin.</returns>
        public static bool CompareX(this Vector3 v, Vector3 f, float margin = 0.0001f)
        {
            return Mathf.Abs(v.x - f.x) < margin;
        }

        /// <summary>
        /// Compare the Y axis of two Vector3 with an optional margin for floating-point precision.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3 to compare with.</param>
        /// <param name="margin">Optional margin for floating-point precision. Default is 0.</param>
        /// <returns>True if the Y axes are approximately equal within the specified margin.</returns>
        public static bool CompareY(this Vector3 v, Vector3 f, float margin = 0.0001f)
        {
            return Mathf.Abs(v.y - f.y) < margin;
        }

        /// <summary>
        /// Compare the Z axis of two Vector3 with an optional margin for floating-point precision.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3 to compare with.</param>
        /// <param name="margin">Optional margin for floating-point precision. Default is 0.</param>
        /// <returns>True if the Z axes are approximately equal within the specified margin.</returns>
        public static bool CompareZ(this Vector3 v, Vector3 f, float margin = 0.0001f)
        {
            return Mathf.Abs(v.z - f.z) < margin;
        }

        #endregion

        #region Randomize

        /// <summary>
        /// Randomize the X, Y, and Z axes of this Vector3 within specified ranges.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="xRange">Range for the X axis.</param>
        /// <param name="yRange">Range for the Y axis.</param>
        /// <param name="zRange">Range for the Z axis.</param>
        /// <returns>A new Vector3 with randomized axes.</returns>
        public static ref Vector3 RandomizeVector(ref this Vector3 v, Vector3 xRange, Vector3 yRange, Vector3 zRange)
        {
            v.x = Random.Range(xRange.x, xRange.y);
            v.y = Random.Range(yRange.x, yRange.y);
            v.z = Random.Range(zRange.x, zRange.z);
            return ref v;
        }
        
        /// <summary>
        /// Randomize the X, Y, and Z axes of this Vector3 within the specified range.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="range">Range for all axes.</param>
        /// <returns>A new Vector3 with randomized axes.</returns>
        public static ref Vector3 RandomizeVector(ref this Vector3 v, Vector3 range)
        {
            v.x = Random.Range(range.x, range.y);
            v.y = Random.Range(range.x, range.y);
            v.z = Random.Range(range.x, range.y);
            return ref v;
        }
        
        /// <summary>
        /// Randomize all axes of this Vector3 with the same random number within the specified range.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="range">Range for all axes.</param>
        /// <returns>A new Vector3 with the same randomized value for all axes.</returns>
        public static ref Vector3 RandomizeVectorUniform(ref this Vector3 v, Vector3 range)
        {
            float randomValue = Random.Range(range.x, range.y);
            v.x = randomValue;
            v.y = randomValue;
            v.z = randomValue;
            return ref v;
        }

        /// <summary>
        /// Randomize the X axis of this Vector3 within a specified range.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="xRange">Range for the X axis.</param>
        /// <returns>A new Vector3 with a randomized X axis.</returns>
        public static ref Vector3 RandomizeX(ref this Vector3 v, Vector3 xRange)
        {
            v.x = Random.Range(xRange.x, xRange.y);
            return ref v;
        }

        /// <summary>
        /// Randomize the Y axis of this Vector3 within a specified range.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="yRange">Range for the Y axis.</param>
        /// <returns>A new Vector3 with a randomized Y axis.</returns>
        public static ref Vector3 RandomizeY(ref this Vector3 v, Vector3 yRange)
        {
            v.y = Random.Range(yRange.x, yRange.y);
            return ref v;
        }

        /// <summary>
        /// Randomize the Z axis of this Vector3 within a specified range.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="zRange">Range for the Z axis.</param>
        /// <returns>A new Vector3 with a randomized Z axis.</returns>
        public static ref Vector3 RandomizeZ(ref this Vector3 v, Vector3 zRange)
        {
            v.z = Random.Range(zRange.x, zRange.z);
            return ref v;
        }
        
        #endregion

        #region Invert

        /// <summary>
        /// Invert the X, Y, and Z axes of this Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <returns>The Vector3 with inverted axes.</returns>
        public static ref Vector3 InvertVector(ref this Vector3 v)
        {
            v.x = -v.x;
            v.y = -v.y;
            v.z = -v.z;
            return ref v;
        }
        
        /// <summary>
        /// Invert the X axis of this Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <returns>The Vector3 with the inverted X axis.</returns>
        public static ref Vector3 InvertX(ref this Vector3 v)
        {
            v.x = -v.x;
            return ref v;
        }

        /// <summary>
        /// Invert the Y axis of this Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <returns>The Vector3 with the inverted Y axis.</returns>
        public static ref Vector3 InvertY(ref this Vector3 v)
        {
            v.y = -v.y;
            return ref v;
        }

        /// <summary>
        /// Invert the Z axis of this Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <returns>The Vector3 with the inverted Z axis.</returns>
        public static ref Vector3 InvertZ(ref this Vector3 v)
        {
            v.z = -v.z;
            return ref v;
        }

        #endregion

        #region Midpoint

        /// <summary>
        /// Calculate the midpoint between two Vector3.
        /// </summary>
        /// <param name="v">The first Vector3.</param>
        /// <param name="f">The second Vector3.</param>
        /// <returns>The midpoint Vector3.</returns>
        public static Vector3 Midpoint(this Vector3 v, Vector3 f)
        {
            return v.CombineVector(f) / 2;
        }
        
        /// <summary>
        /// Calculate the weighted average of two Vector3 based on specified weight.
        /// </summary>
        /// <param name="v">The first Vector3.</param>
        /// <param name="f">The second Vector3.</param>
        /// <param name="weight">Weight for the first Vector3. Should be in the range [0, 100], it's a percentage.</param>
        /// <returns>The weighted average Vector3.</returns>
        public static Vector3 WeightedAverage(Vector3 v, Vector3 f, float weight)
        {
            const float totalWeight = 100f;
            float weightF = totalWeight - weight;

            Vector3 weightedV = v * weight;
            Vector3 weightedF = f * weightF;

            return weightedV.CombineVector(weightedF) / totalWeight;
        }

        #endregion
        
        #region IsWithinRange

        /// <summary>
        /// Checks if this Vector3 is within the specified range of another Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The target Vector3.</param>
        /// <param name="range">The range within which the f Vector3 is considered "within."</param>
        /// <returns>True if the f Vector3 is within the specified range; otherwise, false.</returns>
        public static bool IsWithinRange(this Vector3 v, Vector3 f, float range)
        {
            float distance = Vector3.Distance(v, f);
            return distance <= range;
        }

        /// <summary>
        /// Checks if the X component of this Vector3 is within the specified range of the X component of another Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3 to compare with.</param>
        /// <param name="range">The range within which the X components are considered "within."</param>
        /// <returns>True if the X components are within the specified range; otherwise, false.</returns>
        public static bool IsXWithinRange(this Vector3 v, Vector3 f, float range)
        {
            return Mathf.Abs(v.x - f.x) <= range;
        }

        /// <summary>
        /// Checks if the Y component of this Vector3 is within the specified range of the Y component of another Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3 to compare with.</param>
        /// <param name="range">The range within which the Y components are considered "within."</param>
        /// <returns>True if the Y components are within the specified range; otherwise, false.</returns>
        public static bool IsYWithinRange(this Vector3 v, Vector3 f, float range)
        {
            return Mathf.Abs(v.y - f.y) <= range;
        }

        /// <summary>
        /// Checks if the Z component of this Vector3 is within the specified range of the Z component of another Vector3.
        /// </summary>
        /// <param name="v">This Vector3.</param>
        /// <param name="f">The f Vector3 to compare with.</param>
        /// <param name="range">The range within which the Z components are considered "within."</param>
        /// <returns>True if the Z components are within the specified range; otherwise, false.</returns>
        public static bool IsZWithinRange(this Vector3 v, Vector3 f, float range)
        {
            return Mathf.Abs(v.z - f.z) <= range;
        }

        #endregion

        #endregion

        #region Vector 2

        #region Change Axis

        /// <summary>
        /// Change the X vector of this Vector2 in place.
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="x">Target value for the X vector.</param>
        public static ref Vector2 ChangeX(ref this Vector2 v, float x)
        {
            v.x = x;
            return ref v;
        }

        /// <summary>
        /// Change the Y vector of this Vector2.
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="y">Target value for the Y vector.</param>
        public static ref Vector2 ChangeY(ref this Vector2 v, float y)
        {
            v.y = y;
            return ref v;
        }

        #endregion

        #region Combine

        /// <summary>
        /// Combine the 2 Vectors2 into one.
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector2 that is a combination.</returns>
        public static ref Vector2 CombineVector(ref this Vector2 v, Vector2 f)
        {
            v.x += f.x;
            v.y += f.y;
            return ref v;
        }

        /// <summary>
        /// Combine the X axis of two Vector2 into one.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector2 with combined X axis.</returns>
        public static ref Vector2 CombineX(ref this Vector2 v, Vector2 f)
        {
            v.x += f.x;
            return ref v;
        }

        /// <summary>
        /// Combine the Y axis of two Vector2 into one.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector2 with combined Y axis.</returns>
        public static ref Vector2 CombineY(ref this Vector2 v, Vector2 f)
        {
            v.y += f.y;
            return ref v;
        }

        #endregion

        #region Separate

        /// <summary>
        /// Remove the given Vector2 from this Vector2.
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector2 that is a separation.</returns>
        public static ref Vector2 SeparateVector(ref this Vector2 v, Vector2 f)
        {
            v.x -= f.x;
            v.y -= f.y;
            return ref v;
        }

        /// <summary>
        /// Separate the X axis of the second Vector2 from the first Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector2 with separated X axis.</returns>
        public static ref Vector2 SeparateX(ref this Vector2 v, Vector2 f)
        {
            v.x -= f.x;
            return ref v;
        }

        /// <summary>
        /// Separate the Y axis of the second Vector2 from the first Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector2 with separated Y axis.</returns>
        public static ref Vector2 SeparateY(ref this Vector2 v, Vector2 f)
        {
            v.y -= f.y;
            return ref v;
        }

        #endregion

        #region Multiple

        /// <summary>
        /// Multiply this Vector2 with the given Vector2.
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector2 that is multiplied.</returns>
        public static ref Vector2 MultipleVector(ref this Vector2 v, Vector2 f)
        {
            v.x *= f.x;
            v.y *= f.y;
            return ref v;
        }

        /// <summary>
        /// Multiply the X axis of this Vector2 by the X axis of another Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector2 with multiplied X axis.</returns>
        public static ref Vector2 MultipleX(ref this Vector2 v, Vector2 f)
        {
            v.x *= f.x;
            return ref v;
        }

        /// <summary>
        /// Multiply the Y axis of this Vector2 by the Y axis of another Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector2 with multiplied Y axis.</returns>
        public static ref Vector2 MultipleY(ref this Vector2 v, Vector2 f)
        {
            v.y *= f.y;
            return ref v;
        }

        #endregion

        #region Divide

        /// <summary>
        /// Divide this Vector2 with the given Vector2.
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="f">The f Vector2.</param>
        /// <returns>A new Vector3 that is division.</returns>
        public static ref Vector2 DivideVector(ref this Vector2 v, Vector2 f)
        {
            v.x /= f.x;
            v.y /= f.y;
            return ref v;
        }

        /// <summary>
        /// Divide the X vector of this Vector2
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="x">Divider for the X vector.</param>
        public static ref Vector2 DivideX(ref this Vector2 v, float x)
        {
            v.x /= x;
            return ref v;
        }

        /// <summary>
        /// Divide the Y vector of this Vector2.
        /// </summary>
        /// <param name="v">This vector2.</param>
        /// <param name="y">Divider value for the Y vector.</param>
        public static ref Vector2 DivideY(ref this Vector2 v, float y)
        {
            v.y /= y;
            return ref v;
        }

        #endregion

        #region Compare

        /// <summary>
        /// Compare two Vector2 with an optional margin for floating-point precision.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2 to compare with.</param>
        /// <param name="margin">Optional margin for floating-point precision. Default is 0.</param>
        /// <returns>True if the vectors are approximately equal within the specified margin.</returns>
        public static bool Compare(this Vector2 v, Vector2 f, float margin = 0.0001f)
        {
            return Mathf.Abs(v.x - f.x) < margin 
                   && Mathf.Abs(v.y - f.y) < margin;
        }

        /// <summary>
        /// Compare the X axis of two Vector2 with an optional margin for floating-point precision.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2 to compare with.</param>
        /// <param name="margin">Optional margin for floating-point precision. Default is 0.</param>
        /// <returns>True if the X axes are approximately equal within the specified margin.</returns>
        public static bool CompareX(this Vector2 v, Vector2 f, float margin = 0.0001f)
        {
            return Mathf.Abs(v.x - f.x) < margin;
        }

        /// <summary>
        /// Compare the Y axis of two Vector2 with an optional margin for floating-point precision.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2 to compare with.</param>
        /// <param name="margin">Optional margin for floating-point precision. Default is 0.</param>
        /// <returns>True if the Y axes are approximately equal within the specified margin.</returns>
        public static bool CompareY(this Vector2 v, Vector2 f, float margin = 0.0001f)
        {
            return Mathf.Abs(v.y - f.y) < margin;
        }

        #endregion

        #region Randomize

        /// <summary>
        /// Randomize the X, Y, and Z axes of this Vector2 within specified ranges.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="xRange">Range for the X axis.</param>
        /// <param name="yRange">Range for the Y axis.</param>
        /// <returns>A new Vector2 with randomized axes.</returns>
        public static ref Vector2 RandomizeVector(ref this Vector2 v, Vector2 xRange, Vector2 yRange)
        {
            v.x = Random.Range(xRange.x, xRange.y);
            v.y = Random.Range(yRange.x, yRange.y);
            return ref v;
        }
        
        /// <summary>
        /// Randomize the X and Y components of this Vector2 within the specified range.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="range">Range for X and Y components.</param>
        /// <returns>A new Vector2 with randomized X and Y components.</returns>
        public static ref Vector2 RandomizeVector(ref this Vector2 v, Vector2 range)
        {
            v.x = Random.Range(range.x, range.y);
            v.y = Random.Range(range.x, range.y);
            return ref v;
        }

        /// <summary>
        /// Randomize both components of this Vector2 with the same random number within the specified range.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="range">Range for both components.</param>
        /// <returns>A new Vector2 with the same randomized value for both components.</returns>
        public static ref Vector2 RandomizeVectorUniform(ref this Vector2 v, Vector2 range)
        {
            float randomValue = Random.Range(range.x, range.y);
            v.x = randomValue;
            v.y = randomValue;
            return ref v;
        }

        /// <summary>
        /// Randomize the X axis of this Vector2 within a specified range.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="xRange">Range for the X axis.</param>
        /// <returns>A new Vector2 with a randomized X axis.</returns>
        public static ref Vector2 RandomizeX(ref this Vector2 v, Vector2 xRange)
        {
            v.x = Random.Range(xRange.x, xRange.y);
            return ref v;
        }

        /// <summary>
        /// Randomize the Y axis of this Vector2 within a specified range.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="yRange">Range for the Y axis.</param>
        /// <returns>A new Vector2 with a randomized Y axis.</returns>
        public static ref Vector2 RandomizeY(ref this Vector2 v, Vector2 yRange)
        {
            v.y = Random.Range(yRange.x, yRange.y);
            return ref v;
        }

        #endregion

        #region Invert

        /// <summary>
        /// Invert the X, and Y axes of this Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <returns>The Vector2 with inverted axes.</returns>
        public static ref Vector2 InvertVector(ref this Vector2 v)
        {
            v.x = -v.x;
            v.y = -v.y;
            return ref v;
        }

        /// <summary>
        /// Invert the X axis of this Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <returns>The Vector2 with the inverted X axis.</returns>
        public static ref Vector2 InvertX(ref this Vector2 v)
        {
            v.x = -v.x;
            return ref v;
        }

        /// <summary>
        /// Invert the Y axis of this Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <returns>The Vector2 with the inverted Y axis.</returns>
        public static ref Vector2 InvertY(ref this Vector2 v)
        {
            v.y = -v.y;
            return ref v;
        }

        #endregion
        
        #region Midpoint

        /// <summary>
        /// Calculate the midpoint between two Vector2.
        /// </summary>
        /// <param name="v">The first Vector2.</param>
        /// <param name="f">The second Vector2.</param>
        /// <returns>The midpoint Vector2.</returns>
        public static Vector2 Midpoint(this Vector2 v, Vector2 f)
        {
            return v.CombineVector(f) / 2;
        }

        /// <summary>
        /// Calculate the weighted average of two Vector2 based on specified weight.
        /// </summary>
        /// <param name="v">The first Vector2.</param>
        /// <param name="f">The second Vector2.</param>
        /// <param name="weight">Weight for the first Vector2. Should be in the range [0, 100], it's a percentage.</param>
        /// <returns>The weighted average Vector2.</returns>
        public static Vector2 WeightedAverage(Vector2 v, Vector2 f, float weight)
        {
            const float totalWeight = 100f;
            float weightF = totalWeight - weight;

            Vector2 weightedV = v * weight;
            Vector2 weightedF = f * weightF;

            return weightedV.CombineVector(weightedF) / totalWeight;
        }

        #endregion

        #region IsWithinRange

        /// <summary>
        /// Checks if this Vector2 is within the specified range of another Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The target Vector2.</param>
        /// <param name="range">The range within which the f Vector2 is considered "within."</param>
        /// <returns>True if the f Vector2 is within the specified range; otherwise, false.</returns>
        public static bool IsWithinRange(this Vector2 v, Vector2 f, float range)
        {
            float distance = Vector2.Distance(v, f);
            return distance <= range;
        }

        /// <summary>
        /// Checks if the X component of this Vector2 is within the specified range of the X component of another Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2 to compare with.</param>
        /// <param name="range">The range within which the X components are considered "within."</param>
        /// <returns>True if the X components are within the specified range; otherwise, false.</returns>
        public static bool IsXWithinRange(this Vector2 v, Vector2 f, float range)
        {
            return Mathf.Abs(v.x - f.x) <= range;
        }

        /// <summary>
        /// Checks if the Y component of this Vector2 is within the specified range of the Y component of another Vector2.
        /// </summary>
        /// <param name="v">This Vector2.</param>
        /// <param name="f">The f Vector2 to compare with.</param>
        /// <param name="range">The range within which the Y components are considered "within."</param>
        /// <returns>True if the Y components are within the specified range; otherwise, false.</returns>
        public static bool IsYWithinRange(this Vector2 v, Vector2 f, float range)
        {
            return Mathf.Abs(v.y - f.y) <= range;
        }
        
        #endregion

        #endregion
    }
}
