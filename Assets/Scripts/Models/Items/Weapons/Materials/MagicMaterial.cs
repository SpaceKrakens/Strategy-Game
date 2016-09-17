#region LICENSE
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MagicMaterial.cs" company="SpaceKrakens">
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
    /// The Material class for Magic Weapons.
    /// </summary>
    public class MagicMaterial : Material
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="MagicMaterial"/> class.
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
        private MagicMaterial(string name, Action<Unit> applyMaterialAction, Action<Unit> unapplyMaterialAction)
        {
            this.Name = name;
            this.ApplyMaterialAction = applyMaterialAction;
            this.UnapplyMaterialAction = unapplyMaterialAction;
        }

        /// <summary>
        /// Tier one MagicMaterial. (Template for Kaz)
        /// </summary>
        public static MagicMaterial TierOne => new MagicMaterial("TierOne", unit => unit.Stats.Resistance.Bonus += 2, unit => unit.Stats.Resistance.Bonus -= 2);

        /// <summary>
        /// The name of the MagicMaterial. NOT IMPLEMENTED
        /// </summary>
        /// <returns>The name of the MagicMaterial.</returns>
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
