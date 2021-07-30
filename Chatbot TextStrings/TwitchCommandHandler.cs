using Chatbot_TextStrings;
using System;

namespace Twitch_Chatbot_Mitsuki
{
    public static class TwitchCommandHandler
    {
        private static Random ran = new Random();


        /// <summary>
        /// Returns a Help String for the wanted Argument
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string HandleHelpCommands(string context, dynamic data, int GeneralTradeCooldown)
        {

            if (!context.Contains(" "))
                return TextStrings.HelpCommandsStrings.InvalidArgsMessage;

            string[] args = context.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            if (args.Length < 1)
                return TextStrings.HelpCommandsStrings.InvalidArgsMessage;

            return args[1].ToLower() switch
            {
                // Game Specific Trade Help
                "gen6" or "xy" or "oras" => TextStrings.HelpCommandsStrings.TradeHelp6,
                "gen7" or "sumo" or "usum" => TextStrings.HelpCommandsStrings.TradeHelp7,
                "gen8" or "swsh" => TextStrings.HelpCommandsStrings.TradeHelp8,

                // Trade Error Help
                "error" or "errors" => TextStrings.HelpCommandsStrings.Error,
                "errorgts" or "gts" => TextStrings.HelpCommandsStrings.ErrorGTS,
                "errorlink" or "link" => TextStrings.HelpCommandsStrings.ErrorLink,
                "errorcustom" or "custom" or "invalid" => TextStrings.HelpCommandsStrings.ErrorCustom,

                // Trade Command Help
                "commands" or "command" => TextStrings.HelpCommandsStrings.CommandList,
                "deposit" or "deposited" => TextStrings.HelpCommandsStrings.Deposit,
                "eggs" or "egg" => TextStrings.HelpCommandsStrings.Eggs,
                "events" or "event" => TextStrings.HelpCommandsStrings.Events,
                "fc" or "friendcode" => TextStrings.HelpCommandsStrings.Friendcodes,
                "format" or "example" => TextStrings.HelpCommandsStrings.Format,
                "forms" or "form" => TextStrings.HelpCommandsStrings.FormList,
                "mythicals" or "mythical" => TextStrings.HelpCommandsStrings.Mythicals,
                "mythicals6" or "mythical6" => TextStrings.HelpCommandsStrings.Mythicals6,
                "mythicals7" or "mythical7" => TextStrings.HelpCommandsStrings.Mythicals7,
                "mythicals8" or "mythical8" => TextStrings.HelpCommandsStrings.Mythicals8,
                "shiny" => TextStrings.HelpCommandsStrings.ShinyDefault,
                "sub" or "subs" or "subscribe" or "subscriber" => TextStrings.HelpCommandsStrings.Sub,
                "takeown" or "mydetails" or "trainerid" or "trainer" => TextStrings.HelpCommandsStrings.Takeown,

                // Chat Command Help
                "cd" or "cooldown" or "cap" or "timecapsule" => string.Format(TextStrings.HelpCommandsStrings.Cooldown, GeneralTradeCooldown),
                "cp" or "cparty" or "communityparty" => TextStrings.HelpCommandsStrings.Cparty,
                "pcoins" or "pcoin" or "coins" or "points" => TextStrings.HelpCommandsStrings.PCoins,
                "bandit" or "slots" => TextStrings.HelpCommandsStrings.Bandit,
                "gamble" or "coinflip" => TextStrings.HelpCommandsStrings.Gamble,
                "jackpot" or "jp" or "jack" or "bank" => TextStrings.HelpCommandsStrings.Jackpot,
                "trivia" => TextStrings.HelpCommandsStrings.Trivia,
                "raffle" or "raff" => TextStrings.HelpCommandsStrings.Raffle,

                // Options
                "options" or "option" => TextStrings.HelpCommandsStrings.Options,

                // Invalid
                _ => TextStrings.HelpCommandsStrings.InvalidArgsMessage,
            };
        }

        public static string HungryString()
        {
            return Food.List[ran.Next(0, Food.List.Count)];
        }
    }
}