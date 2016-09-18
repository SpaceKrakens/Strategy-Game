// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Unit.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines a Unit.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assets.Scripts.Models.Characters
{
    using System.Collections.Generic;

    using Classes;
    using Interfaces;
    using Items;

    /// <summary>
    /// Defines a Unit.
    /// </summary>
    public class Unit : ISelectable
    {
        /// <summary>
        /// The selection information.
        /// </summary>
        private readonly ISelectable selectionInfo;

        /// <summary>
        /// The inventory of the unit.
        /// </summary>
        private readonly Inventory inventory;

        /// <summary>
        /// Initialises a new instance of the <see cref="Unit"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="description">The description.</param>
        /// <param name="class">The class.</param>
        /// <param name="stats">The stats.</param>
        /// <param name="startingInventory">The starting Inventory.</param>
        public Unit(string name, string description, Class @class, Stats.Stats stats, IEnumerable<Item> startingInventory = null)
        {
            this.Class = @class;
            this.Stats = stats;
            this.selectionInfo = new SelectionInfo(name, description);
            this.inventory = new Inventory(startingInventory);
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description
        {
            get
            {
                return this.selectionInfo.Description;
            }

            set
            {
                this.selectionInfo.Description = value;
            }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.selectionInfo.Name;
            }

            set
            {
                this.selectionInfo.Name = value;
            }
        }

        /// <summary>
        /// Gets the class.
        /// </summary>
        public Class Class { get; }

        /// <summary>
        /// Gets the stats.
        /// </summary>
        public Stats.Stats Stats { get; }

        /// <summary>
        /// Gets the inventory.
        /// </summary>
        internal Inventory Inventory => this.inventory;

        /// <summary>
        /// Gets the selection information.
        /// </summary>
        /// <returns>
        /// The <see cref="ISelectable"/>.
        /// </returns>
        public ISelectable Select()
        {
            return this.selectionInfo.Select();
        }
    }
}