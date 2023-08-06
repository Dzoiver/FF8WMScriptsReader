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
                {"01", "Start"},
                {"02", "StoryGreaterThan(storyProgress)"},
                {"03", "StoryLessThan(storyProgress)"},
                {"04", "IsTouching"},
                {"05", "Return"},
                {"06", "SetRegion(regionID)"},
                {"08", "MapJump(mapID)"},
                {"09", "PlayerModel(modelID)"},
                {"1F", "DrawTextBox(textBoxID, position?)"},
                {"26", "Type(value)"},
                {"2B", "Encounter(encID)"},
                {"16", "End"},
            };
        }
        public string Transform(string rawBytes, bool isReversed = false)
        {
            rawBytes = rawBytes.Replace(" ", ""); // Remove spaces if there is ones
            string[] scripts;
            string result = "";
            if (isReversed)
                scripts = rawBytes.Split("0000FF16");
            else
                scripts = rawBytes.Split("16FF0000");

            
            for (int j = 0; j < scripts.Length - 1; j++)
            {
                result += "   Script #" + j + Environment.NewLine;
                int opCodesNumber = scripts[j].Length / 8; // Split opcodes to each row
                string currentOpcode = "";
                string noParamsOpcode = "";
                //result += "Script #" + i + Environment.NewLine;
                for (int i = 0; i < opCodesNumber; i++)
                {
                    currentOpcode = scripts[j].Substring(i * 8, 8);
                    result += currentOpcode;

                    if (isReversed)
                    {
                        noParamsOpcode = currentOpcode.Substring(6, 2);
                    }
                    else
                    {
                        noParamsOpcode = currentOpcode.Substring(0, 2);
                    }
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
                if (isReversed)
                    result += "0000FF16 End" + Environment.NewLine + Environment.NewLine;
                else
                    result += "16FF0000 End" + Environment.NewLine + Environment.NewLine;
            }
            return result;
        }
    }
}
