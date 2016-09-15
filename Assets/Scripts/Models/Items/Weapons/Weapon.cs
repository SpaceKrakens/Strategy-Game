#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Weapon.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the "Weapon" type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#endregion

namespace Assets.Scripts.Models.Items.Weapons
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using Assets.Scripts.Models.Items.Weapons.Materials;

    #region Weapon Enums

    #endregion
    
    /// <summary>
    /// The weapon.
    /// </summary>
    public class Weapon
    {
        /// <summary>
        /// The default weapon triangle.
        /// </summary>
        private static readonly Dictionary<WeaponType, WeaponEffectivity[]> DefaultWeaponTriangle = Weapons.WeaponTriangle.DefaultWeaponTriangle();

        /// <summary>
        /// The inverted weapon triangle.
        /// </summary>
        private static readonly Dictionary<WeaponType, WeaponEffectivity[]> InvertedWeaponTriangle = Weapons.WeaponTriangle.InvertedWeaponTriangle();

        /// <summary>
        /// Initializes a new instance of the <see cref="Weapon"/> class.
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
        protected Weapon(WeaponType weaponType, Material material, bool weaponTriangleIsDefault = true, bool nameIsDefault = true, string uniqueName = null)
        {
            this.WeaponType = weaponType;
            this.WeaponTriangleIsDefault = weaponTriangleIsDefault;
            this.NameIsDefault = nameIsDefault;
            this.Material = material;
            if (!nameIsDefault && string.IsNullOrEmpty(uniqueName))
            {
                throw new ArgumentException("Please supply a unique weapon name when indicating that the name is not the default name.");
            }

            this.UniqueName = uniqueName;
        }

        /// <summary>
        /// Gets the weapon type.
        /// </summary>
        public WeaponType WeaponType { get; }

        /// <summary>
        /// The weapon's personal weapon triangle.
        /// </summary>
        public WeaponEffectivity[] WeaponTriangle => this.WeaponTriangleIsDefault ? DefaultWeaponTriangle[this.WeaponType] : InvertedWeaponTriangle[this.WeaponType];

        /// <summary>
        /// Gets a value indicating whether the used weapon triangle is the default one.
        /// </summary>
        public bool WeaponTriangleIsDefault { get; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public virtual string Name => this.NameIsDefault ? this.Material.ToString() + " " + this.WeaponType.ToString() : this.UniqueName;

        /// <summary>
        /// Gets a value indicating whether name is default.
        /// </summary>
        public bool NameIsDefault { get; }

        /// <summary>
        /// Gets the material.
        /// </summary>
        public virtual Material Material { get; }

        /// <summary>
        /// Gets the unique name.
        /// </summary>
        public string UniqueName { get; }
    }
}
