#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stats.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the Stats type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#endregion

namespace Assets.Scripts.Models.Items.Weapons
{
    using System;

    /// <summary>
    /// The weapon stats.
    /// </summary>
    public class Stats
    {
        /// <summary>
        /// The might.
        /// </summary>
        private int might;

        /// <summary>
        /// The hit chance.
        /// </summary>
        private int hitChance;

        /// <summary>
        /// The crit chance.
        /// </summary>
        private int? critChance;

        /// <summary>
        /// The avoid chance.
        /// </summary>
        private int avoidChance;

        /// <summary>
        /// The maximum amount of uses. Set to <code>null</code> to have it never break.
        /// </summary>
        private int? maximumUses;

        /// <summary>
        /// The current amount of uses left. Set to <code>null</code> to have it never break.
        /// </summary>
        private int? currentUses;

        /// <summary>
        /// Initializes a new instance of the <see cref="Stats"/> class.
        /// </summary>
        /// <param name="might">
        /// The might.
        /// </param>
        /// <param name="hitChance">
        /// The hit chance.
        /// </param>
        /// <param name="critChance">
        /// The crit chance.
        /// </param>
        /// <param name="avoidChance">
        /// The avoid chance.
        /// </param>
        /// <param name="maximumUses">
        /// The maximum uses.
        /// </param>
        /// <param name="currentUses">
        /// The current uses.
        /// </param>
        public Stats(int might, int hitChance, int? critChance, int avoidChance, int? maximumUses = null, int? currentUses = null)
        {
            this.Might = might;
            this.HitChance = hitChance;
            this.CritChance = critChance;
            this.AvoidChance = avoidChance;
            this.MaximumUses = maximumUses;
            this.CurrentUses = currentUses;
        }

        /// <summary>
        /// Gets or sets the might.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// When a negative amount for the might gets passed.
        /// </exception>
        public int Might
        {
            get
            {
                return this.might;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Negative values are not legal.", nameof(value));
                }

                this.might = value;
            }
        }

        /// <summary>
        /// Gets or sets the hit chance.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// When a negative amount for the hit chance gets passed.
        /// </exception>
        public int HitChance
        {
            get
            {
                return this.hitChance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Negative values are not legal.", nameof(value));
                }

                this.hitChance = value;
            }
        }

        /// <summary>
        /// Gets or sets the crit chance. Set to <code>null</code> to disallow crits entirely.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// When a negative amount for the crit chance gets passed.
        /// </exception>
        public int? CritChance
        {
            get
            {
                return this.critChance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Negative values are not legal.", nameof(value));
                }

                this.critChance = value;
            }
        }

        /// <summary>
        /// Gets or sets the avoid chance.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// When a negative amount for the avoid chance gets passed.
        /// </exception>
        public int AvoidChance
        {
            get
            {
                return this.avoidChance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Negative values are not legal.", nameof(value));
                }

                this.avoidChance = value;
            }
        }

        /// <summary>
        /// Gets or sets the maximum amount of uses. Set to <code>null</code> to have it never break.
        /// </summary>
        public int? MaximumUses
        {
            get
            {
                return this.maximumUses;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Negative values are not legal.", nameof(value));
                }

                this.maximumUses = value;
            }
        }

        /// <summary>
        /// Gets or sets the current amount of uses left. Set to <code>null</code> to have it never break.
        /// </summary>
        public int? CurrentUses
        {
            get
            {
                return this.currentUses;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Negative values are not legal.", nameof(value));
                }

                this.currentUses = value;
            }
        }

        /// <summary>
        /// Gets or sets the range of the weapon.
        /// </summary>
        public int Range { get; set; }
    }
}
