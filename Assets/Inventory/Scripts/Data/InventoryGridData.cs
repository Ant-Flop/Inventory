using System;
using UnityEngine;
using System.Collections.Generic;

namespace Inventory
{
    [Serializable]
    public class InventoryGridData
    {
        public string OwnerId;
        public List<InventorySlotData> Slots;
        public Vector2Int Size;
    }
}