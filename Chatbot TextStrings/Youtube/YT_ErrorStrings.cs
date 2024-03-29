﻿namespace Chatbot_TextStrings
{
    public static class YT_ErrorStrings
    {
        public static readonly string YT_Species_Mismatch = "@{0} Your custom Pokémon request doesn't match the Pokémon wanted in the GTS. Trading default!";
        public static readonly string YT_Custom_Trade_Error = "@{0} Your custom Pokémon request has invalid changes. Trading default!";
        public static readonly string YT_Shiny_Clone_Error = "@{0} Your shinifying request isn't possible. Trade cancelled!";
        public static readonly string YT_Train_Clone_Error = "@{0} Your training request isn't possible. Trade cancelled!";
        public static readonly string YT_Evo_Clone_Error = "@{0} Your trade evolving request isn't possible. Trade cancelled!";
        public static readonly string YT_Cleaning_Clone_Error = "@{0} Your name clearing request isn't possible. Trade cancelled!";
        public static readonly string YT_Not_In_Galar = "@{0} Your requested Pokémon isn't in SWSH. Trade cancelled!";
        public static readonly string YT_Not_In_Sinnoh = "@{0} Your requested Pokémon isn't in BDSP. Trade cancelled!";
        public static readonly string YT_Not_In_Hisui = "@{0} Your requested Pokémon isn't in PLA. Trade cancelled!";
        public static readonly string YT_Not_In_Paldea = "@{0} Your requested Pokémon isn't in SV. Trade cancelled!";
        public static readonly string YT_FC_Banned = "@{0} Your friend code is banned, you aren't allowed to trade here anymore.";
        public static readonly string YT_NNID_Banned = "@{0} Your Nintendo Network ID is banned, you aren't allowed to trade here anymore.";
        public static readonly string YT_Fatal_Error = "@{0} Your custom Pokémon request triggered an unhandled exception, please report it in our Discord server to get it fixed.";

        public static readonly string YT_Missing_HomeTracker = "[Note] This Pokémon does not originate from {0}. It might be blocked from being deposited into HOME due to missing the HOME tracker.";
    }
}
