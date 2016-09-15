// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SelectionInfo.cs" company="Dormanil">
//   MIT License
//   Copyright (c) 2016 Dormanil
// </copyright>
// <summary>
//   Defines the SelectionInfo type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assets.Scripts
{
    using Assets.Scripts.Interfaces;

    /// <summary>
    /// Basic implementation of the ISelectable interface.
    /// </summary>
    internal class SelectionInfo : ISelectable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionInfo"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="description">
        /// The description.
        /// </param>
        public SelectionInfo(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The selection info.
        /// </summary>
        /// <returns>
        /// Itself, as an <see cref="ISelectable"/>.
        /// </returns>
        public ISelectable Select()
        {
            return this;
        }
    }
}
