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
    using System.Collections.Generic;

    #region Weapon Enums

    /// <summary>
    /// All weapon types.
    /// </summary>
    public enum WeaponType
    {
        /// <summary>
        /// A sword. Strong against axes/bows. Weak against lances/daggers.
        /// </summary>
        Sword,

        /// <summary>
        /// A lance. Strong against swords/magic. Weak against axes/bows.
        /// </summary>
        Lance,

        /// <summary>
        /// An axe. Strong against lances/daggers. Weak against swords/magic.
        /// </summary>
        Axe,

        /// <summary>
        /// A bow. Strong against lances/daggers. Weak against swords/magic.
        /// </summary>
        Bow,

        /// <summary>
        /// A dagger. Strong against swords/magic. Weak against axes/bows.
        /// </summary>
        Dagger,

        /// <summary>
        /// Fire magic. Strong against wind and light magic. Weak against thunder and dark magic.
        /// Magic is strong against axes/bows. Weak against lances/daggers.
        /// </summary>
        Fire,

        /// <summary>
        /// Wind magic. Strong against thunder and light magic. Weak against fire and dark magic.
        /// Magic is strong against axes/bows. Weak against lances/daggers.
        /// </summary>
        Wind,
        
        /// <summary>
        /// Thunder magic. Strong against fire and light magic. Weak against wind and dark magic.
        /// Magic is strong against axes/bows. Weak against lances/daggers.
        /// </summary>
        Thunder,

        /// <summary>
        /// Light magic. Strong against dark magic. Weak against fire, wind and thunder magic.
        /// Magic is strong against axes/bows. Weak against lances/daggers.
        /// </summary>
        Light,

        /// <summary>
        /// Dark magic. Strong against fire, wind and thunder magic. Weak against light magic.
        /// Magic is strong against axes/bows. Weak against lances/daggers.
        /// </summary>
        Dark,

        /// <summary>
        /// Claws. Strong against beaks and fangs. Weak against talons and breath. 
        /// </summary>
        Claws,

        /// <summary>
        /// Talons. Strong against claws and fangs. Weak against beaks and breath.
        /// </summary>
        Talons,

        /// <summary>
        /// A beak. Strong against talons and fangs. Weak against claws and breath.
        /// </summary>
        Beak,

        /// <summary>
        /// Fangs. Strong against breath. Weak against claws, talons and beaks.
        /// </summary>
        Fangs,

        /// <summary>
        /// Breath. Strong against claws, talons and beaks. Weak against fangs.
        /// </summary>
        Breath
    }

    /// <summary>
    /// The weapon effectivity.
    /// </summary>
    public enum WeaponEffectivity
    {
        /// <summary>
        /// The weapon hits normally.
        /// </summary>
        Neutral,

        /// <summary>
        /// The weapon is strong against the opposing weapon.
        /// </summary>
        Strong,

        /// <summary>
        /// The weapon is weak against the opposing weapon.
        /// </summary>
        Weak
    }

    /// <summary>
    /// The weapon material.
    /// </summary>
    public enum WeaponMaterial
    {
        /// <summary>
        /// Made of brass.
        /// </summary>
        Brass,

        /// <summary>
        /// Made of iron.
        /// </summary>
        Iron,

        /// <summary>
        /// Made of steel.
        /// </summary>
        Steel,

        /// <summary>
        /// Made of silver.
        /// </summary>
        Silver
    }
    
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
        public Weapon(WeaponType weaponType, WeaponMaterial material, bool weaponTriangleIsDefault = true, bool nameIsDefault = true, string uniqueName = null)
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
        protected WeaponType WeaponType { get; }

        /// <summary>
        /// The weapon's personal weapon triangle.
        /// </summary>
        protected WeaponEffectivity[] WeaponTriangle => this.WeaponTriangleIsDefault ? DefaultWeaponTriangle[this.WeaponType] : InvertedWeaponTriangle[this.WeaponType];

        /// <summary>
        /// Gets a value indicating whether the used weapon triangle is the default one.
        /// </summary>
        protected bool WeaponTriangleIsDefault { get; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        protected string Name => this.NameIsDefault ? this.Material.ToString() + " " + this.WeaponType.ToString() : this.UniqueName;

        /// <summary>
        /// Gets a value indicating whether name is default.
        /// </summary>
        protected bool NameIsDefault { get; }

        /// <summary>
        /// Gets the material.
        /// </summary>
        protected WeaponMaterial Material { get; }

        /// <summary>
        /// Gets the unique name.
        /// </summary>
        protected string UniqueName { get; }
    }
}
