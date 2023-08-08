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
            {"01", "Start"}, // The beginning of a script
            {"02", "StoryGreaterThan"}, // Check for story progress
            {"03", "StoryLessThan"}, // Check for story progress
            {"04", "CheckEnd"}, // Check end?
            {"05", "Return"}, // Exit from the script
            {"06", "TriggerID"},
            {"07", "Unknown7"},
            {"08", "LoadField"}, // Load field map from a WM field list
            {"09", "PlayerModel"}, // Checks if you're on car/ragnarok/chocobo/garden
            {"0A", "SwitchBlock"}, // Marks several conditional blocks ahead
            {"0B", "BlockCheckEnd"}, // Exits from the current Case block
            {"0C", "Case"}, // Marks a block for a Switch case
            {"0D", "UnknownD"},
            {"0E", "UnknownE"},
            {"0F", "UnknownF"},
            {"10", "Unknown10"},
            {"11", "InArea"}, // Weird one. Creates some spot inside the trigger. The bigger the number, the smaller the area
            {"12", "Unknown12"},
            {"13", "Unknown13"},
            {"14", "Unknown14"},
            {"15", "LoadField2"}, // The difference with LoadField is unknown yet.
            {"16", "End"}, // The ending of a script
            {"17", "Unknown17"},
            {"18", "Unknown18"},
            {"19", "Unknown19"},
            {"1A", "Unknown1A"},
            {"1B", "Unknown1B"},
            {"1C", "Unknown1C"},
            {"1D", "Unknown1D"},
            {"1E", "Unknown1E"},
            {"1F", "DrawTextBox"}, // Draws the text box. 1 Argument is for ID, 2 Argument is kinda like position
            {"20", "ReadInput"}, // Reads an input. 64(0x40) = cross, 128(0x80) = square, 255(0xFF) = triangle, 32(0x20) = circle. // 1 L2, 2 R2, 4 L1
            {"21", "Unknown21"},
            {"22", "Unknown22"},
            {"23", "Unknown23"},
            {"24", "Unknown24"},
            {"25", "Unknown25"},
            {"26", "Type"}, // Some parameter for a text box. Also teleports to trains, ragnarok.
            {"27", "Unknown27"},
            {"28", "LoadField3"}, // 
            {"29", "Unknown29"},
            {"2A", "Unknown2A"},
            {"2B", "Encounter"}, // Starts the encounter
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
