#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WeaponType.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Assets.Scripts.Models.Items.Weapons
{
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
}