﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm2_save_editor
{
    public static partial class StatInitalizationValues
    {
        internal static Dictionary<Stat, InitalizationStruct> englishRefineStatInitalizationMap = new Dictionary<Stat, InitalizationStruct>
        {
            { Stat.Year, new InitalizationStruct {
                name = "Year",
                statID = Stat.Year,
                type = StatTypes.Int16,
                offset = 0x00,
                Max = int.MaxValue, // if someone wants to make their princess 1000 years old who am I to tell them no?
                Min = int.MinValue }
            },
            { Stat.Month, new InitalizationStruct {
                name = "Month",
                statID = Stat.Month,
                type = StatTypes.Int16,
                offset = 0x02,
                Max = int.MaxValue, // consider these humorous temporary values - any exposure to the user will most likely be in the form of a drop box anyway
                Min = int.MinValue }
            },
            { Stat.Day, new InitalizationStruct {
                name = "Day",
                statID = Stat.Day, // the day of the week - will be overwritten by the date, so it's not very useful practically
                type = StatTypes.Int16,
                offset = 0x04,
                Max = int.MaxValue,
                Min = int.MinValue }
            },
            { Stat.Date, new InitalizationStruct {
                name = "Date", // the 30 in october 30
                statID = Stat.Date,
                type = StatTypes.Int16,
                offset = 0x06, // may also be duplicated in 0x0A, so this is not considered stable. it should be considered read only at the moment, though this is not yet enforce programmatically
                Max = int.MaxValue,
                Min = int.MinValue }
            },
            { Stat.Gold, new InitalizationStruct {
                name = "Gold",
                statID = Stat.Gold,
                type = StatTypes.Int32,
                offset = 0x70,
                Max = Limits.GoldMax,
                Min = Limits.GoldMin, }
            },
            { Stat.DaughtersName, new InitalizationStruct {
                name = "Daughter's Name",
                statID = Stat.DaughtersName,
                type = StatTypes.String,
                size = 48,
                offset = 0x74,
                minLength = Limits.NameMin,
                maxLength = Limits.NameMax }
            },

            { Stat.FathersName, new InitalizationStruct {
                name = "Fathers's Name",
                statID = Stat.DaughtersName,
                type = StatTypes.String,
                size = 48,
                offset = 0xA4,
                minLength = Limits.NameMin,
                maxLength = Limits.NameMax }
            },

            { Stat.BloodType, new InitalizationStruct {
                name = "Blood Type",
                statID = Stat.BloodType,
                type = StatTypes.Int16,
                offset = 0xD4,
                Max = Limits.BloodTypeMax,
                Min = Limits.BloodTypeMin }
            },

            { Stat.Stamina, new InitalizationStruct {
                name = "Stamina",
                statID = Stat.Stamina,
                type = StatTypes.UInt16,
                offset = 0x3A,
                Max = Limits.CombatSkillMax,
                Min = Limits.CombatSkillMin }
            },

            { Stat.Strength, new InitalizationStruct {
                name = "Strength",
                statID = Stat.Strength,
                type = StatTypes.UInt16,
                offset = 0x3C,
                Max = Limits.CombatSkillMax,
                Min = Limits.CombatSkillMin }
            },

            { Stat.Intelligence, new InitalizationStruct {
                name = "Intelligence",
                statID = Stat.Intelligence,
                type = StatTypes.UInt16,
                offset = 0x3E,
                Max = Limits.CombatSkillMax,
                Min = Limits.CombatSkillMin }
            },

            { Stat.Elegance, new InitalizationStruct {
                name = "Elegance",
                statID = Stat.Elegance,
                type = StatTypes.UInt16,
                offset = 0x40,
                Max = Limits.CombatSkillMax,
                Min = Limits.CombatSkillMin }
            },

            { Stat.Glamour, new InitalizationStruct {
                name = "Glamour",
                statID = Stat.Glamour,
                type = StatTypes.UInt16,
                offset = 0x42,
                Max = Limits.CombatSkillMax,
                Min = Limits.CombatSkillMin }
            },

            { Stat.Morality, new InitalizationStruct {
                name = "Morality",
                statID = Stat.Morality,
                type = StatTypes.UInt16,
                offset = 0x44,
                Max = Limits.CombatSkillMax,
                Min = Limits.CombatSkillMin }
            },

            { Stat.Faith, new InitalizationStruct {
                name = "Faith",
                statID = Stat.Faith,
                type = StatTypes.UInt16,
                offset = 0x46,
                Max = Limits.CombatSkillMax,
                Min = Limits.CombatSkillMin }
            },

            { Stat.Sin, new InitalizationStruct {
                name = "Sin",
                statID = Stat.Sin,
                type = StatTypes.UInt16,
                offset = 0x48,
                Max = Limits.CombatSkillMax,
                Min = Limits.CombatSkillMin }
            },

            { Stat.Sensetivity, new InitalizationStruct {
                name = "Sensetivity",
                statID = Stat.Sensetivity,
                type = StatTypes.UInt16,
                offset = 0x4A,
                Max = Limits.CombatSkillMax,
                Min = Limits.CombatSkillMin }
            },

            { Stat.Stress, new InitalizationStruct {
                name = "Stress",
                statID = Stat.Stress,
                type = StatTypes.UInt16,
                offset = 0x4C,
                Max = Limits.CombatSkillMax,
                Min = Limits.CombatSkillMin }
            },

            { Stat.FightingRep, new InitalizationStruct {
                name = "Fighting Reputation",
                statID = Stat.FightingRep,
                type = StatTypes.UInt16,
                offset = 0x4E,
                Max = Limits.RepMax,
                Min = Limits.RepMin }
            },

            { Stat.MagicRep, new InitalizationStruct {
                name = "Magic Reputation",
                statID = Stat.MagicRep,
                type = StatTypes.UInt16,
                offset = 0x50,
                Max = Limits.RepMax,
                Min = Limits.RepMin }
            },

            { Stat.SocialRep, new InitalizationStruct {
                name = "Social Reputation",
                statID = Stat.SocialRep,
                type = StatTypes.UInt16,
                offset = 0x52,
                Max = Limits.RepMax,
                Min = Limits.RepMin }
            },

            { Stat.HousekeepingRep, new InitalizationStruct {
                name = "Housekeeping Reputation",
                statID = Stat.HousekeepingRep,
                type = StatTypes.UInt16,
                offset = 0x54,
                Max = Limits.RepMax,
                Min = Limits.RepMin }
            },

            { Stat.CombatSkill, new InitalizationStruct {
                name = "Combat Skill",
                statID = Stat.CombatSkill,
                type = StatTypes.UInt16,
                offset = 0x56,
                Max = Limits.CombatSkillMax,
                Min = Limits.CombatSkillMin }
            },

            { Stat.Attack, new InitalizationStruct {
                name = "Attack",
                statID = Stat.Attack,
                type = StatTypes.UInt16,
                offset = 0x58,
                Max = Limits.CombatSkillMax,
                Min = Limits.CombatSkillMin }
            },

            { Stat.Defence, new InitalizationStruct {
                name = "Defence",
                statID = Stat.Defence,
                type = StatTypes.UInt16,
                offset = 0x5A,
                Max = Limits.CombatSkillMax,
                Min = Limits.CombatSkillMin }
            },

            { Stat.MagicSkill, new InitalizationStruct {
                name = "Magic Skill",
                statID = Stat.MagicSkill,
                type = StatTypes.UInt16,
                offset = 0x5C,
                Max = Limits.CombatSkillMax,
                Min = Limits.CombatSkillMin }
            },

            { Stat.MagicAttack, new InitalizationStruct {
                name = "Magic Attack",
                statID = Stat.MagicAttack,
                type = StatTypes.UInt16,
                offset = 0x5E,
                Max = Limits.CombatSkillMax,
                Min = Limits.CombatSkillMin }
            },

            { Stat.MagicDefence, new InitalizationStruct {
                name = "Magic Defence",
                statID = Stat.MagicDefence,
                type = StatTypes.UInt16,
                offset = 0x60,
                Max = Limits.CombatSkillMax,
                Min = Limits.CombatSkillMin }
            },

            { Stat.Decorum, new InitalizationStruct {
                name = "Decorum",
                statID = Stat.Decorum,
                type = StatTypes.UInt16,
                offset = 0x62,
                Max = Limits.SocialPersonalStatMax,
                Min = Limits.SocialPersonalStatMin }
            },

            { Stat.ArtSkill, new InitalizationStruct {
                name = "Art Skill",
                statID = Stat.ArtSkill,
                type = StatTypes.UInt16,
                offset = 0x64,
                Max = Limits.SocialPersonalStatMax,
                Min = Limits.SocialPersonalStatMin }
            },

            { Stat.Speech, new InitalizationStruct {
                name = "Speech",
                statID = Stat.Speech,
                type = StatTypes.UInt16,
                offset = 0x66,
                Max = Limits.SocialPersonalStatMax,
                Min = Limits.SocialPersonalStatMin }
            },

            { Stat.Cooking, new InitalizationStruct {
                name = "Cooking",
                statID = Stat.Cooking,
                type = StatTypes.UInt16,
                offset = 0x68,
                Max = Limits.SocialPersonalStatMax,
                Min = Limits.SocialPersonalStatMin }
            },

            { Stat.Cleaning, new InitalizationStruct {
                name = "Cleaning",
                statID = Stat.Cleaning,
                type = StatTypes.UInt16,
                offset = 0x6A,
                Max = Limits.SocialPersonalStatMax,
                Min = Limits.SocialPersonalStatMin }
            },

            { Stat.Personality, new InitalizationStruct {
                name = "Personality",
                statID = Stat.Personality,
                type = StatTypes.UInt16,
                offset = 0x6C,
                Max = Limits.SocialPersonalStatMax,
                Min = Limits.SocialPersonalStatMin }
            },

            { Stat.Height, new InitalizationStruct {
                name = "Height",
                statID = Stat.Height,
                type = StatTypes.GNXFloat,
                offset = 0xF0,
                Max = 20000,
                Min = 0 }
            },
            { Stat.Weight, new InitalizationStruct {
                name = "Weight",
                statID = Stat.Weight,
                type = StatTypes.GNXFloat,
                offset = 0xF2,
                Max = 8000,
                Min = 2500 }
            },
            { Stat.Bust, new InitalizationStruct {
                name = "Bust",
                statID = Stat.Bust,
                type = StatTypes.GNXFloat,
                offset = 0xF4,
                Max = 20000,
                Min = 0 }
            },
            { Stat.Waist, new InitalizationStruct {
                name = "Waist",
                statID = Stat.Waist,
                type = StatTypes.GNXFloat,
                offset = 0xF6,
                Max = 8250,
                Min = 1000 }
            },
            { Stat.Hips, new InitalizationStruct {
                name = "Hips",
                statID = Stat.Hips,
                type = StatTypes.GNXFloat,
                offset = 0xF8,
                Max = 20000,
                Min = 0 }
            },

           { Stat.TotalClasses, new InitalizationStruct {
                name = "Total Classes",
                statID = Stat.TotalClasses,
                type = StatTypes.Sum,
                offset = 0x166E,
                Max = Limits.ClassMax*10, // There are 10 stats that will be summed by this stats SumStatContainer
                Min = 0,
                statsToSum = new List<Stat> { Stat.Science, Stat.Poetry, Stat.Theology, Stat.Strategy, Stat.Fencing, Stat.KungFu, Stat.Magic, Stat.Manners, Stat.Painting, Stat.Dance }, }
            },

            { Stat.Science, new InitalizationStruct {
                name = "Science",
                statID = Stat.Science,
                type = StatTypes.Int16,
                offset = 0x1670,
                Max = Limits.ClassMax,
                Min = Limits.ClassMin, }
            },

            { Stat.Poetry, new InitalizationStruct {
                name = "Poetry",
                statID = Stat.Poetry,
                type = StatTypes.Int16,
                offset = 0x1672,
                Max = Limits.ClassMax,
                Min = Limits.ClassMin, }
            },

            { Stat.Theology, new InitalizationStruct {
                name = "Theology",
                statID = Stat.Theology,
                type = StatTypes.Int16,
                offset = 0x1674,
                Max = Limits.ClassMax,
                Min = Limits.ClassMin, }
            },

            { Stat.Strategy, new InitalizationStruct {
                name = "Strategy",
                statID = Stat.Strategy,
                type = StatTypes.Int16,
                offset = 0x1676,
                Max = Limits.ClassMax,
                Min = Limits.ClassMin, }
            },

            { Stat.Fencing, new InitalizationStruct {
                name = "Fencing",
                statID = Stat.Fencing,
                type = StatTypes.Int16,
                offset = 0x1678,
                Max = Limits.ClassMax,
                Min = Limits.ClassMin, }
            },

            { Stat.KungFu, new InitalizationStruct {
                name = "Kung Fu",
                statID = Stat.KungFu,
                type = StatTypes.Int16,
                offset = 0x167A,
                Max = Limits.ClassMax,
                Min = Limits.ClassMin, }
            },

            { Stat.Magic, new InitalizationStruct {
                name = "Magic",
                statID = Stat.Magic,
                type = StatTypes.Int16,
                offset = 0x167C,
                Max = Limits.ClassMax,
                Min = Limits.ClassMin, }
            },

            { Stat.Manners, new InitalizationStruct {
                name = "Manners",
                statID = Stat.Manners,
                type = StatTypes.Int16,
                offset = 0x167E,
                Max = Limits.ClassMax,
                Min = Limits.ClassMin, }
            },

            { Stat.Painting, new InitalizationStruct {
                name = "Painting",
                statID = Stat.Painting,
                type = StatTypes.Int16,
                offset = 0x1680,
                Max = Limits.ClassMax,
                Min = Limits.ClassMin, }
            },

            { Stat.Dance, new InitalizationStruct {
                name = "Dance",
                statID = Stat.Dance,
                type = StatTypes.Int16,
                offset = 0x1682,
                Max = Limits.ClassMax,
                Min = Limits.ClassMin, }
            },



        };
    }
}
