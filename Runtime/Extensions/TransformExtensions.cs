using UnityEngine;

namespace SaiUtils.Extensions
{
    public static class TransformExtensions
    {
        public static void SetPositionX(this Transform transform, float x)
        {
            transform.position = new Vector3(x, transform.position.y, transform.position.z);
        }

        public static void SetPositionY(this Transform transform, float y)
        {
            transform.position = new Vector3(transform.position.x, y, transform.position.z);
        }

        public static void SetPositionZ(this Transform transform, float z)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, z);
        }

        public static void SetLocalPositionX(this Transform transform, float x)
        {
            transform.localPosition = new Vector3(x, transform.localPosition.y, transform.localPosition.z);
        }

        public static void SetLocalPositionY(this Transform transform, float y)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, y, transform.localPosition.z);
        }

        public static void SetLocalPositionZ(this Transform transform, float z)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, z);
        }

        public static void SetPosition(this Transform transform, float x = float.NaN, float y = float.NaN, float z = float.NaN)
        {
            transform.position = new Vector3(
                float.IsNaN(x) ? transform.position.x : x,
                float.IsNaN(y) ? transform.position.y : y,
                float.IsNaN(z) ? transform.position.z : z
            );
        }

        public static void SetLocalPosition(this Transform transform, float x = float.NaN, float y = float.NaN, float z = float.NaN)
        {
            transform.localPosition = new Vector3(
                float.IsNaN(x) ? transform.localPosition.x : x,
                float.IsNaN(y) ? transform.localPosition.y : y,
                float.IsNaN(z) ? transform.localPosition.z : z
            );
        }
    }
}
