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
    /// <summary>
    /// Defines the Class type.
    /// </summary>
    public class Class
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="Class"/> class.
        /// </summary>
        /// <param name="baseHealth">The base health.</param>
        /// <param name="baseStrength">The base Strength.</param>
        /// <param name="baseMagic">The base Magic.</param>
        /// <param name="baseSkill">The base Skill.</param>
        /// <param name="baseSpeed">The base Speed.</param>
        /// <param name="baseLuck">The base Luck.</param>
        /// <param name="baseDefence">The base Defence.</param>
        /// <param name="baseResistance">The base Resistance.</param>
        /// <param name="baseMoveRange">The base Move Range.</param>
        /// <param name="baseHealthGrowth">The base Health Growth.</param>
        /// <param name="baseStrengthGrowth">The base Strength Growth.</param>
        /// <param name="baseMagicGrowth">The base Magic Growth.</param>
        /// <param name="baseSkillGrowth">The base Skill Growth.</param>
        /// <param name="baseSpeedGrowth">The base Speed Growth.</param>
        /// <param name="baseLuckGrowth">The base Luck Growth.</param>
        /// <param name="baseDefenceGrowth">The base Defence Growth.</param>
        /// <param name="baseResistanceGrowth">The base Resistance Growth.</param>
        /// <param name="isSpecialClass">Indicates special class or not.</param>
        /// <param name="isBaseClass">Indicates base class or not.</param>
        public Class(int baseHealth, int baseStrength, int baseMagic, int baseSkill, int baseSpeed, int baseLuck, int baseDefence, int baseResistance, int baseMoveRange, float baseHealthGrowth, float baseStrengthGrowth, float baseMagicGrowth, float baseSkillGrowth, float baseSpeedGrowth, float baseLuckGrowth, float baseDefenceGrowth, float baseResistanceGrowth, bool isSpecialClass, bool isBaseClass)
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
            this.BaseHealthGrowth = baseHealthGrowth;
            this.BaseStrengthGrowth = baseStrengthGrowth;
            this.BaseMagicGrowth = baseMagicGrowth;
            this.BaseSkillGrowth = baseSkillGrowth;
            this.BaseSpeedGrowth = baseSpeedGrowth;
            this.BaseLuckGrowth = baseLuckGrowth;
            this.BaseDefenceGrowth = baseDefenceGrowth;
            this.BaseResistanceGrowth = baseResistanceGrowth;
            this.IsSpecialClass = isSpecialClass;
            this.IsBaseClass = isBaseClass;
        }

        /// <summary>
        /// Gets the base health.
        /// </summary>
        public int BaseHealth { get; }

        /// <summary>
        /// Gets the base strength.
        /// </summary>
        public int BaseStrength { get; }

        /// <summary>
        /// Gets the base magic.
        /// </summary>
        public int BaseMagic { get; }

        /// <summary>
        /// Gets the base skill.
        /// </summary>
        public int BaseSkill { get; }

        /// <summary>
        /// Gets the base speed.
        /// </summary>
        public int BaseSpeed { get; }

        /// <summary>
        /// Gets the base luck.
        /// </summary>
        public int BaseLuck { get; }

        /// <summary>
        /// Gets the base defence.
        /// </summary>
        public int BaseDefence { get; }

        /// <summary>
        /// Gets the base resistance.
        /// </summary>
        public int BaseResistance { get; }

        /// <summary>
        /// Gets the base move range.
        /// </summary>
        public int BaseMoveRange { get; }

        /// <summary>
        /// Gets the base health growth.
        /// </summary>
        public float BaseHealthGrowth { get; }

        /// <summary>
        /// Gets the base strength growth.
        /// </summary>
        public float BaseStrengthGrowth { get; }

        /// <summary>
        /// Gets the base magic growth.
        /// </summary>
        public float BaseMagicGrowth { get; }

        /// <summary>
        /// Gets the base skill growth.
        /// </summary>
        public float BaseSkillGrowth { get; }

        /// <summary>
        /// Gets the base speed growth.
        /// </summary>
        public float BaseSpeedGrowth { get; }

        /// <summary>
        /// Gets the base luck growth.
        /// </summary>
        public float BaseLuckGrowth { get; }

        /// <summary>
        /// Gets the base defence growth.
        /// </summary>
        public float BaseDefenceGrowth { get; }

        /// <summary>
        /// Gets the base resistance growth.
        /// </summary>
        public float BaseResistanceGrowth { get; }

        /// <summary>
        /// Gets a value indicating whether it is a base class.
        /// </summary>
        public bool IsBaseClass { get; }

        /// <summary>
        /// Gets a value indicating whether it is a special class.
        /// </summary>
        public bool IsSpecialClass { get; }
    }
}
