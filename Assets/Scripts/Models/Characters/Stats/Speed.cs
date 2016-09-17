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
        /// <param name="bonus">
        /// The bonus.
        /// </param>
        /// <param name="current">
        /// The current.
        /// </param>
        /// <param name="maximum">
        /// The maximum.
        /// </param>
        public Speed(int bonus, int current, int maximum)
            : base(bonus, current, maximum)
        {
        }
    }
}