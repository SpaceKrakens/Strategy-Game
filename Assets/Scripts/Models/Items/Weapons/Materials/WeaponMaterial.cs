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
        /// Initialises a new instance of the <see cref="WeaponMaterial"/> class.
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
        /// The bronze.
        /// </summary>
        public static WeaponMaterial Bronze => new WeaponMaterial("Bronze", unit => unit.Stats.CritEvade += 10, unit => unit.Stats.CritEvade -= 10);

        /// <summary>
        /// The iron.
        /// </summary>
        public static WeaponMaterial Iron => new WeaponMaterial(
            "Iron", 
            unit => 
                {
                    unit.Stats.Strength.Bonus++;
                    unit.Stats.Skill.Bonus++;
                }, 
            unit =>
                {
                    unit.Stats.Strength.Bonus--;
                    unit.Stats.Skill.Bonus--;
                });

        /// <summary>
        /// The name of the WeaponMaterial. NOT IMPLEMENTED.
        /// </summary>
        /// <returns>The name of the WeaponMaterial</returns>
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}