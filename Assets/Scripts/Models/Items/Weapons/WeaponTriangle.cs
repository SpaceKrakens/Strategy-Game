#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WeaponTriangle.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the WeaponTriangle type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#endregion

namespace Assets.Scripts.Models.Items.Weapons
{
    using System;
    using System.Collections.Generic;

    using static WeaponEffectivity;

    using static WeaponType;

    /// <summary>
    /// The weapon triangle.
    /// </summary>
    internal static class WeaponTriangle
    {
        /// <summary>
        /// The default weapon triangle.
        /// </summary>
        /// <returns>
        /// The default weapon triangle as a <see cref="Dictionary{TKey,TValue}"/> .
        /// </returns>
        internal static Dictionary<WeaponType, WeaponEffectivity[]> DefaultWeaponTriangle()
        {
            return new Dictionary<WeaponType, WeaponEffectivity[]>(15)
                       {
                               {
                                   Sword,
                                   new[]
                                       {
                                           Neutral, Weak, Strong, Strong, Weak, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral
                                       }
                               },
                               {
                                   Lance,
                                   new[]
                                       {
                                           Strong, Neutral, Weak, Weak, Neutral, Strong, Strong, Strong, Strong, Strong, Neutral, Neutral, Neutral, Neutral, Neutral
                                       }
                               },
                               {
                                   Axe,
                                   new[]
                                       {
                                           Weak, Strong, Neutral, Neutral, Strong, Weak, Weak, Weak, Weak, Weak, Neutral, Neutral, Neutral, Neutral, Neutral
                                       }
                               },
                               {
                                   Bow,
                                   new[]
                                       {
                                           Weak, Strong, Neutral, Neutral, Strong, Weak, Weak, Weak, Weak, Weak, Neutral, Neutral, Neutral, Neutral, Neutral
                                       }
                               },
                               {
                                   Dagger,
                                   new[]
                                       {
                                           Strong, Neutral, Weak, Weak, Neutral, Strong, Strong, Strong, Strong, Strong, Neutral, Neutral, Neutral, Neutral, Neutral
                                       }
                               },
                               {
                                   Fire,
                                   new[]
                                       {
                                           Neutral, Weak, Strong, Strong, Weak, Neutral, Strong, Weak, Strong, Weak, Neutral, Neutral, Neutral, Neutral, Neutral
                                       }
                               },
                               {
                                   Wind,
                                   new[]
                                       {
                                           Neutral, Weak, Strong, Strong, Weak, Weak, Neutral, Strong, Strong, Weak, Neutral, Neutral, Neutral, Neutral, Neutral
                                       }
                               },
                               {
                                   Thunder,
                                   new[]
                                       {
                                           Neutral, Weak, Strong, Strong, Weak, Strong, Weak, Neutral, Strong, Weak, Neutral, Neutral, Neutral, Neutral, Neutral
                                       }
                               },
                               {
                                   Light,
                                   new[]
                                       {
                                           Neutral, Weak, Strong, Strong, Weak, Weak, Weak, Weak, Neutral, Strong, Neutral, Neutral, Neutral, Neutral, Neutral
                                       }
                               },
                               {
                                   Dark,
                                   new[]
                                       {
                                           Neutral, Weak, Strong, Strong, Weak, Strong, Strong, Strong, Weak, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral
                                       }
                               },
                               {
                                   Claws,
                                   new[]
                                       {
                                           Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Weak, Strong, Strong, Weak
                                       }
                               },
                               {
                                   Talons,
                                   new[]
                                       {
                                           Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Strong, Neutral, Weak, Strong, Weak
                                       }
                               },
                               {
                                   Beak,
                                   new[]
                                       {
                                           Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Weak, Strong, Neutral, Strong, Weak
                                       }
                               },
                               {
                                   Fangs,
                                   new[]
                                       {
                                           Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Weak, Weak, Weak, Neutral, Strong
                                       }
                               },
                               {
                                   Breath,
                                   new[]
                                       {
                                           Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Neutral, Strong, Strong, Strong, Weak, Neutral
                                       }
                               }
                       };
        }

        /// <summary>
        /// The inverted weapon triangle.
        /// </summary>
        /// <returns>
        /// The inverted weapon triangle as a <see cref="Dictionary{TKey,TValue}"/>.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Should the weird case happen that the default weapon triangle is broken.
        /// </exception>
        internal static Dictionary<WeaponType, WeaponEffectivity[]> InvertedWeaponTriangle()
        {
            Dictionary<WeaponType, WeaponEffectivity[]> defaultWeaponTriangle = DefaultWeaponTriangle();
            Dictionary<WeaponType, WeaponEffectivity[]> invertedDictionary = new Dictionary<WeaponType, WeaponEffectivity[]>();
            foreach (WeaponType weaponType in defaultWeaponTriangle.Keys)
            {
                List<WeaponEffectivity> invertedEffectivities = new List<WeaponEffectivity>(15);
                foreach (WeaponEffectivity effectivity in defaultWeaponTriangle[weaponType])
                {
                    WeaponEffectivity newEffectivity;
                    switch (effectivity)
                    {
                        case Neutral:
                            newEffectivity = Neutral;
                            break;
                        case Strong:
                            newEffectivity = Weak;
                            break;
                        case Weak:
                            newEffectivity = Strong;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    invertedEffectivities.Add(newEffectivity);
                }

                invertedDictionary.Add(weaponType, invertedEffectivities.ToArray());
            }

            return invertedDictionary;
        }
    }
}