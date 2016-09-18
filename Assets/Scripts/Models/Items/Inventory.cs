#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Inventory.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Assets.Scripts.Models.Items
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using Weapons;

    /// <summary>
    /// Represents the inventory of a unit.
    /// Is Enumerable.
    /// </summary>
    public class Inventory : IEnumerable<Item>
    {
        /// <summary>
        /// The internal list used to store the items in the inventory.
        /// </summary>
        private readonly List<Item> items;

        /// <summary>
        /// Initialises a new instance of the <see cref="Inventory"/> class.
        /// Creates a new list used to store the items with the specified items inside of it.
        /// Will create an empty list if <code>null</code>
        /// </summary>
        /// <param name="items">The items to place inside of the Inventory</param>
        public Inventory(IEnumerable<Item> items) : this()
        {
            IEnumerable<Item> enumerable = items ?? new Item[] { };
            if (enumerable.Count() <= this.MaxInventorySize)
            {
                this.items.AddRange(enumerable);
            }
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="Inventory"/> class from being created. 
        /// Creates a new list used to store the items.
        /// </summary>
        private Inventory()
        {
            this.items = new List<Item>();
        }

        /// <summary>
        /// Gets the maximum inventory size.
        /// </summary>
        protected virtual int MaxInventorySize { get; } = 5;

        /// <summary>
        /// Adds the specified Item into the inventory.
        /// Inventory cannot hold more than <code>MaxInventorySize</code>.
        /// </summary>
        /// <param name="item">The Item to add to the inventory.</param>
        public void AddItem(Item item)
        {
            if (this.items.Count < this.MaxInventorySize)
            {
                this.items.Add(item);
            }
            else
            {
                // Will do something else here later. Fire event maybe.
                throw new FieldAccessException("Inventory is full");
            }
        }

        /// <summary>
        /// Gets an item from the inventory using the inventory slot.
        /// </summary>
        /// <param name="invSlot">The slot to get the item from</param>
        /// <returns>Item out of inventory</returns>
        public Item GetItem(int invSlot)
        {
            return this.items[invSlot];
        }

        /// <summary>
        /// Equips an item and adds it to the inventory if needed.
        /// </summary>
        /// <param name="item">The item.</param>
        public void EquipItem(Item item)
        {
            if (item.GetType() != typeof(Weapon))
            {
                return;
            }

            this.items.Remove(item);
            this.items.Insert(0, item);
        }

        /// <summary>
        /// Removes an item from the inventory.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>True if the item existed in the inventory, false if the item was not in the inventory.</returns>
        public bool RemoveItem(Item item)
        {
            return this.items.Remove(item);
        }

        /// <summary>
        /// Gets the enumerator for Inventory.
        /// </summary>
        /// <returns>Enumerator for Inventory.</returns>
        public IEnumerator<Item> GetEnumerator()
        {
            return ((IEnumerable<Item>)this.items).GetEnumerator();
        }

        /// <summary>
        /// Gets the enumerator for Inventory.
        /// </summary>
        /// <returns>Enumerator for Inventory.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this.items).GetEnumerator();
        }
    }
}
