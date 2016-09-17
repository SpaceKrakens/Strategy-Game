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
        /// <param name="bonus">
        /// The bonus.
        /// </param>
        /// <param name="current">
        /// The current.
        /// </param>
        /// <param name="maximum">
        /// The maximum.
        /// </param>
        public Skill(int bonus, int current, int maximum)
            : base(bonus, current, maximum)
        {
        }
    }
}