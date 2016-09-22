// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Class.cs" company="Dormanil">
//   MIT License
//   Copyright (c) 2016 Dormanil
// </copyright>
// <summary>
//   Defines the Class type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assets.Scripts.Models.Characters.Classes
{
    using System.Collections.Generic;

    using Assets.Scripts.Models.Characters.Stats;

    /// <summary>
    /// Defines the Class type.
    /// </summary>
    public class Class
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Class"/> class.
        /// </summary>
        /// <param name="baseHealth">The base health.</param>
        /// <param name="maxBaseHealth">The max Base Health.</param>
        /// <param name="baseStrength">The base Strength.</param>
        /// <param name="maxBaseStrength">The max Base Strength.</param>
        /// <param name="baseMagic">The base Magic.</param>
        /// <param name="maxBaseMagic">The max Base Magic.</param>
        /// <param name="baseSkill">The base Skill.</param>
        /// <param name="maxBaseSkill">The max Base Skill.</param>
        /// <param name="baseSpeed">The base Speed.</param>
        /// <param name="maxBaseSpeed">The max Base Speed.</param>
        /// <param name="baseLuck">The base Luck.</param>
        /// <param name="maxBaseLuck">The max Base Luck.</param>
        /// <param name="baseDefence">The base Defence.</param>
        /// <param name="maxBaseDefence">The max Base Defence.</param>
        /// <param name="baseResistance">The base Resistance.</param>
        /// <param name="maxBaseResistance">The max Base Resistance.</param>
        /// <param name="baseMoveRange">The base Move Range.</param>
        /// <param name="baseHealthGrowth">The base Health Growth.</param>
        /// <param name="baseStrengthGrowth">The base Strength Growth.</param>
        /// <param name="baseMagicGrowth">The base Magic Growth.</param>
        /// <param name="baseSkillGrowth">The base Skill Growth.</param>
        /// <param name="baseSpeedGrowth">The base Speed Growth.</param>
        /// <param name="baseLuckGrowth">The base Luck Growth.</param>
        /// <param name="baseDefenceGrowth">The base Defence Growth.</param>
        /// <param name="baseResistanceGrowth">The base Resistance Growth.</param>
        /// <param name="isBaseClass">Indicates base class or not.</param>
        /// <param name="isSpecialClass">Indicates special class or not.</param>
        /// <param name="secondTierClasses">The list of second tier classes.</param>
        public Class(int baseHealth, int maxBaseHealth, int baseStrength, int maxBaseStrength, int baseMagic, int maxBaseMagic, int baseSkill, int maxBaseSkill, int baseSpeed, int maxBaseSpeed, int baseLuck, int maxBaseLuck, int baseDefence, int maxBaseDefence, int baseResistance, int maxBaseResistance, int baseMoveRange, float baseHealthGrowth, float baseStrengthGrowth, float baseMagicGrowth, float baseSkillGrowth, float baseSpeedGrowth, float baseLuckGrowth, float baseDefenceGrowth, float baseResistanceGrowth, bool isBaseClass, bool isSpecialClass, List<Class> secondTierClasses)
            : this(new Health(baseHealth, maxBaseHealth, baseHealthGrowth), new Strength(baseStrength, maxBaseStrength, baseStrengthGrowth), new Magic(baseMagic, maxBaseMagic, baseMagicGrowth), new Skill(baseSkill, maxBaseSkill, baseSkillGrowth), new Speed(baseSpeed, maxBaseSpeed, baseSpeedGrowth), new Luck(baseLuck, maxBaseLuck, baseLuckGrowth), new Defence(baseDefence, maxBaseDefence, baseDefenceGrowth), new Resistance(baseResistance, maxBaseResistance, baseResistanceGrowth), new Movement(baseMoveRange), isBaseClass, isSpecialClass, secondTierClasses)
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="Class"/> class.
        /// </summary>
        /// <param name="baseHealth">The base health.</param>
        /// <param name="baseStrength">The base strength.</param>
        /// <param name="baseMagic">The base magic.</param>
        /// <param name="baseSkill">The base skill.</param>
        /// <param name="baseSpeed">The base speed.</param>
        /// <param name="baseLuck">The base luck.</param>
        /// <param name="baseDefence">The base defence.</param>
        /// <param name="baseResistance">The base resistance.</param>
        /// <param name="baseMoveRange">The base move range.</param>
        /// <param name="isBaseClass">Indicates base class or not.</param>
        /// <param name="isSpecialClass">Indicates special class or not.</param>
        /// <param name="secondTierClasses">The list of second tier classes.</param>
        public Class(Health baseHealth, Strength baseStrength, Magic baseMagic, Skill baseSkill, Speed baseSpeed, Luck baseLuck, Defence baseDefence, Resistance baseResistance, Movement baseMoveRange, bool isBaseClass, bool isSpecialClass, List<Class> secondTierClasses)
        {
            this.BaseHealth = baseHealth;
            this.BaseStrength = baseStrength;
            this.BaseMagic = baseMagic;
            this.BaseSkill = baseSkill;
            this.BaseSpeed = baseSpeed;
            this.BaseLuck = baseLuck;
            this.BaseDefence = baseDefence;
            this.BaseResistance = baseResistance;
            this.BaseMoveRange = baseMoveRange;
            this.IsBaseClass = isBaseClass;
            this.IsSpecialClass = isSpecialClass;
            this.SecondTierClasses = secondTierClasses;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="Class"/> class. 
        /// This constructor is solely meant for deserialisation purposes only.
        /// </summary>
        protected Class()
        {
        }

        /// <summary>
        /// Gets the base health.
        /// </summary>
        public Health BaseHealth { get; }

        /// <summary>
        /// Gets the base strength.
        /// </summary>
        public Strength BaseStrength { get; }

        /// <summary>
        /// Gets the base magic.
        /// </summary>
        public Magic BaseMagic { get; }

        /// <summary>
        /// Gets the base skill.
        /// </summary>
        public Skill BaseSkill { get; }

        /// <summary>
        /// Gets the base speed.
        /// </summary>
        public Speed BaseSpeed { get; }

        /// <summary>
        /// Gets the base luck.
        /// </summary>
        public Luck BaseLuck { get; }

        /// <summary>
        /// Gets the base defence.
        /// </summary>
        public Defence BaseDefence { get; }

        /// <summary>
        /// Gets the base resistance.
        /// </summary>
        public Resistance BaseResistance { get; }

        /// <summary>
        /// Gets the base move range.
        /// </summary>
        public Movement BaseMoveRange { get; }

        /// <summary>
        /// Gets a value indicating whether it is a base class.
        /// </summary>
        public bool IsBaseClass { get; }

        /// <summary>
        /// Gets a value indicating whether it is a special class.
        /// </summary>
        public bool IsSpecialClass { get; }

        /// <summary>
        /// Gets the list of second tier classes.
        /// </summary>
        public List<Class> SecondTierClasses { get; }
    }
}
