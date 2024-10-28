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
}