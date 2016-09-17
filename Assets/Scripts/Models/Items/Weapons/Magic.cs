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



    class Magic : Weapon
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Magic"/> class.
        /// </summary>
        /// <param name="weaponType">
        /// The weapon type.
        /// </param>
        /// <param name="material">
        /// The material.
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
        public Magic(
            WeaponType weaponType,
            MagicMaterial material,
            Stats stats,
            bool weaponTriangleIsDefault = true,
            bool nameIsDefault = true,
            string uniqueName = null)
            : base(weaponType, material, stats, weaponTriangleIsDefault, nameIsDefault, uniqueName)            
        {
        }



    }
}
