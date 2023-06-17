using System;
using System.IO;
using static TextStrings.Chatbot_TextStrings;

namespace TextStrings
{
    public static class TwitchCommandHandler
    {
        private readonly static Random ran = new();

        public enum Source
        {
            Twitch,
            Discord,
            All
        };

        /// <summary>
        /// Returns a Help String for the wanted Argument
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string HandleHelpCommands(string context, Source source = Source.All, int GeneralTradeCooldown = -1)
        {

            if (GeneralTradeCooldown is -1)
                GeneralTradeCooldown = 10;

            if (!context.Contains(' '))
                return HelpCommandsStrings.InvalidArgsMessage;

            string[] args = context.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            if (args.Length < 1)
                return HelpCommandsStrings.InvalidArgsMessage;

            return args[1].ToLower() switch
            {
                // Game Specific Trade Help
                "gen6" or "xy" or "oras" => HelpCommandsStrings.TradeHelp6,
                "gen7" or "sm" or "usum" => HelpCommandsStrings.TradeHelp7,
                "swsh" => HelpCommandsStrings.TradeHelpSWSH,
                "bdsp" => HelpCommandsStrings.TradeHelpBDSP,
                "pla" => HelpCommandsStrings.TradeHelpPLA,
                "sv" => HelpCommandsStrings.TradeHelpSV,

                // Trade Error Help
                "error" or "errors" => HelpCommandsStrings.Error,
                "gts" => HelpCommandsStrings.ErrorGTS,
                "linkswsh" => HelpCommandsStrings.ErrorLinkSWSH,
                "linkbdsp" => HelpCommandsStrings.ErrorLinkBDSP,
                "linkpla" => HelpCommandsStrings.ErrorLinkPLA,
                "linksv" => HelpCommandsStrings.ErrorLinkSV,
                "invalid" => HelpCommandsStrings.ErrorInvalid,

                // Mythicals Help
                "mythicals" or "mythical" => HelpCommandsStrings.Mythicals,
                "mythicals6" or "mythical6" => HelpCommandsStrings.Mythicals6,
                "mythicals7" or "mythical7" => HelpCommandsStrings.Mythicals7,
                "mythicals8" or "mythical8" => HelpCommandsStrings.Mythicals8,
                "mythicals9" or "mythical9" => HelpCommandsStrings.Mythicals9,

                // Trade Command Help
                "commands" or "command" or "customizations" or "customization" => HelpCommandsStrings.CommandList,
                "cooldown" or "cd" or "cap" or "timecapsule" => string.Format(HelpCommandsStrings.Cooldown, GeneralTradeCooldown),
                "deposit" or "deposited" => HelpCommandsStrings.Deposit,
                "eggs" or "egg" => HelpCommandsStrings.Eggs,
                "events" or "event" => HelpCommandsStrings.Events,
                "friendcode" or "fc" => HelpCommandsStrings.FriendCode,
                "format" or "example" => HelpCommandsStrings.Format,
                "forms" or "form" => HelpCommandsStrings.FormList,
                "language" or "languages" or "lang" => HelpCommandsStrings.Language,
                "mark" or "marks" => HelpCommandsStrings.Marks,
                "origin" or "origins" => HelpCommandsStrings.Origin,
                "shiny" or "shinylock" or "shinylocks" or "shinylocked" => HelpCommandsStrings.ShinyState,
                "showdown" or "smogon" => HelpCommandsStrings.Showdown,
                "sub" or "subs" or "subscribe" or "subscriber" => HelpCommandsStrings.Sub,
                "tid" or "sid" => HelpCommandsStrings.TIDSID,
                "takeown" or "mydetails" or "trainerid" or "trainer" => HelpCommandsStrings.Takeown,
                "wt" or "wondertrade" => HelpCommandsStrings.WonderTrade,

                // Chat Command Help
                "pcoins" or "pcoin" or "coins" or "points" => HelpCommandsStrings.PCoins,
                "bandit" or "slots" => HelpCommandsStrings.Bandit,
                "gamble" or "coinflip" => HelpCommandsStrings.Gamble,
                "jackpot" or "jp" or "jack" or "bank" => HelpCommandsStrings.Jackpot,
                "raffle" or "raff" => HelpCommandsStrings.Raffle,
                "roulette" or "roul" or "bet" => HelpCommandsStrings.Roulette,
                "sounds" or "sound" => string.Format(HelpCommandsStrings.Sounds, GetSoundFilesString()),
                "trivia" => HelpCommandsStrings.Trivia,

                // Options
                "options" or "option" => HelpCommandsStrings.Options,

                // Invalid
                _ => HelpCommandsStrings.InvalidArgsMessage,
            };
        }

        public static string HungryString() => Food.List[ran.Next(0, Food.List.Count)];

        public static string GetSoundFilesString()
        {
            var sounds = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Sounds\\", "*.wav", SearchOption.AllDirectories);
            string result = string.Empty;
            foreach (var sound in sounds)
                result += $"{Path.GetFileName(sound).Replace(".wav", "")}, ";

            return result.TrimEnd(' ').TrimEnd(',');
        }

    }
}