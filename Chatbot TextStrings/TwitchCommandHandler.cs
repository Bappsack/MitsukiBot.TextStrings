using System;
using static TextStrings.Chatbot_TextStrings;

namespace TextStrings
{
    public static class TwitchCommandHandler
    {
        private static Random ran = new Random();


        /// <summary>
        /// Returns a Help String for the wanted Argument
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string HandleHelpCommands(string context, int GeneralTradeCooldown = -1)
        {

            if (GeneralTradeCooldown is -1)
                GeneralTradeCooldown = 10;

            if (!context.Contains(" "))
                return HelpCommandsStrings.InvalidArgsMessage;

            string[] args = context.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            if (args.Length < 1)
                return HelpCommandsStrings.InvalidArgsMessage;

            return args[1].ToLower() switch
            {
                // Game Specific Trade Help
                "gen6" or "xy" or "oras" => HelpCommandsStrings.TradeHelp6,
                "gen7" or "sumo" or "usum" => HelpCommandsStrings.TradeHelp7,
                "gen8" or "swsh" => HelpCommandsStrings.TradeHelp8,

                // Trade Error Help
                "error" or "errors" => HelpCommandsStrings.Error,
                "errorgts" or "gts" => HelpCommandsStrings.ErrorGTS,
                "errorlink" or "link" => HelpCommandsStrings.ErrorLink,
                "errorcustom" or "custom" or "invalid" => HelpCommandsStrings.ErrorCustom,

                // Trade Command Help
                "commands" or "command" => HelpCommandsStrings.CommandList,
                "deposit" or "deposited" => HelpCommandsStrings.Deposit,
                "eggs" or "egg" => HelpCommandsStrings.Eggs,
                "events" or "event" => HelpCommandsStrings.Events,
                "fc" or "friendcode" => HelpCommandsStrings.Friendcodes,
                "format" or "example" => HelpCommandsStrings.Format,
                "forms" or "form" => HelpCommandsStrings.FormList,
                "mythicals" or "mythical" => HelpCommandsStrings.Mythicals,
                "mythicals6" or "mythical6" => HelpCommandsStrings.Mythicals6,
                "mythicals7" or "mythical7" => HelpCommandsStrings.Mythicals7,
                "mythicals8" or "mythical8" => HelpCommandsStrings.Mythicals8,
                "shiny" => HelpCommandsStrings.ShinyDefault,
                "sub" or "subs" or "subscribe" or "subscriber" => HelpCommandsStrings.Sub,
                "takeown" or "mydetails" or "trainerid" or "trainer" => HelpCommandsStrings.Takeown,

                // Chat Command Help
                "cd" or "cooldown" or "cap" or "timecapsule" => string.Format(HelpCommandsStrings.Cooldown, GeneralTradeCooldown),
                "cp" or "cparty" or "communityparty" => HelpCommandsStrings.Cparty,
                "pcoins" or "pcoin" or "coins" or "points" => HelpCommandsStrings.PCoins,
                "bandit" or "slots" => HelpCommandsStrings.Bandit,
                "gamble" or "coinflip" => HelpCommandsStrings.Gamble,
                "jackpot" or "jp" or "jack" or "bank" => HelpCommandsStrings.Jackpot,
                "trivia" => HelpCommandsStrings.Trivia,
                "raffle" or "raff" => HelpCommandsStrings.Raffle,

                // Options
                "options" or "option" => HelpCommandsStrings.Options,

                // Invalid
                _ => HelpCommandsStrings.InvalidArgsMessage,
            };
        }

        public static string HungryString()
        {
            return Food.List[ran.Next(0, Food.List.Count)];
        }
    }
}