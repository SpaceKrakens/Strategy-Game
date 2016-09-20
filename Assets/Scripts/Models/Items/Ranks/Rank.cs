// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Rank.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the Rank type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assets.Scripts.Models.Items.Ranks
{
    using System;

    using Assets.Scripts.Models.Items.Weapons;

    /// <summary>
    /// Defines a weapon rank, indicating the rank of a weapon and the highest rank of a weapon a unit can use.
    /// </summary>
    public class Rank : IEquatable<Rank>, IComparable<Rank>
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Rank"/> class.
        /// </summary>
        /// <param name="experience">
        /// The amount of experience a Unit has accumulated in this WeaponType's rank.
        /// </param>
        /// <param name="level">
        /// The level, or in other words Weapon Rank of that Weapon.
        /// </param>
        /// <param name="weaponType">
        /// The weapon type for this Rank.
        /// </param>
        public Rank(int experience, int level, WeaponType weaponType)
        {
            this.Experience = experience;
            this.Level = level;
            this.WeaponType = weaponType;
        }

        /// <summary>
        /// Gets or sets the experience. At certain levels of experience, the Level rises.
        /// </summary>
        public int Experience { get; set; }

        /// <summary>
        /// Gets or sets the level or in other words 'rank' of this rank.
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Gets or sets the weapon type of the rank.
        /// </summary>
        public WeaponType WeaponType { get; set; }

        #region IEquatable and IComparable implementation
        
        /// <summary>
        /// Equality operator for ranks.
        /// </summary>
        /// <param name="left">
        /// The left rank.
        /// </param>
        /// <param name="right">
        /// The right rank.
        /// </param>
        /// <returns>
        /// True, if equal, false if not.
        /// </returns>
        public static bool operator ==(Rank left, Rank right)
        {
            return Rank.Equals(left, right);
        }

        /// <summary>
        /// Inequality operator for ranks.
        /// </summary>
        /// <param name="left">
        /// The left rank.
        /// </param>
        /// <param name="right">
        /// The right rank.
        /// </param>
        /// <returns>
        /// True, if unequal, false if not.
        /// </returns>
        public static bool operator !=(Rank left, Rank right)
        {
            return !Rank.Equals(left, right);
        }

        /// <summary>
        /// Greater than operator for ranks.
        /// </summary>
        /// <param name="operand1">
        /// The left rank.
        /// </param>
        /// <param name="operand2">
        /// The right rank.
        /// </param>
        /// <returns>
        /// True, if the left value is greater than the right value, false if not.
        /// </returns>
        public static bool operator >(Rank operand1, Rank operand2)
        {
            return operand1.CompareTo(operand2) == 1;
        }

        /// <summary>
        /// Less than operator for ranks.
        /// </summary>
        /// <param name="operand1">
        /// The left rank.
        /// </param>
        /// <param name="operand2">
        /// The right rank.
        /// </param>
        /// <returns>
        /// True, if the left value is less than the right value, false if not.
        /// </returns>
        public static bool operator <(Rank operand1, Rank operand2)
        {
            return operand1.CompareTo(operand2) == -1;
        }

        /// <summary>
        /// Greater than or equal operator for ranks.
        /// </summary>
        /// <param name="operand1">
        /// The left rank.
        /// </param>
        /// <param name="operand2">
        /// The right rank.
        /// </param>
        /// <returns>
        /// True, if the left value is greater than or equal to the right value, false if not.
        /// </returns>
        public static bool operator >=(Rank operand1, Rank operand2)
        {
            return operand1.CompareTo(operand2) >= 0;
        }

        /// <summary>
        /// Less than or equal operator for ranks.
        /// </summary>
        /// <param name="operand1">
        /// The left rank.
        /// </param>
        /// <param name="operand2">
        /// The right rank.
        /// </param>
        /// <returns>
        /// True, if the left value is less than or equal to the right value, false if not.
        /// </returns>
        public static bool operator <=(Rank operand1, Rank operand2)
        {
            return operand1.CompareTo(operand2) <= 0;
        }

        /// <summary>
        /// Checks to see if the weapon rank is equal to another.
        /// </summary>
        /// <param name="other">
        /// The other weapon rank to check against.
        /// </param>
        /// <returns>
        /// True if they equal each other. False if not.
        /// </returns>
        public bool Equals(Rank other)
        {
            return other != null && (this.WeaponType == other.WeaponType && this.Level == other.Level);
        }

        /// <summary>
        /// Checks if this instance of the <see cref="Rank"/> class equals an other object.
        /// </summary>
        /// <param name="obj">
        /// The object to check against.
        /// </param>
        /// <returns>
        /// True if they equal each other. False if not.
        /// </returns>
        public override bool Equals(object obj)
        {
            return obj?.GetType() == typeof(Rank) && this.Equals((Rank)obj);
        }

        /// <summary>
        /// Gets a somewhat unique hash code for this rank instance.
        /// </summary>
        /// <returns>
        /// A unique integer hash.
        /// </returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return (this.Level * 397) ^ (int)this.WeaponType;
            }
        }

        /// <summary>
        /// Compares two weapon ranks with each other.
        /// </summary>
        /// <param name="other">
        /// The other weapon rank to check against.
        /// </param>
        /// <returns>
        /// 1 if bigger, 0 if equal, -1 if smaller.
        /// </returns>
        public int CompareTo(Rank other)
        {
            return other == null || this.WeaponType != other.WeaponType ? 1 : this.Level.CompareTo(other.Level);
        }

        #endregion
    }
}
