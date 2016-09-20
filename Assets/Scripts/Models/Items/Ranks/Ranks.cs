// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Ranks.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the Ranks type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assets.Scripts.Models.Items.Ranks
{
    using System;
    using System.Collections.Generic;

    using Assets.Scripts.Models.Items.Weapons;

    /// <summary>
    /// Holds a dictionary of all ranks.
    /// </summary>
    public static class Ranks
    {
        /// <summary>
        /// Gets the rank dictionary, containing all basic ranks usable in Weapon instantiations.
        /// </summary>
        public static Dictionary<string, Rank> RankDictionary { get; } = GetDictionary();

        /// <summary>
        /// Creates the dictionary of all possible base weapon ranks.
        /// </summary>
        /// <returns>
        /// The dictionary of all possible base weapon ranks.
        /// </returns>
        private static Dictionary<string, Rank> GetDictionary()
        {
            Dictionary<string, Rank> dictionary = new Dictionary<string, Rank>();

            foreach (WeaponType weaponType in Enum.GetValues(typeof(WeaponType)))
            {
                dictionary.Add($"{weaponType}_E", new Rank(0, 0, weaponType));
                dictionary.Add($"{weaponType}_D", new Rank(0, 1, weaponType));
                dictionary.Add($"{weaponType}_C", new Rank(0, 2, weaponType));
                dictionary.Add($"{weaponType}_B", new Rank(0, 3, weaponType));
                dictionary.Add($"{weaponType}_A", new Rank(0, 4, weaponType));
                dictionary.Add($"{weaponType}_S", new Rank(0, 5, weaponType));
            }

            return dictionary;
        }
    }
}
