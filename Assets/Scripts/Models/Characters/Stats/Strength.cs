#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Strength.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Assets.Scripts.Models.Characters.Stats
{
    /// <summary>
    /// The strength stat.
    /// </summary>
    public class Strength : Stat
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Strength"/> class. 
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
        public Strength(int bonus, int current, int maximum)
            : base(bonus, current, maximum)
        {
        }
    }
}