namespace TextStrings
{
    public static class N3DSErrorStrings
    {
        public readonly static string InvalidDepoit = "Invalid deposit Pokémon!";
        public readonly static string NoEntriesFound = "It appears there are no entries of your deposit Pokémon, request again with a different Pokémon! (ERROR: NO ENTRIES FOUND!)";
        public readonly static string NoRequestOnListFound = "Can't find any Pokémon from your request in the list, please request again!";
        public readonly static string DepositNotFound = "Your deposit Pokémon was not found, please request again! Check '!help gts' for troubleshooting steps or ask for help in the #support channel in our Discord server!";
        public readonly static string PossibleAlreadyTraded = "Pokémon was already traded?";

        /* Prolly Deleted when new Change result in a failed trade */
        public readonly static string InvalidChangesDefault = "Invalid customizations, trading default Pokémon if no level was set, otherwise see this as a failed trade!";
        public readonly static string LegalityIssuesAfterbuild = "Something is wrong with your request!";

        public readonly static string Mythicals6PastGen = "Your requested mythical Pokémon is not from a Gen 6 event, so it cannot be traded via the GTS! Trade cancelled!";

        public readonly static string TradeCanceledGenderLevelNotAny = ", Trade cancelled, you selected Gender: {0} and Level: {1} in the GTS, but the Gender and Level should be set to Any!";
        public readonly static string TradeCanceledLevelNotAny = ", Trade cancelled, you selected Level: {0} in the GTS, but the Level should be set to Any!";
        public readonly static string TradeCanceledGenderNotAny = ", Trade cancelled, you selected Gender: {0} in the GTS, but the Gender should be set to Any!";

        public readonly static string AlreadyTradedOrInvalidException = "Pokémon has already been traded by another person or you probably made invalid customizations!";
        public readonly static string FatalErrorException = "Fatal error occurred, please request again!";

        public readonly static string InvalidChangesAbortTrade = "Your provided customizations were invalid. Trade cancelled! Check '!help invalid' for troubleshooting steps or ask for help in the #support channel in our Discord server!";
    }
}
