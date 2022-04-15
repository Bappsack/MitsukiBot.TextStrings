namespace TextStrings
{
    public static class BDSP_TextStrings
    {
        public static class ErrorStrings
        {
            public readonly static string NotOnOverworldAfterStart = "We had trouble starting the search, please request again!";
            public readonly static string NoTradePartnerFound = "No trade partner found! Check '!help linkbdsp' for troubleshooting steps or ask for help in the #support channel in our Discord server!";
            public readonly static string NoTradePartnerFound2 = "No trade partner found, please request again! Check '!help linkbdsp' for troubleshooting steps or ask for help in the #support channel in our Discord server!";
            public readonly static string WaitedTooLong = "You waited too long, trade aborted!";
            public readonly static string NoBoxVisible = "Box was never shown, please request again!";
            public readonly static string FailedTradePIDMatch = "Something is wrong with your Pokémon or you declined the trade!";

            public readonly static string FatalErrorException = "Fatal error occurred, please request again!";

            public readonly static string InvalidChangesAbortTrade = "@{0} Your provided customizations were invalid. Trade cancelled! Check '!help invalid' for troubleshooting steps or ask for help in the #support channel in our Discord server!";
            public readonly static string InvalidChangesTradeDefault = "@{0} Your provided customizations were invalid. Trading default set!";

            public readonly static string BANNED_NNID = "Your trade was rejected because your Nintendo Network ID was banned.";
        }

        public static class ResponseStrings
        {
            public readonly static string UserTurnStarted = "/me VoteYea @{0} It's your turn now, please start searching, you have 60 seconds to match with me! VoteYea";
            public readonly static string UserFound = "@{0} I found you, Trainer Name: {1}, waiting until you select a Pokémon! If that isn't you, please change your Link Code to a harder one!";
        }
    }
}
