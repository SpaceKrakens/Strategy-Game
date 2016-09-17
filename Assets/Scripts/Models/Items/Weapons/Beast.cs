#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Material.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Assets.Scripts.Models.Items.Weapons
{
    using System;
    using System.Collections.Generic;

    using Assets.Scripts.Models.Items.Weapons.Materials;

    class Beast : Weapon
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Beast"/> class.
        /// </summary>
        /// <param name="weaponType">
        /// The weapon type.
        /// </param>
        /// <param name="weaponTriangleIsDefault">
        /// The value indicating whether the default weapon triangle should be used. Defaults to <code>true</code>.
        /// </param>
        /// <param name="nameIsDefault">
        /// The value indicating whether the default name should be used. Defaults to <code>true</code>.
        /// </param>
        /// <param name="uniqueName">
        /// The unique Name. Defaults to <code>null</code>.
        /// </param>
        public Beast(
            WeaponType weaponType,
            Stats stats,
            bool weaponTriangleIsDefault = true,
            bool nameIsDefault = true,
            string uniqueName = null)
            : base(weaponType, null, stats, weaponTriangleIsDefault, nameIsDefault, uniqueName)            
        {
        }
        
        

    }
}
