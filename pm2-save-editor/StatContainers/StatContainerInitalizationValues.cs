﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pm2_save_editor
{

    enum StatTypes { Int, UInt, String };

    /// <summary>
    /// Struct used to hold default initalization values for stat containers. 
    /// </summary>
    struct InitalizationStruct
    {
        public string name;
        public Stat statID;
        public StatTypes type;

        public int size;
        public int offset;

        public IntType intType;

        public long Max;
        public long Min;

        // String Type
        //public string stringValue;

        public int minLength;
        public int maxLength;
    }

    enum Stat { DaughtersName, FightingRep, Height };

    static class Limits
    {
        public const int RepMax = 2000;
        public const int RepMin = 0;
    }
    

    static class StatInitalizationValues
    {

        internal static Dictionary<Stat, InitalizationStruct> statInitalizationMap = new Dictionary<Stat, InitalizationStruct>
        {
            { Stat.DaughtersName, new InitalizationStruct {
                name = "Daughter's Name",
                statID = Stat.DaughtersName,
                type = StatTypes.String,
                size = 48,
                offset = 0x74,
                minLength = 1,
                maxLength = 8 }
            },

            { Stat.FightingRep, new InitalizationStruct {
                name = "Fighting Reputation",
                statID = Stat.FightingRep,
                intType = IntType.UInt16,
                offset = 0x4E,
                Max = Limits.RepMax,
                Min = Limits.RepMin }
            },

            { Stat.Height, new InitalizationStruct {
                name = "Height",
                statID = Stat.Height,
                intType = IntType.UInt16,
                offset = 0xF0,
                Max = 50000,
                Min = 0 }
            },

        };

    }
}