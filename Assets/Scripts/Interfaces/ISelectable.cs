// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISelectable.cs" company="Dormanil">
//   MIT License
//   Copyright (c) 2016 Dormanil
// </copyright>
// <summary>
//   Defines the ISelectable interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assets.Scripts.Interfaces
{
    /// <summary>
    /// The interface for basic selection information and selectability.
    /// </summary>
    public interface ISelectable
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// The selection information.
        /// </summary>
        /// <returns>
        /// The <see cref="ISelectable"/>.
        /// </returns>
        ISelectable Select();
    }
}