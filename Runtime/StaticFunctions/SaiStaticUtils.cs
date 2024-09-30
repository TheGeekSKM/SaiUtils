using UnityEngine.EventSystems;

namespace SaiUtils
{
    public static class SaiStaticUtils
    {
        public static bool IsPointerOverUI()
        {
            return EventSystem.current.IsPointerOverGameObject();
        }
    }
}