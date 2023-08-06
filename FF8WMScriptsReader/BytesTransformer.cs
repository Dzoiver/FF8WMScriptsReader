using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8WMScriptsReader
{
    class BytesTransformer
    {
        List<string> scriptsList = new List<string>();
        private bool isReversed = false;
        Dictionary<string, string> knownOpcodes = new Dictionary<string, string>()
        {
            {"01", "Start"},
            {"02", "StoryGreaterThan(storyProgress)"},
            {"03", "StoryLessThan(storyProgress)"},
            {"04", "IsActivated"},
            {"05", "Return"},
            {"06", "SetRegion(regionID)"},
            {"08", "MapJump(mapID)"},
            {"09", "PlayerModel(modelID)"},
            {"1F", "DrawTextBox(textBoxID, position?)"},
            {"26", "Type(value)"},
            {"2B", "Encounter(encID)"},
            {"16", "End"},
        };

        public List<string> TransformString(string rawBytes, bool isReverseChecked = false)
        {
            isReversed = isReverseChecked;
            rawBytes = rawBytes.Replace(" ", ""); // Remove spaces if there is ones
            string scripts = FindScripts(rawBytes);
            string[] scriptsArray;
            string result = "";

            if (isReversed)
                scriptsArray = scripts.Split("0000FF16");
            else
                scriptsArray = scripts.Split("16FF0000");
            
            for (int j = 0; j < scriptsArray.Length; j++) // Go through each script
            {
                result += SplitToRows(scriptsArray[j]);
            }

            return scriptsList;
            // return result;
        }

        private string FindScripts(string rawString = "")
        {
            if (isReversed)
                return "";

            string scriptsRange = "";
            scriptsRange = FindScriptsRange(rawString);

            int opCodesNumber = scriptsRange.Length / 8;

            string onlyScripts = "";
            for (int i = 0; i < opCodesNumber; i++)
            {
                string opCode = scriptsRange.Substring(i * 8, 4);

                
            }

            return scriptsRange;
        }

        private string FindScriptsRange(string rawString = "")
        {
            int firstScriptIndex = 0;
            int lastScriptIndex = 0;
            firstScriptIndex = rawString.IndexOf("01FF0000");
            lastScriptIndex = rawString.LastIndexOf("16FF0000");
            int lengthOfScripts = lastScriptIndex - firstScriptIndex;
            string scriptsRange = "";
            scriptsRange = rawString.Substring(firstScriptIndex, lengthOfScripts);
            return scriptsRange;
        }


        private string SplitToRows(string script = "")
        {
            string currentOpcode = "";
            string noParamsOpcode = "";
            string splittedOpcodes = "";
            int opCodesNumber = script.Length / 8;
            // splittedOpcodes += "   Script #" + scriptsList.Count + " " + NameIfKnown() + Environment.NewLine;
            for (int i = 0; i < opCodesNumber; i++)
            {
                currentOpcode = script.Substring(i * 8, 8);
                splittedOpcodes += currentOpcode;

                if (isReversed) // Look at the last byte
                {
                    noParamsOpcode = currentOpcode.Substring(6, 2);
                }
                else // Look at the first byte
                {
                    noParamsOpcode = currentOpcode.Substring(0, 2);
                }
                splittedOpcodes += DecipherOpcode(noParamsOpcode) + Environment.NewLine;
            }

            if (isReversed)
                splittedOpcodes += "0000FF16 End" + Environment.NewLine + Environment.NewLine;
            else
                splittedOpcodes += "16FF0000 End" + Environment.NewLine + Environment.NewLine;
            scriptsList.Add(splittedOpcodes);
            return splittedOpcodes;
        }

        private string DecipherOpcode(string noParamsOpcode)
        {
            string decipheredOpcode = "";
            foreach (var opcode in knownOpcodes)
            {
                if (noParamsOpcode == opcode.Key)
                {
                    decipheredOpcode += " " + opcode.Value;
                    break;
                }
            }
            return decipheredOpcode;
        }
    }
}
