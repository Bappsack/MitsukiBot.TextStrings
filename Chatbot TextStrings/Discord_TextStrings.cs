using System.Text.RegularExpressions;

namespace Chatbot_TextStrings
{
    public static class Discord_TextStrings
    {
        public static class ErrorStrings
        {
            public readonly static string IllegalFileProvided_Testing = "{0} your provided file is illegal! Report: \n\n```{1}```";
            public readonly static string IllegalFileProvided_Trading = "{0} your provided file is illegal. Trade cancelled! Report: \n\n```{1}```";

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
            public readonly static string InvalidContentInBotChannel = "{0} Invalid input! You did not send a valid command or are missing the trade prefix!";
            public readonly static string HelpTriggerInTradeChannels = "{0} If you need help with the bots, please ask in <#629335412141195264>!";
            public readonly static string MissingHomeTrackerDisclaimer = "[Note] This Pokémon does not originate from {0}. It might be blocked from being deposited into HOME due to missing the HOME tracker.";
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
                // internal static readonly string BotQuestionGeneral = @"^(?=.*\b(what[\W?s]*|when[\W?s]*|where[\W?s]*|why[\W?s]*|how[\W?s]*|will|won\W?t|did[n\W?t]*|do[esn\W?t]*|can[n?o?\W?t]*|problems?|issues?|is\sit\spossible)\b)(?=.*\b(bots?|commands?|roles?|cool\s?downs?|[link]*code|sub[scribe]*|deposit[seding]*|request[seding]*|work[seding]*|custom[^aes][a-z]*|[un]*ban[ned]*|form[sat]*|invalid|pcoins|offline|takeown)\b)(?!.*\b(raids?|evolv[seding]*|[poke]*dex|sand?wh?it?ch)\b).*$";
                // internal static readonly string BotQuestionTrade = @"^(?=.*\b(what[\W?s]*|when[\W?s]*|where[\W?s]*|why[\W?s]*|how[\W?s]*|will|won\W?t|did[n\W?t]*|do[esn\W?t]*|can[n?o?\W?t]*|problems?|issues?|is\sit\spossible)\b)(?=.*\b(bots?|commands?|roles?|cool\s?downs?|sub[scribe]*|deposit[seding]*|request[seding]*|work[seding]*|custom[^aes][a-z]*|[un]*ban[ned]*|format|invalid|pcoins|offline|takeown)\b)(?!.*\b(raids?|evolv[seding]*|[poke]*dex|sand?wh?it?ch)\b).*$";
                // internal static readonly string TradePostGeneral = @"^(?=.*\b(any[onebdy]*|some[onebdy]*|help)\b)(?=.*\b(trade|evolv[eing]*)\b).*$";
                // internal static readonly string NonEnglishPost = @"\b(fran[çc]ais[e]*|des fr|les gars|tout le monde|bonjour|salut|slt|svp|merci|il y a|y a-t-il|quelqu['esun]*|[pour]*quoi|qui|[m']*aider|[ée]change[rs]*|espa[ñn]ol[a]*|alguien|ayudar|como|funciona|intercambi[aeor]*|deutsch[en]*|jemand|[d]*ich|dir|du|bist|sind|bitte|geht['s]*|k[öo]nnen|kann[st]*|haben|brauch[enst]*|kein[enst]*|bekommen|nicht|auch|welche[n]*|w[üu]rde|m[öo]chte|traden|tauschen|helfen)\b";

                internal static readonly string BotPost = @"^(?=.*\b(what[\W?s]*|when[\W?s]*|where[\W?s]*|why[\W?s]*|how[\W?s]*|will|won\W?t|did[n\W?t]*|do[esn\W?t]*|can[n?o?\W?t]*|is\sit\spossible|problems?|issues?|help)\b)(?=.*\b(bots?|commands?|roles?|cool\s?downs?|sub[scribe]*|deposit[seding]*|request[seding]*|work[seding]*|custom[aeiodnstz]*|[un]*ban[ned]*|invalid|encounter|partner|pcoins?|offline|takeown|format)\b)(?!.*\b(raids?|evolv[seding]*|[poke]*dex|sand?wh?it?ch)\b).*$";
                internal static readonly string TradePost = @"^(?=.*\b(any[onebdy]*|some[onebdy]*|help)\b)(?=.*\b(trade|evolv[eing]*)\b).*$";
                internal static readonly string NonEnglishPost = @"\b(fran[çc]ais[e]*|des fr|les gars|tou[tse]|bonjour|salut|slt|s[tv]p|merci|il y a|y a-t-il|quelqu['esun]*|[pour]*quoi|qui|[m']*aider|[ée]change[rs]*|espa[ñn]ol[a]*|alguien|ayudar|como|funciona|intercambi[aeor]*|deutsch[en]*|jemand|[d]*ich|dir|du|das|b?ist|sind|bitte|geht['s]*|k[öo]nnen|kann[st]*|haben|brauch[enst]*|kein[enst]*|bekommen|nicht|auch|welche[n]*|w[üu]rde|m[öo]chte|schreib[en]*|traden|tauschen|helfen)\b";
            }

            internal static class RespondStrings
            {
                internal static readonly string PostInSupport = "Your message was flagged as a possible help post. **If you need help with the bots, streams, or server, please post in <#629335412141195264>!**";
                internal static readonly string PostInTradeRoom = "Your message was flagged as a possible trade post. **If you are looking to trade with other users, please post in <#313696378398310401>!**";
                internal static readonly string EnglishOnly = "For moderation purposes, this server is **English only**.";
            }

            public static string? GetResponderString(string Haystack, ulong ChannelID) => Haystack switch
            {
                var h when (ChannelID == GeneralChat && Regex.IsMatch(h, Needles.BotPost, options)) => RespondStrings.PostInSupport,
                var h when (ChannelID == GeneralChat && Regex.IsMatch(h, Needles.TradePost, options)) => RespondStrings.PostInTradeRoom,
                var h when (ChannelID == GeneralChat && Regex.IsMatch(h, Needles.NonEnglishPost, options)) => RespondStrings.EnglishOnly,
                _ => null,
            };
        }
    }
}


