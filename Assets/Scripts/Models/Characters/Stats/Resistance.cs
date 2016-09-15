#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Resistance.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Assets.Scripts.Models.Characters.Stats
{
    /// <summary>
    /// The resistance stat.
    /// </summary>
    public class Resistance : Stat
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Resistance"/> class. 
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
        public Resistance(int bonus, int current, int maximum)
            : base(bonus, current, maximum)
        {
        }
    }
}