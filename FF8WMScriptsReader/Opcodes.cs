using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8WMScriptsReader
{
    class Opcodes
    {
        public Dictionary<string, string> knownOpcodes = new Dictionary<string, string>()
        {
            {"01", "Start"},
            {"02", "StoryGreaterThan"},
            {"03", "StoryLessThan"},
            {"04", "Default"},
            {"05", "Return"},
            {"06", "SetRegion"},
            {"07", "Unknown7"},
            {"08", "MapJump"},
            {"09", "PlayerModel"},
            {"0A", "UnknownA"},
            {"0B", "UnknownB"},
            {"0C", "UnknownC"},
            {"0D", "UnknownD"},
            {"0E", "UnknownE"},
            {"0F", "UnknownF"},
            {"10", "Unknown10"},
            {"11", "Unknown11"},
            {"12", "Unknown12"},
            {"13", "Unknown13"},
            {"14", "Unknown14"},
            {"15", "Unknown15"},
            {"16", "End"},
            {"17", "Unknown17"},
            {"18", "Unknown18"},
            {"19", "Unknown19"},
            {"1A", "Unknown1A"},
            {"1B", "Unknown1B"},
            {"1C", "Unknown1C"},
            {"1D", "Unknown1D"},
            {"1E", "Unknown1E"},
            {"1F", "DrawTextBox"},
            {"20", "Unknown20"},
            {"21", "Unknown21"},
            {"22", "Unknown22"},
            {"23", "Unknown23"},
            {"24", "Unknown24"},
            {"25", "Unknown25"},
            {"26", "Type"},
            {"27", "Unknown27"},
            {"28", "Unknown28"},
            {"29", "Unknown29"},
            {"2A", "Unknown2A"},
            {"2B", "Encounter"},
            {"2C", "Unknown2C"},
            {"2D", "Unknown2D"},
            {"2E", "Unknown2E"},
            {"2F", "Unknown2F"},
            {"30", "Unknown30"},
            {"31", "Unknown31"},
            {"32", "Unknown32"},
            {"33", "Unknown33"},
            {"34", "Unknown34"},
            {"35", "Unknown35"},
            {"36", "Unknown36"},
            {"37", "Unknown37"},
            {"38", "Unknown38"},
        };
    }
}
