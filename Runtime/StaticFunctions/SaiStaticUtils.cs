using UnityEngine.EventSystems ;

public static class SaiStaticUtils
{
    public static bool IsMouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }
    
}