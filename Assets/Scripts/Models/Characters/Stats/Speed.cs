#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Speed.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Assets.Scripts.Models.Characters.Stats
{
    /// <summary>
    /// The speed stat.
    /// </summary>
    public class Speed : Stat
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Speed"/> class.
        /// </summary>
        /// <param name="current">The current.</param>
        /// <param name="maximum">The maximum.</param>
        /// <param name="growthRate">The growth rate.</param>
        /// <param name="bonus">The bonus.</param>
        public Speed(int current, int maximum, float growthRate, int bonus = 0)
            : base(current, maximum, growthRate, bonus)
        {
        }
    }
}