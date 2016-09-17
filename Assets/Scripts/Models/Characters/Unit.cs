﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Unit.cs" company="Dormanil">
//   MIT License
//   Copyright (c) 2016 Dormanil
// </copyright>
// <summary>
//   Defines a Unit.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assets.Scripts.Models.Characters
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Assets.Scripts.Interfaces;
    using Assets.Scripts.Models.Characters.Classes;
    using Assets.Scripts.Models.Items;

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
        private List<Item> inventory;

        /// <summary>
        /// Initialises a new instance of the <see cref="Unit"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="description">
        /// The description.
        /// </param>
        /// <param name="class">
        /// The class.
        /// </param>
        /// <param name="stats">
        /// The stats.
        /// </param>
        public Unit(string name, string description, Class @class, Stats.Stats stats, List<Item> startingInventory = null)
        {
            this.Class = @class;
            this.Stats = stats;
            this.selectionInfo = new SelectionInfo(name, description);
            this.inventory = new List<Item>(5);
            if (startingInventory != null || startingInventory.Count != 0)
            {
                try
                {
                    this.inventory.AddRange(startingInventory);
                }
                catch
                {
                    throw new ArgumentException("startingInventory is larger than 5");
                }
            }
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
        /// Adds an item to the inventory. Can only hold 5 items.
        /// </summary>
        /// <param name="item">The item to add to the inventory</param>
        public void AddItem(Item item)
        {
            try 
            {
                this.inventory.Add(item);
            }
            catch
            {
                throw new InvalidOperationException("Cannot have more than 5 items");
            }
        }

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