#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Movement.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Assets.Scripts.Models.Characters.Stats
{
    /// <summary>
    /// The movement range.
    /// </summary>
    public class Movement
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Movement"/> class.
        /// </summary>
        /// <param name="current">
        /// The current.
        /// </param>
        /// <param name="bonus">
        /// The bonus.
        /// </param>
        public Movement(int current, int bonus = 0)
        {
            this.Bonus = bonus;
            this.Current = current;
        }

        /// <summary>
        /// Gets or sets the bonus movement range.
        /// </summary>
        public int Bonus { get; set; }

        /// <summary>
        /// Gets or sets the current movement range.
        /// </summary>
        public int Current { get; set; }
    }
}