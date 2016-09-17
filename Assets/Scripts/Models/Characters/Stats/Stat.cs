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
        /// <param name="bonus">
        /// The bonus.
        /// </param>
        /// <param name="current">
        /// The current.
        /// </param>
        /// <param name="maximum">
        /// The maximum.
        /// </param>
        protected Stat(int bonus, int current, int maximum)
        {
            this.Current = current;
            this.Bonus = bonus;
            this.Maximum = maximum;
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
        /// Implicitly converts a Stat into an integer value.
        /// </summary>
        /// <param name="stat">
        /// The Stat to convert.
        /// </param>
        /// <returns>
        /// The sum of stat.Current and stat.Bonus.
        /// </returns>
        public static implicit operator int(Stat stat)
        {
            return stat.Current + stat.Bonus;
        }
    }
}