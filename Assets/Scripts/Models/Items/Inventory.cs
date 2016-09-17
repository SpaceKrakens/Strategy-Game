

namespace Assets.Scripts.Models.Items
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Inventory : IEnumerable<Item>
    {

        private List<Item> items;

        private const int MaxInventorySize = 5;

        public IEnumerator<Item> GetEnumerator()
        {
            return ((IEnumerable<Item>)this.items).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Item>)this.items).GetEnumerator();
        }

        public Inventory()
        {
            this.items = new List<Item>();
        }

        public Inventory(IEnumerable<Item> items)
        {
            // not best solution...
            if (items == null)
            {
                this.items = new List<Item>();
            }
            else if (items.Count() <= MaxInventorySize)
            {
                this.items = new List<Item>(items);
            }
            else
            {
                throw new ArgumentException("IEnumarable to large.");
            }
        }


        public void AddItem(Item item)
        {
            if (this.items.Count < MaxInventorySize)
            {
                this.items.Add(item);
            }
            else
            {
                // Will do something else here later. Fire event maybe.
                throw new FieldAccessException("Inventory is full");
            }
        }

        public Item GetItem(int invPos)
        {
            return this.items[invPos];
        }

    }
}
