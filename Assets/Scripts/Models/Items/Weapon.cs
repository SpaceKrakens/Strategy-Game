// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Weapon.cs" company="Dormanil">
//   MIT License
//   Copyright (c) 2016 Dormanil
// </copyright>
// <summary>
//   Defines the "Weapon" type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assets.Scripts.Models.Items
{
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
    
    #endregion
    
    /// <summary>
    /// The weapon.
    /// </summary>
    public class Weapon
    {
        /// <summary>
        /// The default weapon triangle.
        /// </summary>
        private static readonly Dictionary<WeaponType, WeaponEffectivity[]> DefaultWeaponTriangle = 
            Items.WeaponTriangle.DefaultWeaponTriangle();

        /// <summary>
        /// The inverted weapon triangle.
        /// </summary>
        private static readonly Dictionary<WeaponType, WeaponEffectivity[]> InvertedWeaponTriangle =
            Items.WeaponTriangle.InvertedWeaponTriangle();

        /// <summary>
        /// Initializes a new instance of the <see cref="Weapon"/> class.
        /// </summary>
        /// <param name="weaponType">
        /// The weapon type.
        /// </param>
        /// <param name="isDefault">
        /// The value indicating whether the default weapon triangle should be used.
        /// </param>
        public Weapon(WeaponType weaponType, bool isDefault)
        {
            this.WeaponType = weaponType;
            this.IsDefault = isDefault;
        }

        /// <summary>
        /// Gets the weapon type.
        /// </summary>
        protected WeaponType WeaponType { get; }

        /// <summary>
        /// The weapon's personal weapon triangle.
        /// </summary>
        protected WeaponEffectivity[] WeaponTriangle => this.IsDefault ? DefaultWeaponTriangle[this.WeaponType] : 
            InvertedWeaponTriangle[this.WeaponType];

        /// <summary>
        /// Gets a value indicating whether is the used weapon triangle is the default one.
        /// </summary>
        protected bool IsDefault { get; }
    }
}
