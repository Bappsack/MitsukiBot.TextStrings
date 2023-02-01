using System;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace Chatbot_TextStrings
{
    public static class Discord_TextStrings
    {
        public static class ErrorStrings
        {
            public readonly static string IllegalFileProvided_Testing = "{0} your provided file is illegal! Report: \n\n```{1}```";
            public readonly static string IllegalFileProvided_Trading = "{0} your provided file is illegal. Trade cancelled!";

            public readonly static string InvalidFileTypeGeneral = "{0} your provided file is not supported. Trade cancelled!";
            public readonly static string InvalidFileTypePK6 = "{0} your provided file is not supported in XY/ORAS, please use a .PK6 file. Trade cancelled!";
            public readonly static string InvalidFileTypePK7 = "{0} your provided file is not supported in SM/USUM, please use a .PK7 file. Trade cancelled!";
            public readonly static string InvalidFileTypePB7 = "{0} your provided file is not supported in LGPE, please use a .PB7 file. Trade cancelled!";
            public readonly static string InvalidFileTypePK8 = "{0} your provided file is not supported in SWSH, please use a .PK8 file. Trade cancelled!";
            public readonly static string InvalidFileTypePB8 = "{0} your provided file is not supported in BDSP, please use a .PB8 file. Trade cancelled!";
            public readonly static string InvalidFileTypePA8 = "{0} your provided file is not supported in PLA, please use a .PA8 file. Trade cancelled!";
            public readonly static string InvalidFileTypePK9 = "{0} your provided file is not supported in SV, please use a .PK9 file. Trade cancelled!";

        }

        public static class ResponseStrings
        {
            public readonly static string Lock_Unlock_SubOnly = "Sorry, only subscribers can un/lock their trainer information!";
            public readonly static string ShinyLockedCommand = "These Pokémon cannot be shiny under any circumstances. More info can be found on Serebii: https://www.serebii.net/games/shiny.shtml";
            public readonly static string DumpMessageLegal = "This is what you traded to me. This Pokémon is legal!\n\n{0}";
            public readonly static string DumpMessageIllegal = "This is what you traded to me. This Pokémon is illegal!\n\n{0}";
        }

        // Example: This will return AshGreninja String
        //          fuck fuck fuck fuck fuck fuck fuck fuck fuck ash fuck fuck fuck fuck fuck fuck fuck greninja fuck fuck fuck
        //          fuck fuck fuck fuck fuck fuck request fuck fuck fuck fuck fuck fuck fuck fuck ash fuck fuck fuck fuck fuck
        //          fuck fuck fuck fuck fuck fuck fuck fuck how????
        
        public static class DumbassResponder
        {
            internal static class Needles
            {
                internal static readonly string[] TradeRespondList = { "how", "trade", "bot", "code", "request" };
                internal static readonly string[] AshGreninjaList = { "how", "ash", "greninja", "request" };
            }

            internal static class RespondStrings
            {
                internal static readonly string Trade = "blablabla trade dum dum";
                internal static readonly string AshGrenina = "blablabla trade dum dum no ash greninja";
            }

            public static string? GetResponderString(string Haystack) => Haystack.ToLower() switch
            {
                var n when Needles.TradeRespondList.All(h => n.Contains(n)) => RespondStrings.Trade,
                var n when Needles.AshGreninjaList.All(h => n.Contains(n)) => RespondStrings.AshGrenina,
                _ => null,
            };
        }
    }
}