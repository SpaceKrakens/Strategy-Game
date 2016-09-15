#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Health.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Assets.Scripts.Models.Characters.Stats
{
    /// <summary>
    /// The health.
    /// </summary>
    public class Health : Stat
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Health"/> class. 
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
        public Health(int bonus, int current, int maximum)
            : base(bonus, current, maximum)
        {
        }
    }
}