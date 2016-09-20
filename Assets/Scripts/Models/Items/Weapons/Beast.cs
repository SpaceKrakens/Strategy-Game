#region LICENSE
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Beast.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Assets.Scripts.Models.Items.Weapons
{
    using System;
    using System.Collections.Generic;

    using Assets.Scripts.Models.Items.Ranks;
    using Assets.Scripts.Models.Items.Weapons.Materials;

    /// <summary>
    /// Beast Weapon Class.
    /// </summary>
    public class Beast : Weapon
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Beast"/> class.
        /// </summary>
        /// <param name="weaponType">The weapon type.</param>
        /// <param name="stats">The stats of the weapon.</param>
        /// <param name="requiredWeaponRank">The required Weapon Rank.</param>
        /// <param name="weaponTriangleIsDefault">The value indicating whether the default weapon triangle should be used. Defaults to <code>true</code>.</param>
        /// <param name="nameIsDefault">The value indicating whether the default name should be used. Defaults to <code>true</code>.</param>
        /// <param name="uniqueName">The unique Name. Defaults to <code>null</code>.</param>
        public Beast(
            WeaponType weaponType,
            Stats stats,
            Rank requiredWeaponRank,
            bool weaponTriangleIsDefault = true,
            bool nameIsDefault = true,
            string uniqueName = null)
            : base(weaponType, null, stats, requiredWeaponRank, weaponTriangleIsDefault, nameIsDefault, uniqueName)
        {
        }
    }
}
