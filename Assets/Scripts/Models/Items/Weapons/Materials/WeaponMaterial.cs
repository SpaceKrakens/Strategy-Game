#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WeaponMaterial.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Assets.Scripts.Models.Items.Weapons.Materials
{
    using System;

    using Assets.Scripts.Models.Characters;

    /// <summary>
    /// The weapon material.
    /// </summary>
    public class WeaponMaterial : Material
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeaponMaterial"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="applyMaterialAction">
        /// The apply material action.
        /// </param>
        /// <param name="unapplyMaterialAction">
        /// The un apply material action.
        /// </param>
        private WeaponMaterial(string name, Action<Unit> applyMaterialAction, Action<Unit> unapplyMaterialAction)
        {
            this.Name = name;
            this.ApplyMaterialAction = applyMaterialAction;
            this.UnapplyMaterialAction = unapplyMaterialAction;
        }

        /// <summary>
        /// The brass.
        /// </summary>
        public static WeaponMaterial Brass => new WeaponMaterial("Brass", unit => unit.Stats.Speed.Bonus += 5, unit => unit.Stats.Speed.Bonus -= 5);
    }
}