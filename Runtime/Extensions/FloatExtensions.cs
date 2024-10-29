using UnityEngine;

namespace SaiUtils.Extensions
{
    public static class FloatExtensions
    {
        public static bool WithinRange(this float value, float min, float max)
        {
            return value >= min && value <= max;
        }
    }

    public static class Vector2Extensions
    {
        public static float GetRandomValue(this Vector2 vector)
        {
            return Random.Range(vector.x, vector.y);
        }
    }
}