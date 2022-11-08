using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot_TextStrings
{
     class SV_ErrorStrings
    {
        public static class ErrorStrings
        {
            public readonly static string NotOnOverworldAfterStart = "We had trouble starting the search, please request again!";
            public readonly static string NoTradePartnerFound = "No trade partner found! Check '!help linksv' for troubleshooting steps or ask for help in the #support channel in our Discord server!";
            public readonly static string NoTradePartnerFound2 = "No trade partner found, please request again! Check '!help linksv' for troubleshooting steps or ask for help in the #support channel in our Discord server!";
            public readonly static string WaitedTooLong = "You waited too long, trade aborted!";
            public readonly static string NoBoxVisible = "Box was never shown, please request again!";
            public readonly static string FailedTradePIDMatch = "Something is wrong with your Pokémon or you declined the trade!";

            public readonly static string FatalErrorException = "Fatal error occurred, please request again!";

            public readonly static string InvalidChangesAbortTrade = "@{0} Your provided customizations were invalid. Trade cancelled! Check '!help invalid' for troubleshooting steps or ask for help in the #support channel in our Discord server!";
            public readonly static string InvalidChangesTradeDefault = "@{0} Your provided customizations were invalid. Trading default set!";

            public readonly static string CrashingExploit2022 = "@{0} Your offered Pokémon is not accepted for trading!";

            public readonly static string BANNED_NNID = "Your Nintendo Network ID is banned. Trade cancelled!";
        }

        public static class ResponseStrings_Twitch
        {
            public readonly static string UserTurnStarted = "/me VoteYea @{0} It's your turn now, please start searching, you have 60 seconds to match with me! VoteYea";
            public readonly static string UserFound = "@{0} I found you, Trainer Name: {1}, waiting until you select a Pokémon! If that isn't you, please change your Link Code to a harder one!";
        }

        public static class ResponseStrings_Discord
        {
            public readonly static string UserTurnStarted = "<@{0}> It's your turn now, please start searching, you have 60 seconds to match with me!";
            public readonly static string UserFound = "<@{0}> I found you, Trainer Name: {1}, waiting until you select a Pokémon! If that isn't you, please change your Link Code to a harder one!";
        }
    }
}
