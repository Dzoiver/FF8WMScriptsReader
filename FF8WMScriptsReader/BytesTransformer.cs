using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8WMScriptsReader
{
    class BytesTransformer
    {
        Dictionary<string, string> knownOpcodes;
        public BytesTransformer()
        {
            knownOpcodes = new Dictionary<string, string>()
            {
                {"01FF", "Start"},
                {"02FF", "StoryGreaterThan(storyProgress)"},
                {"03FF", "StoryLessThan(storyProgress)"},
                {"04FF", "IsTouching"},
                {"05FF", "Return"},
                {"06FF", "SetRegion(regionID)"},
                {"08FF", "MapJump(mapID)"},
                {"09FF", "PlayerModel(modelID)"},
                {"1FFF", "DrawTextBox(textBoxID, position?)"},
                {"26FF", "Type(value)"},
                {"2BFF", "Encounter(encID)"},
                {"16FF", "End"},
            };
        }
        public string Transform(string rawBytes)
        {
            rawBytes = rawBytes.Replace(" ", ""); // Remove spaces if there is ones
            // Split opcodes to each row
            int scriptsNumber = rawBytes.Length / 8;
            Console.WriteLine(scriptsNumber);
            string result = "";
            string currentOpcode = "";
            string noParamsOpcode = "";
            for (int i = 0; i < scriptsNumber; i++)
            {
                currentOpcode = rawBytes.Substring(i * 8, 8);
                result += currentOpcode;
                
                noParamsOpcode = currentOpcode.Substring(0, 4);
                foreach (var opcode in knownOpcodes)
                {
                    if (noParamsOpcode == opcode.Key)
                    {
                        result += " " + opcode.Value;
                        break;
                    }
                }
                
                result += Environment.NewLine;
            }
            return result;
        }


    }
}
