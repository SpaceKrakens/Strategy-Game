#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WorldControler.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Assets.Scripts.Controlers
{
    using Models.Characters;
    using Models.Items;
    using Models.Items.Weapons;
    using Models.Items.Weapons.Materials;

    using UnityEngine;

    /// <summary>
    /// The controller for everything in the world.
    /// </summary>
    public class WorldControler : MonoBehaviour
    {
        /// <summary>
        /// Runs when the game starts.
        /// </summary>
        public void Start()
        {
            Unit test = new Unit(
                "Test",
                "Test",
                null,
                null);

            Item testweapon = new Regular(WeaponType.Axe, WeaponMaterial.Bronze, null);

            test.AddItem(testweapon);
        }

        /// <summary>
        /// Update called by unity. Called every frame.
        /// </summary>
        public void Update()
        {
        }
    }
}