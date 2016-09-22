// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RN1.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the RN1 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assets.Scripts.Utils
{
    using System;

    /// <summary>
    /// Defines a random number generator for use with everything else.
    /// </summary>
    public class RN1
    {
        /// <summary>
        /// Backing system RNG.
        /// </summary>
        private readonly Random random;

        /// <summary>
        /// Initialises a new instance of the <see cref="RN1"/> class.
        /// Random number generator using one number.
        /// </summary>
        public RN1()
        {
            this.random = new Random();
        }

        /// <summary>
        /// Asks the RN1 if this chance succeeds.
        /// </summary>
        /// <param name="chance">The chance to do anything else than a weapon hit.</param>
        /// <returns><code>true</code> if it succeeds, <code>false</code> if not.</returns>
        public bool Succeeds(int chance)
        {
            return this.random.Next(1, 100) <= chance;
        }
    }
}
