using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SaiUtils.Inventory
{
    public abstract class ItemObject : ScriptableObject
    {
        public string Name;
        [TextArea(15, 20)] public string Description;
        public GameObject Prefab;
        public ItemType Type;
    }
}
