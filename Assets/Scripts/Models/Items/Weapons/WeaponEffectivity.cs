#region LICENSE
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WeaponEffectivity.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Assets.Scripts.Models.Items.Weapons
{
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
}