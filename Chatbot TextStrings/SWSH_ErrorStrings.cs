namespace TextStrings
{
    public static class SWSH_TextStrings
    {

        public static class ErrorStrings
        {
            public static string NotOnOverworldAfterStart = "We had trouble starting the search, please request again!";
            public static string NoTradePartnerFound = "No trade partner found!";
            public static string NoTradePartnerFound2 = "No trade partner found, please request again!";
            public static string WaitedTooLong = "You waited too long, trade aborted!";
            public static string NoBoxVisible = "Box was never shown, please request again!";
            public static string FailedTradePIDMatch = "Something is wrong with your Pokémon or you declined the trade!";

            public static string FatalErrorException = "Fatal error occurred, please request again!";

            public static string InvalidChangesAbortTrade = "Your provided customizations were invalid. Trade cancelled!";
        }

        public static class ResponseStrings
        {
            public static string UserTurnStarted = "/me VoteYea @{0} It's your turn now, please start searching, you have 60 seconds to match with me! VoteYea";
            public static string UserFound = "@{0} I found you, Trainer Name: {1}, waiting until you select a Pokémon! If that isn't you, please change your Link Code to a harder one!";
        }
    }
}
