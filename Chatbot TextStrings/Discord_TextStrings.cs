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
            public readonly static string ReadRulesFirst = "{0} You have to read and accept the <#317414882821799937> to use the bots!";
            public readonly static string HelpTriggerInTradeChannels = "{0} If you need help with the bots, please ask in <#629335412141195264>!";
        }

        public static class DumbassResponder
        {
            internal static readonly RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Multiline;

            internal static ulong GeneralChat = 312692099264937984;
            internal static ulong TradeRoom = 313696378398310401;
            internal static ulong SubRoom = 582336509890265088;
            internal static ulong Support = 629335412141195264;

            internal static class Needles
            {
                internal static readonly string BotQuestionList_NonSupport = @"^(?=.*\b(what[\W?s]*|when[\W?s]*|where[\W?s]*|why[\W?s]*|how[\W?s]*|will|won\W?t|did[n\W?t]*|do[esn\W?t]*|can[n?o?\W?t]*|problems?|issues?|is\sit\spossible)\b)(?=.*\b(bots?|commands?|forms?|roles?|cool\s?downs?|[link]*code|sub[scribe]*|deposit[seding]*|request[seding]*|work[seding]*|invalid|pcoins|online|offline|banned)\b)(?!.*\b(raids?|evolv[seding]*|[poke]*dex|sand?wh?it?ch)\b).*$";
            }

            internal static class RespondStrings
            {
                internal static readonly string BotQuestionNonSupport = "Your message was flagged as a possible support question. **If you need help with the bots, streams, or server, please ask in <#629335412141195264>!** If you did not ask a support question, please disregard this message.";
            }
            
            public static string? GetResponderString(string Haystack, ulong ChannelID) => Haystack switch
            {
                var h when ( ChannelID == GeneralChat && ChannelID != Support && Regex.IsMatch(h, Needles.BotQuestionList_NonSupport, options)) => RespondStrings.BotQuestionNonSupport,
                _ => null,
            };
        }
    }
}