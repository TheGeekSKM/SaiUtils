using UnityEngine;

namespace SaiUtils.Inventory
{
    [CreateAssetMenu(menuName = "SaiUtils/Inventory/ConsumableObject")]
    public class ConsumableObject : ItemObject
    {
        public int Value;
        public StatType StatType;
        public void Reset()
        {
            Type = ItemType.Consumable;
        }
    }
}