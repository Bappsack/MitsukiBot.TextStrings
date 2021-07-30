namespace TextStrings
{
    public static class _3DSErrorStrings
    {
        public static string InvalidDepoit = "Invalid deposit Pokémon!";
        public static string NoEntriesFound = "It appears there are no entries of your deposit Pokémon, request again with a different Pokémon! (ERROR: NO ENTRIES FOUND!)";
        public static string NoRequestOnListFound = "Can't find any Pokémon from your request in the list, please try again!";
        public static string DepositNotFound = "Your deposit Pokémon was not found, please try again! Check '!help gts' for troubleshooting steps! Remember, mythical Pokémon can't be requested from the Gen 7 (SUMO/USUM) GTS trades!";
        public static string PossibleAlreadyTraded = "Pokémon was already traded?";

        /* Prolly Deleted when new Change result in a failed trade */
        public static string InvalidChangesDefault = "Invalid customizations, trading default Pokémon if no level was set, otherwise see this as a failed trade!";
        public static string LegalityIssuesAfterbuild = "Something is wrong with your request!";

        public static string TradeCanceledGenderLevelNotAny = ", Trade cancelled, you selected Gender: {0} and Level: {1} in the GTS, but the Gender and Level should be set to Any!";
        public static string TradeCanceledLevelNotAny = ", Trade cancelled, you selected Level: {0} in the GTS, but the Level should be set to Any!";
        public static string TradeCanceledGenderNotAny = ", Trade cancelled, you selected Gender: {0} in the GTS, but the Gender should be set to Any!";

        public static string AlreadyTradedOrInvalidException = "Pokémon has already been traded by another person or you probably made invalid customizations!";
        public static string FatalErrorException = "Fatal error occurred, please try again!";

        public static string InvalidChangesAbortTrade = "Your provided customizations were invalid. Trade cancelled!";
    }
}
