using System;
using UnityEngine;

namespace Inventory
{
    public interface IReadOnlyInventoryGrid
    {
        event Action<Vector2Int> SizeChanged;

        Vector2Int Size { get; }

        IReadOnlyInventorySlot[,] GetSlots();

    }
}