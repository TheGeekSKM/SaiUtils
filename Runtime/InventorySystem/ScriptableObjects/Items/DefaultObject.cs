using UnityEngine;

namespace SaiUtils.Inventory
{
    [CreateAssetMenu(menuName = "SaiUtils/Inventory/DefaultObject")]
    public class DefaultObject : ItemObject
    {
        public void Reset()
        {
            Type = ItemType.Default;
        }
    }
}