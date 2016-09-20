#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Skill.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Assets.Scripts.Models.Characters.Stats
{
    /// <summary>
    /// The skill stat.
    /// </summary>
    public class Skill : Stat
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Skill"/> class. 
        /// </summary>
        /// <param name="current">The current.</param>
        /// <param name="maximum">The maximum.</param>
        /// <param name="growthRate">The growth rate.</param>
        /// <param name="bonus">The bonus.</param>
        public Skill(int current, int maximum, float growthRate, int bonus = 0)
            : base(current, maximum, growthRate, bonus)
        {
        }
    }
}