// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RN2.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the RN2 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assets.Scripts.Utils
{
    using System;

    /// <summary>
    /// Defines a random number generator for use with hit chances.
    /// </summary>
    public class RN2
    {
        /// <summary>
        /// Backing system RNG.
        /// </summary>
        private readonly Random random;

        /// <summary>
        /// Initialises a new instance of the <see cref="RN2"/> class.
        /// Random number generator using two numbers.
        /// </summary>
        public RN2()
        {
            this.random = new Random();
        }

        /// <summary>
        /// Asks the RN2 if this attack hits.
        /// </summary>
        /// <param name="chance">The chance to hit.</param>
        /// <returns><code>true</code> if it hits, <code>false</code> if not.</returns>
        public bool Hits(int chance)
        {
            int result1 = this.random.Next(1, 100);
            int result2 = this.random.Next(1, 100);

            return (result1 + result2) / 2 <= chance;
        }
    }
}
