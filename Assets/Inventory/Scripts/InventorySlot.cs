using System;
using UnityEngine;

namespace Inventory.Scripts
{
    public class InventorySlot : IReadOnlyInventorySlot
    {
        public event Action<string> ItemIdChanged;
        public event Action<int> ItemAmountChanged;

        // Добавляем поле _data
        private InventorySlotData _data;

        public string ItemId
        {
            get => _data.ItemId;
            set
            {
                if (_data.ItemId != value)
                {
                    _data.ItemId = value;
                    ItemIdChanged?.Invoke(value);
                }
            }
        }

        public int Amount
        {
            get => _data.Amount;
            set
            {
                if (_data.Amount != value)
                {
                    _data.Amount = value;
                    ItemAmountChanged?.Invoke(value);
                }
            }
        }

        public bool isEmpty => Amount == 0 && string.IsNullOrEmpty(ItemId);

        // Конструктор получает данные и инициализирует поле _data
        public InventorySlot(InventorySlotData data)
        {
            _data = data;
        }
    }
}
