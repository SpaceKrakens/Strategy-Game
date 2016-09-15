#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Defence.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Assets.Scripts.Models.Characters.Stats
{
    /// <summary>
    /// The defence stat.
    /// </summary>
    public class Defence : Stat
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Defence"/> class. 
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
        public Defence(int bonus, int current, int maximum)
            : base(bonus, current, maximum)
        {
        }
    }
}