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
        /// <param name="bonus">
        /// The bonus.
        /// </param>
        /// <param name="current">
        /// The current.
        /// </param>
        /// <param name="maximum">
        /// The maximum.
        /// </param>
        public Magic(int bonus, int current, int maximum)
            : base(bonus, current, maximum)
        {
        }
    }
}