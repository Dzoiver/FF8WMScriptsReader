using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8WMScriptsReader
{
    class BytesTransformer
    {
        Opcodes opcodes = new Opcodes();
        Parameters paramsConverter = new Parameters();
        List<string> scriptsList = new List<string>();
        private bool isReversed = false;

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
        }

        private string FindScripts(string rawString = "")
        {
            if (isReversed)
                return "";

            string scriptsRange = FindScriptsRange(rawString);
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
            int firstScriptIndex = rawString.IndexOf("01FF0000");
            int lastScriptIndex = rawString.LastIndexOf("16FF0000");
            int lengthOfScripts = lastScriptIndex - firstScriptIndex;
            return rawString.Substring(firstScriptIndex, lengthOfScripts);
        }

        private string SplitToRows(string script = "")
        {
            string currentOpcode = "";
            string noParamsOpcode = "";
            string splittedOpcodes = "";
            int opCodesNumber = script.Length / 8;
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
                splittedOpcodes += DecipherOpcode(noParamsOpcode) + 
                    "(" + paramsConverter.TryGetStringParams(currentOpcode) + ")" + Environment.NewLine;
            }

            if (isReversed)
                splittedOpcodes += "0000FF16 End()" + Environment.NewLine + Environment.NewLine;
            else
                splittedOpcodes += "16FF0000 End()" + Environment.NewLine + Environment.NewLine;
            scriptsList.Add(splittedOpcodes);
            return splittedOpcodes;
        }

        private string DecipherOpcode(string noParamsOpcode)
        {
            string decipheredOpcode = " Unknown";
            foreach (var opcode in opcodes.knownOpcodes)
            {
                if (noParamsOpcode == opcode.Key)
                {
                    decipheredOpcode = " " + opcode.Value;
                    break;
                }
            }
            return decipheredOpcode;
        }
    }
}
