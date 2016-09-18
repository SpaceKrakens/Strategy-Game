#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stat.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Assets.Scripts.Models.Characters.Stats
{
    /// <summary>
    /// The stat interface.
    /// </summary>
    public abstract class Stat
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Stat"/> class.
        /// </summary>
        /// <param name="current">The current.</param>
        /// <param name="maximum">The maximum.</param>
        /// <param name="growthRate">The growth rate.</param>
        /// <param name="bonus">The bonus.</param>
        protected Stat(int current, int maximum, float growthRate, int bonus)
        {
            this.Current = current;
            this.Bonus = bonus;
            this.Maximum = maximum;
            this.GrowthRate = growthRate;
        }

        /// <summary>
        /// Gets or sets the bonus to the stat value.
        /// </summary>
        public int Bonus { get; set; }

        /// <summary>
        /// Gets or sets the current value of the stat.
        /// </summary>
        public int Current { get; set; }

        /// <summary>
        /// Gets or sets the maximum stat value.
        /// </summary>
        public int Maximum { get; set; }

        /// <summary>
        /// Gets or sets the growth rate.
        /// </summary>
        public float GrowthRate { get; set; }

        /// <summary>
        /// Implicitly converts a Stat into an integer value.
        /// </summary>
        /// <param name="stat">The Stat to convert.</param>
        /// <returns>The sum of <code>stat.Current</code> and <code>stat.Bonus</code>.
        /// </returns>
        public static implicit operator int(Stat stat)
        {
            return stat.Current + stat.Bonus;
        }
    }
}