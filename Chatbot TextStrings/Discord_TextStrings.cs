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
            public readonly static string ReadRulesFirst = "{0} you haven’t read the rules yet! In order to use the bots in this Discord server, you have to read and accept the <#317414882821799937>!";
            public readonly static string HelpTriggerInTradeChannels = "{0} if you need help with the bots, ask in <#629335412141195264>";
        }

        public static class DumbassResponder
        {
            internal static class Needles
            {
                internal static readonly string BotQuestionList_NonSupport = "";
                internal static readonly string BotQuestionList_NonSupport2 = "";
                internal static readonly string BotQuestionList_NonSupport3 = "";

                internal static readonly string TradeRespondList = "";
                internal static readonly string AshGreninjaList = "";
            }

            internal static class RespondStrings
            {
                internal static readonly string BotQuestionNonSupport = "Bot questions need to be asked in <#629335412141195264>";
                internal static readonly string Trade = "blablabla trade dum dum";
                internal static readonly string AshGrenina = "blablabla trade dum dum no ash greninja";
            }

            public static string? GetResponderString(string Haystack, bool IsInSupportChannel) => Haystack switch
            {
                var h when (!IsInSupportChannel && Regex.IsMatch(h, Needles.BotQuestionList_NonSupport, RegexOptions.IgnoreCase)) => RespondStrings.BotQuestionNonSupport,
                var h when (!IsInSupportChannel && Regex.IsMatch(h, Needles.BotQuestionList_NonSupport2, RegexOptions.IgnoreCase)) => RespondStrings.BotQuestionNonSupport,
                var h when (!IsInSupportChannel && Regex.IsMatch(h, Needles.BotQuestionList_NonSupport3, RegexOptions.IgnoreCase)) => RespondStrings.BotQuestionNonSupport,
                var h when Regex.IsMatch(h, Needles.TradeRespondList, RegexOptions.IgnoreCase) => RespondStrings.Trade,
                var h when Regex.IsMatch(h, Needles.AshGreninjaList, RegexOptions.IgnoreCase) => RespondStrings.AshGrenina,
                _ => null,
            };
        }
    }
}