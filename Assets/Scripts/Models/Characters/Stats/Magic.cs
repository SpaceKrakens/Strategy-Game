#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Magic.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Assets.Scripts.Models.Characters.Stats
{
    /// <summary>
    /// The magic stat.
    /// </summary>
    public class Magic : Stat
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Magic"/> class. 
        /// </summary>
        /// <param name="current">The current.</param>
        /// <param name="maximum">The maximum.</param>
        /// <param name="growthRate">The growth rate.</param>
        /// <param name="bonus">The bonus.</param>
        public Magic(int current, int maximum, float growthRate, int bonus = 0)
            : base(current, maximum, growthRate, bonus)
        {
        }
    }
}