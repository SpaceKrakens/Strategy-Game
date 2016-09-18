// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Convoy.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the Convoy type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assets.Scripts.Models.Items
{
    using System.Collections.Generic;

    /// <summary>
    /// The convoy.
    /// </summary>
    public class Convoy : Inventory
    {
        /// <summary>
        /// Backing field for the current instance of the convoy.
        /// </summary>
        private static Convoy current;

        /// <summary>
        /// Initialises a new instance of the <see cref="Convoy"/> class.
        /// Creates a new list used to store the items with the specified items inside of it.
        /// Will create an empty list if <code>null</code>
        /// </summary>
        /// <param name="items">The items to place inside of the Inventory</param>
        public Convoy(IEnumerable<Item> items)
            : base(items)
        {
            Current = this;
        }

        /// <summary>
        /// Gets or sets the current instance of the convoy.
        /// </summary>
        public static Convoy Current
        {
            get
            {
                return current ?? new Convoy(new Item[] { });
            }

            set
            {
                current = value;
            }
        }

        /// <summary>
        /// Gets the maximum inventory size.
        /// </summary>
        protected override int MaxInventorySize { get; } = 999;
    }
}