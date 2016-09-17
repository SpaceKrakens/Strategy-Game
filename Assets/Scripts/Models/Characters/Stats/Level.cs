#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Level.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Assets.Scripts.Models.Characters.Stats
{
    /// <summary>
    /// The level.
    /// </summary>
    public class Level
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Level"/> class.
        /// </summary>
        /// <param name="current">
        /// The current.
        /// </param>
        /// <param name="maximum">
        /// The maximum.
        /// </param>
        public Level(int current, int maximum)
        {
            this.Current = current;
            this.Maximum = maximum;
        }

        /// <summary>
        /// Gets or sets the current level.
        /// </summary>
        public int Current { get; set; }

        /// <summary>
        /// Gets or sets the maximum.
        /// </summary>
        public int Maximum { get; set; }
    }
}