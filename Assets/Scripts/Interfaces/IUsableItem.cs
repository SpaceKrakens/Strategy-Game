// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUsableItem.cs" company="Dormanil">
//   MIT License
//   Copyright (c) 2016 Dormanil
// </copyright>
// <summary>
//   Defines the IUsableItem type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assets.Scripts.Interfaces
{
    using Assets.Scripts.Models.Characters;

    /// <summary>
    /// The Usable interface.
    /// </summary>
    public interface IUsableItem
    {
        /// <summary>
        /// Uses the Item.
        /// </summary>
        /// <param name="user">
        /// The user.
        /// </param>
        void Use(Unit user);
    }
}
