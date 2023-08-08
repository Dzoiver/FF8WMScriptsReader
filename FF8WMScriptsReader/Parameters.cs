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
                if (firstByte == "00" && reading != Reading.IndependentBytes)
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

            if (firstByte == "00" && reading != Reading.IndependentBytes)
                return "";
            return Convert.ToInt32(firstByte, 16).ToString();
        }

        public string SearchSecondByte(string secondByte)
        {
            if (secondByteTable == null)
            {
                if (secondByte == "00")
                    return "";
                return ", " + Convert.ToInt32(secondByte, 16).ToString();
            }
            foreach (KeyValuePair<string, string> t in secondByteTable)
            {
                if (secondByte == t.Key)
                {
                    string result = "";
                    if (reading == Reading.IndependentBytes)
                    {
                        return result += ", " + t.Value;
                    }
                    return t.Value;
                }
            }
            if (secondByte == "00")
                return "";
            return ", " + Convert.ToInt32(secondByte, 16).ToString();
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
                 {"02", "\"Fire Cavern\""},
                 {"03", "\"Dollet\""},
                 {"04", "\"Timber\""},
                 {"05", "\"Timber Forest\""},
                 {"06", "\"Galbadia Garden\""},
                 {"07", "\"Galbadia Train Station\""},
                 {"08", "\"Deling\""},
                 {"09", "\"Tomb of the Unknown King\""},
                 {"0A", "\"Prison\""},
                 {"0B", "\"Missile base\""},
                 {"0C", "\"FH Garden\""},
                 {"0D", "\"FH Ragnarok\""},
                 {"0E", "\"Winhill Back\""},
                 {"0F", "\"Winhill Front\""},
                 {"10", "\"Centra Ruins\""},
                 {"11", "\"Seed Ship\""},
                 {"12", "\"Edea's House\""},
                 {"13", "\"Trabia\""},
                 {"14", "\"Shumi\""},
                 {"15", "\"Deep sea Research center\""},
                 {"16", "\"Trabia Canyon\""},
                 {"17", "\"Trabia Canyon 2\""},
                 {"18", "\"Esthar Train Station\""},
                 {"19", "\"Salt Lake\""},
                 {"1A", "\"Esthar Car\""},
                 {"1B", "\"Esthar Airstation\""},
                 {"1C", "\"Lunatic Pandora Laboratory\""},
                 {"1D", "\"Lunar Gate\""},
                 {"1E", "\"Esthar Sorceress Memorial\""},
                 {"1F", "\"Tear's Point\""},
                 {"20", "\"SpaceShip Landing Zone\""},
                 {"21", "\"Chocobo Shumi\""},
                 {"22", "\"Chocobo Trabia\""},
                 {"23", "\"Chocobo Trabia#2\""},
                 {"24", "\"Chocobo Esthar\""},
                 {"25", "\"Chocobo Centra\""},
                 {"26", "\"Chocobo Near Edea's House\""},
                 {"27", "\"Chocobo Centra#2\""},
                 {"28", "\"Ultimecia Gate Galbadia\""},
                 {"29", "\"Ultimecia Gate Centra\""},
                 {"2A", "\"Ultimecia Gate Esthar\""},
                 {"2B", "\"Ultimecia Gate Desert\""},
                 {"2C", "\"Ragnarok\""},
                 {"2D", "\"Crash Site\""},
                 {"2E", "\"Esthar Train Station After Lunar Tear\""},
                 {"2F", "\"Esthar Lunar Gate Lunar Tear\""},
                 {"30", "\"Tear's point\""},
                 {"31", "\"Tear's point Lunar Tear\""},
                 {"32", "\"Balamb Train Station\""},
                 {"33", "\"Desert Train Station\""},
                 {"34", "\"Timber Pub\""},
                 {"35", "\"Timber Station\""},
                 {"36", "\"Timber Station City Square\""},
                 {"37", "\"Deling Train Station\""},
                 {"38", "\"Galbadia Train Station From Deling\""},
                 {"39", "\"Lunatic Pandora Laboratory After Lunar Tear\""},
                 {"3A", "\"Timber From Balamb\""},
                 {"3B", "\"Timber train (To East Academy Station)\""},
                 {"3C", "\"Balamb Harbor\""},
                 {"3D", "\"Dollet Vessel\""},
                 {"3E", "\"Balamb Garden\""},
                 {"3F", "\"Balamb Weird spot\""},
                 {"40", "\"Gardens Collide\""},
                 {"41", "\"B-Garden Headmaster's Office\""},
                 {"42", "\"Busting Lunatic Pandora\""},
                 {"43", "\"Lunatic Pandora Ragnarok\""},
                 {"44", "\"Esthar Airstation Lunar Tear\""},
                 {"45", "\"Sorceress Memorial Lunar Tear\""},
                 {"46", "\"Lunatic Pandora Out of Ragnarok\""},
                 {"47", "\"Debug map\""},
            };

            ParameterType button = new ParameterType();
            button.secondByteTable = new Dictionary<string, string>()
            {
                {"08", "Triangle"},
                {"20", "Circle"},
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

            ParameterType textBox = new ParameterType();
            textBox.reading = Reading.IndependentBytes;
            textBox.firstByteTable = new Dictionary<string, string>()
            {
                 {"00", "\"East Academy Station\""},
                 {"01", "\"Dollet Station\""},
                 {"02", "\"Desert Prison Station\""},
                 {"03", "\"Esthar Airstation\""},
                 {"04", "\"East Academy Station Get off? Yes No\""},
                 {"05", "\"Dollet Station Get off? Yes No\""},
                 {"06", "\"Desert Prison Station Get off? Yes No\""},
                 {"07", "\"Bound for Timber. Pay 3,000 Gil to ride Don't ride\""},
                 {"08", "\"Bound for Dollet. Pay 3,000 Gil to ride Don't ride\""},
                 {"09", "\"Bound for Deling. Pay 3,000 Gil to ride Don't ride\""},
                 {"0A", "\"You don't have enough money\""},
                 {"0B", "\"Selphie \"C'mon! To the [Missile base]!\"\""},
                 {"0C", "\"Galbadian Soldier \"...Give it up.\"\""},
                 {"0D", "\"Galbadian Soldier \"...I'm busy.\"\""},
                 {"0E", "\"Galbadian Soldier \"There's no way you're getting through!\"\""},
                 {"0F", "\"Galbadian Soldier \"This is our duty...\"\""},
                 {"10", "\"Galbadian Soldier \"Just like always...\"\""},
                 {"11", "\"Galbadian Soldier \"How 'bout a date?\"\""},
                 {"12", "\"Found a draw point! But no one can draw...\""},
                 {"13", "\"Found a draw point! Nothing there...\""},
                 {"14", "\"Found a draw point!\""},
                 {"15", "\"found\""},
                 {"16", "\"Can't carry anymore.\""},
                 {"17", "\"You do not have Draw.\""},
                 {"18", "\"Who will draw?\""},
                 {"19", "\"Don't draw\""},
                 {"1A", "\"\""},
                 {"1B", "\"stocked\""},
                 {"1C", "\"\""},
                 {"1D", "\"0\""},
                 {"1E", "\"Squall\""},
                 {"1F", "\"Zell\""},
                 {"20", "\"Irvine\""},
                 {"21", "\"Quistis\""},
                 {"22", "\"\""},
                 {"23", "\"Selphie\""},
                 {"24", "\"Seifer\""},
                 {"25", "\"Edea\""},
                 {"26", "\"Laguna\""},
                 {"27", "\"Kiros\""},
                 {"28", "\"Ward\""},
                 {"29", "\"\""},
                 {"2A", "\"\""},
                 {"2B", "\"Out of Fuel!\""},
                 {"2C", "\"Fuel remaining\""},
                 {"2D", "\"\""},
                 {"2E", "\"? Yes No\""},
                 {"2F", "Square symbol"},
                 {"30", "\"\""},
                 {"31", "How to drive"},
                 {"32", "Garden Controls"},
                 {"33", "How to ride a Chocobo"},
                 {"34", "Spaceship Controls"},
                 {"35", "\"(This place looks...familiar.)\""},
                 {"36", "\"It looks abandoned and run-down...\""},
                 {"37", "\"Huh!?\""},
                 {"38", "\"Nida \"The gauge is going berserk!?\"\""},
                 {"39", "\"(Shouldn't be getting off...\""},
                 {"3A", "\"This must be Obel Lake. Throw a rock Try humming\""},
            };

            paramTypes = new Dictionary<string, ParameterType>()
            {
                 {"08", map},
                 {"15", map},
                 {"1F", textBox},
                 {"20", button},
                 {"28", map},
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
