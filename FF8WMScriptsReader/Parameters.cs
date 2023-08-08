using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8WMScriptsReader
{
    public enum Reading
    {
        IndependentBytes,
        TwoByte,
        Text
    }
    class ParameterType
    {
        public Reading reading = Reading.TwoByte;
        public Dictionary<string, string> firstByteTable;
        public Dictionary<string, string> secondByteTable;

        public string SearchFirstByte(string firstByte)
        {
            if (firstByteTable == null)
            {
                if (firstByte == "00")
                    return "";
                return Convert.ToInt32(firstByte, 16).ToString();
            }
                

            foreach (KeyValuePair<string, string> t in firstByteTable)
            {
                if (firstByte == t.Key)
                {
                    return t.Value;
                }
            }

            if (firstByte == "00")
                return "";
            return Convert.ToInt32(firstByte, 16).ToString();
        }

        public string SearchSecondByte(string secondByte)
        {
            if (secondByteTable == null)
            {
                if (secondByte == "00")
                    return "";
                return Convert.ToInt32(secondByte, 16).ToString();
            }
            foreach (KeyValuePair<string, string> t in secondByteTable)
            {
                if (secondByte == t.Key)
                {
                    return t.Value;
                }
            }
            if (secondByte == "00")
                return "";
            return Convert.ToInt32(secondByte, 16).ToString();
        }
    }
    class Parameters
    {
        Dictionary<string, ParameterType> paramTypes;
        public Parameters()
        {
            ParameterType map = new ParameterType();
            map.reading = Reading.IndependentBytes;
            map.secondByteTable = new Dictionary<string, string>()
            {
                 {"00", "\"Balamb Garden\""},
                 {"01", "\"Balamb\""},
            };

            ParameterType button = new ParameterType();
            button.firstByteTable = new Dictionary<string, string>()
            {
                 {"40", "Cross"},
                 {"80", "Square"},
            };

            ParameterType typeParams = new ParameterType();
            typeParams.reading = Reading.IndependentBytes;

            ParameterType playerModel = new ParameterType();
            playerModel.secondByteTable = new Dictionary<string, string>()
            {
                 {"21", "\"Desert car\""},
                 {"30", "\"Garden\""},
                 {"31", "\"Chocobo\""},
                 {"32", "\"Ragnarok\""},
                 {"80", "\"Character\""},
                 {"84", "\"Rent car\""},
            };

            paramTypes = new Dictionary<string, ParameterType>()
            {
                 {"08", map},
                 {"20", button},
                 {"09", playerModel},
            };
        }
        private string firstByteParams = "";
        private string secondByteParams = "";
        private string opcodeType = "";

        public string TryGetStringParams(string opcode)
        {
            firstByteParams = opcode.Substring(6, 2);
            secondByteParams = opcode.Substring(4, 2);

            opcodeType = opcode.Substring(0, 2);

            foreach (KeyValuePair<string, ParameterType> t in paramTypes)
            {
                if (opcodeType == t.Key)
                {
                    return t.Value.SearchFirstByte(firstByteParams) + t.Value.SearchSecondByte(secondByteParams);
                }
            }

            opcode = Convert.ToInt32(firstByteParams + secondByteParams, 16).ToString();

            if (opcode == "0")
                return "";
            else
                return opcode;
        }
    }
}
