#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stats.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Assets.Scripts.Models.Characters.Stats
{
    using System.Collections.Generic;

    using Assets.Scripts.Models.Items.Ranks;
    using Assets.Scripts.Models.Items.Weapons;

    /// <summary>
    /// The character stats.
    /// </summary>
    public class Stats
    {
        /// <summary>
        /// The evasion bonus.
        /// </summary>
        private int evasionBonus;

        /// <summary>
        /// The crit evasion bonus.
        /// </summary>
        private int critEvasionBonus;

        /// <summary>
        /// The bonus to attack damage.
        /// </summary>
        private int bonusAttackDamage;

        /// <summary>
        /// The crit bonus.
        /// </summary>
        private int critBonus;

        /// <summary>
        /// The current weapon.
        /// </summary>
        private Weapon currentWeapon;

        /// <summary>
        /// The hit bonus.
        /// </summary>
        private int hitBonus;

        /// <summary>
        /// Initialises a new instance of the <see cref="Stats"/> class.
        /// </summary>
        /// <param name="strength">The strength.</param>
        /// <param name="speed">The speed.</param>
        /// <param name="skill">The skill.</param>
        /// <param name="resistance">The resistance.</param>
        /// <param name="movement">The movement range.</param>
        /// <param name="magic">The magic.</param>
        /// <param name="luck">The luck.</param>
        /// <param name="level">The level.</param>
        /// <param name="health">The health.</param>
        /// <param name="defence">The defence.</param>
        /// <param name="weaponRanks">The list of achieved weapon ranks.</param>
        public Stats(
            Strength strength,
            Speed speed,
            Skill skill,
            Resistance resistance,
            Movement movement,
            Magic magic,
            Luck luck,
            Level level,
            Health health,
            Defence defence,
            List<Rank> weaponRanks)
        {
            this.Strength = strength;
            this.Speed = speed;
            this.Skill = skill;
            this.Resistance = resistance;
            this.Movement = movement;
            this.Magic = magic;
            this.Luck = luck;
            this.Level = level;
            this.Health = health;
            this.Defence = defence;
            this.WeaponRanks = weaponRanks;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="Stats"/> class.
        /// </summary>
        /// <param name="currLv">The current level.</param>
        /// <param name="maxLv">The maximum level.</param>
        /// <param name="currHp">The current health.</param>
        /// <param name="maxHp">The maximum health.</param>
        /// <param name="currStr">The current strength.</param>
        /// <param name="maxStr">The maximum strength.</param>
        /// <param name="currMag">The current magic.</param>
        /// <param name="maxMag">The maximum magic.</param>
        /// <param name="currSkl">The current skill.</param>
        /// <param name="maxSkl">The maximum skill.</param>
        /// <param name="currSpd">The current speed.</param>
        /// <param name="maxSpd">The maximum speed.</param>
        /// <param name="currLck">The current luck.</param>
        /// <param name="maxLck">The maximum luck.</param>
        /// <param name="currDef">The current defence.</param>
        /// <param name="maxDef">The maximum defence.</param>
        /// <param name="currRes">The current resistance.</param>
        /// <param name="maxRes">The maximum resistance.</param>
        /// <param name="currMov">The current movement range.</param>
        /// <param name="weaponRanks">The list of achieved weapon ranks.</param>
        /// <param name="bonusHp">The bonus health.</param>
        /// <param name="bonusStr">The bonus strength.</param>
        /// <param name="bonusMag">The bonus magic.</param>
        /// <param name="bonusSkl">The bonus skill.</param>
        /// <param name="bonusSpd">The bonus speed.</param>
        /// <param name="bonusLck">The bonus luck.</param>
        /// <param name="bonusDef">The bonus defence.</param>
        /// <param name="bonusRes">The bonus resistance.</param>
        /// <param name="bonusMov">The bonus movement range.</param>
        public Stats(
            int currLv,
            int maxLv,
            int currHp,
            int maxHp,
            int currStr,
            int maxStr,
            int currMag,
            int maxMag,
            int currSkl,
            int maxSkl,
            int currSpd,
            int maxSpd,
            int currLck,
            int maxLck,
            int currDef,
            int maxDef,
            int currRes,
            int maxRes,
            int currMov,
            List<Rank> weaponRanks,
            int bonusHp = 0,
            int bonusStr = 0,
            int bonusMag = 0,
            int bonusSkl = 0,
            int bonusSpd = 0,
            int bonusLck = 0,
            int bonusDef = 0,
            int bonusRes = 0,
            int bonusMov = 0)
            : this(
                new Strength(bonusStr, currStr, maxStr),
                new Speed(bonusSpd, currSpd, maxSpd),
                new Skill(bonusSkl, currSkl, maxSkl),
                new Resistance(bonusRes, currRes, maxRes),
                new Movement(currMov, bonusMov),
                new Magic(bonusMag, currMag, maxMag),
                new Luck(bonusLck, currLck, maxLck),
                new Level(currLv, maxLv),
                new Health(bonusHp, currHp, maxHp),
                new Defence(bonusDef, currDef, maxDef),
                weaponRanks)
        {
        }

        /// <summary>
        /// Gets the defence.
        /// </summary>
        public Defence Defence { get; }

        /// <summary>
        /// Gets the health.
        /// </summary>
        public Health Health { get; }

        /// <summary>
        /// Gets the level.
        /// </summary>
        public Level Level { get; }

        /// <summary>
        /// Gets the luck.
        /// </summary>
        public Luck Luck { get; }

        /// <summary>
        /// Gets the magic.
        /// </summary>
        public Magic Magic { get; }

        /// <summary>
        /// Gets the movement.
        /// </summary>
        public Movement Movement { get; }

        /// <summary>
        /// Gets the resistance.
        /// </summary>
        public Resistance Resistance { get; }

        /// <summary>
        /// Gets the skill.
        /// </summary>
        public Skill Skill { get; }

        /// <summary>
        /// Gets the speed.
        /// </summary>
        public Speed Speed { get; }

        /// <summary>
        /// Gets the strength.
        /// </summary>
        public Strength Strength { get; }

        /// <summary>
        /// Gets or sets the evasion modifier.
        /// </summary>
        public int Evade
        {
            get
            {
                return (this.Speed * 2) + this.Luck + this.evasionBonus + this.currentWeapon?.Stats.AvoidChance ?? 0;
            }

            set
            {
                this.evasionBonus = value - this.Evade;
            }
        }

        /// <summary>
        /// Gets or sets the crit evasion modifier.
        /// </summary>
        public int CritEvade
        {
            get
            {
                return this.Luck + this.critEvasionBonus;
            }

            set
            {
                this.critEvasionBonus = value - this.CritEvade;
            }
        }

        /// <summary>
        /// Gets or sets the attack damage.
        /// </summary>
        public int AttackDamage
        {
            get
            {
                return this.bonusAttackDamage + this.currentWeapon?.Stats.Might ?? 0 + (this.currentWeapon?.IsMagical ?? false ? (int)this.Magic : (int)this.Strength);
            }

            set
            {
                this.bonusAttackDamage = value - this.AttackDamage;
            }
        }

        /// <summary>
        /// Gets or sets the crit chance.
        /// </summary>
        public int Crit
        {
            get
            {
                return (this.Skill / 2) + this.critBonus + this.currentWeapon?.Stats.CritChance ?? int.MinValue;
            }

            set
            {
                this.critBonus = value - this.Crit;
            }
        }

        /// <summary>
        /// Gets or sets the hit chance.
        /// </summary>
        public int Hit
        {
            get
            {
                return this.Skill + this.hitBonus + this.currentWeapon?.Stats.HitChance ?? 0;
            }

            set
            {
                this.hitBonus = value - this.Hit;
            }
        }

        /// <summary>
        /// Gets the weapon ranks.
        /// </summary>
        public List<Rank> WeaponRanks { get; }

        /// <summary>
        /// Registers that weapon as being equipped.
        /// </summary>
        /// <param name="weapon">
        /// The weapon to equip.
        /// </param>
        public void RegisterWeapon(Weapon weapon)
        {
            this.currentWeapon = weapon;
        }
    }
}