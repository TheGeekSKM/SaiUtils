using UnityEngine;

namespace SaiUtils.Inventory
{
    [CreateAssetMenu(menuName = "SaiUtils/Inventory/EquipmentObject")]
    public class EquipmentObject : ItemObject
    {
        public int ProtectionValue;
        public StatModifier[] AdditionalStatModifiers;

        public void Reset()
        {
            Type = ItemType.Equipment;
        }
    }

    [System.Serializable]
    public struct StatModifier
    {
        public StatType StatType;
        public int Value;
    }
}