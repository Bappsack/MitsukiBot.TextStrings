﻿using System.Collections.Generic;

namespace TextStrings
{
    // I am Sir Cumalot!
    public static class Chatbot_TextStrings
    {
        public static class InternalStrings
        {
            public static string NotConnectedYet = "Not Connected yet, waiting...";
            public static string Connect_Attemp = "Attempting to Connect to Twitch Api...";
            public static string Jobs_Done = "All Jobs done.";
            public static string Restart_Complete = "Restart complete!";
            public static string Cant_connect = "Can't connect to Stream! Try again in one second...";
            public static string Restart_now = "Performing a restart...";
            public static string PuBSub_Failed = "Failed to Start PubSubService";
            public static string FollowerService_Failed = "Failed to Start FollowerService.";
            public static string PubSub_Disconnected = "PubSub Disconnected.";
            public static string FollowerService_Disconnected = "FollowerService Disconnected.";
            public static string Chatbot_Disconnected = "Chatbot disconnected, Connection lost! Trying to Reconnect...";
            public static string Collect_Subscriber_List = "Collecting Subscriber List...";
            public static string Bot_Disconnected_Successfull = "Bot Stopped Successfully, disconnecting from Chat!";
        }

        public static class TradeRequestString
        {
            public static string IV_too_high = "{0} too high ({1}/31)";
            public static string EV_too_high = "{0} too high ({1}/252)";

            public static string Invalid_Ball = "Invalid Ball!";
            public static string Invalid_Ability = "Invalid Ability!";
            public static string Invalid_Item = "Invalid Item!";
            public static string Invalid_Language = "Invalid Language!";
            public static string Invalid_Origin = "Invalid Origin!";
            public static string Invalid_Mark = "Invalid Mark!";
            public static string Invalid_Nature = "Invalid Nature!";
            public static string Invalid_Deposit = "Invalid Deposit Pokémon!";
            public static string Invalid_Move = "Invalid Move{0}!";
            public static string Invalid_Request = "Invalid Request Pokémon!";
            public static string Invalid_Ribbons = "Invalid Ribbons State!";
            public static string Invalid_Shiny = "Invalid Shiny State!";
            public static string Invalid_PokeRus = "Invalid Pokérus State!";
            public static string Invalid_Gender = "Invalid Gender State!";
            public static string Invalid_GMax = "Invalid Gmax State!";
            public static string Invalid_Event = "Invalid Event State!";
            public static string Invalid_Egg = "Invalid Egg State!";
            public static string Invalid_TakeOwn = "Invalid TakeOwn State!";

            public static string Invalid_Form_TooLong = "Invalid: Form too long!";
            public static string Invalid_Nickname_TooLong = "Invalid: Nickname too long!";
            public static string Invalid_OT_TooLong = "Invalid: OT too long!";
            public static string Invalid_Event_ID_TooLong = "Invalid: Event_ID too long!";
            public static string Invalid_TID_TooLong = "Invalid: TID too long!";
            public static string Invalid_SID_TooLong = "Invalid: SID too long!";
            public static string InvalidChangesAbortTrade = "Your provided customizations were invalid. Trade cancelled!";

            public static string FusedForm = "Invalid: Fused forms can't be traded!";
            public static string NoRequest = "no wanted Pokémon specified!";
            public static string NoDeposit = "no deposit Pokémon specified!";
            public static string NotInGalar = "This Pokémon doesn't exist in Galar!";
            public static string NotInSinnoh = "This Pokémon doesn't exist in Sinnoh!";
            public static string SID5Digit = "Invalid: SID can only be 5 digits!";
            public static string Level_to_high = "Level too high ({0}/100)";
            public static string MythicalsGen7GTS = "You can't use this deposit Pokémon, this is a mythical Pokémon which can't be traded via the GTS in Gen 7!";
            public static string EvolvingDepositMon = "You can't use this deposit Pokémon, this Pokémon will evolve during trade!";
            public static string MegaStonesSubOnly = "Mega Stones are sub-only!";

            public static string TooManyErrorsToPrint = "Too many invalid commands! Make sure you didn't forget the commas!";
            public static string Exception = "Wrong/bad command usage! Make sure you didn't forget the commas!";
            public static string NoGameDetect = "Invalid command usage!";


            //Temporary unreleased in BDSP
            public static string BDSP_Unreleased = "This Pokémon hasn't been released yet in BDSP, wait until it gets released.";

        }

        public static class TradeResponseStrings
        {
            public static string RequestNotFoundGameDefault = "({0}) @{1} We couldn't trade your Pokémon!";
            public static string RequestNotFoundGameDefaultMessage = "({0}) @{1} We couldn't trade your Pokémon! Error message: {2}";
            public static string RequestNotFoundDefault = "@{0} We couldn't trade your Pokémon! Error message: {1}";
            public static string RequestNotFoundMessage = "({0}) @{1} We couldn't trade your Pokémon {2}!";
            public static string RequestInvalid = "@{0} Your request seems invalid: {1}";

            public static string RequestWasTradedGame = "({0}) @{1} Your Pokémon {2} has been traded!";
            public static string RequestWasTraded = "@{0} Your Pokémon {1} has been traded!";
            public static string RequestWasTradedSubscriberGame = "[Subscriber Trade] ({0}) @{1} Your Pokémon {2} has been traded!";
            public static string RequestWasTradedSubscriber = "[Subscriber Trade] @{0} Your Pokémon {1} has been traded!";
        }

        public static class ResponseStrings
        {
            // Diverse Stuff
            public static string RestartMessage = "Performing a restart...";
            public static string NoticedNameChange = "We noticed a name change, so we transferred your stats! Welcome back!";
            public static string NewUserJoined = "Welcome to the stream, make sure you read the rules! Check how to trade with !help";
            public static string Gen8TradesDisabled = "SWSH trades are currently disabled.";
            public static string BDSPTradesDisabled = "BDSP trades are currently disabled.";

            public static string NonSubTrainerInfoError = "Sorry, only subscribers can check their trainer information!";

            public static string Friendcode3DS = "Your 3DS friend code is:";
            public static string FriendcodeSwitch = "Your Switch friend code is:";
            public static string FriendCodeSaved = "Your 3DS friend code is now saved:";
            public static string SwitchFriendCodeSaved = "Your Switch friend code is now saved:";
            public static string InvalidFriendcode = "You entered an invalid friend code:";

            public static string SubHype = "mitsukiLUL SUB HYPE mitsukiLUL SUB HYPE mitsukiLUL SUB HYPE mitsukiLUL SUB HYPE mitsukiLUL SUB HYPE mitsukiLUL SUB HYPE mitsukiLUL SUB HYPE mitsukiLUL SUB HYPE mitsukiLUL SUB HYPE mitsukiLUL SUB HYPE Thank you for subscribing {0}";
            public static string ReSubHype = "mitsukiLUL RE-SUB HYPE mitsukiLUL RE-SUB HYPE mitsukiLUL RE-SUB HYPE mitsukiLUL RE-SUB HYPE mitsukiLUL RE-SUB HYPE mitsukiLUL RE-SUB HYPE mitsukiLUL RE-SUB HYPE mitsukiLUL RE-SUB HYPE mitsukiLUL Thank you for re-subscribing {0}";

            public static string SWSH_TradesBlocked = "SWSH trades are now disabled.";
            public static string SWSH_TradesUnblocked = "SWSH trades are now enabled.";

            public static string BDSP_TradesBlocked = "BDSP trades are now disabled.";
            public static string BDSP_TradesUnblocked = "BDSP trades are now enabled.";


            public static string FakeBan_Success = "{0} has been banned from chat, friend code: {1} has been banned globally.";
            public static string FakeBan_Error = "Wrong format!";

            public static string Bits_ReceivedMessage = "{0} cheered {1} Bits! Community Party has been extended to {2} trades!";

            public static string UpTime = "The stream has been running for {0} days, {1} hours, and {2} minutes.";
            public static string FollowAge = "@{0} You have been following this channel for {1} days, {2} hours, and {3} minutes.";
            public static string NotFollowing = "@{0} It seems like you aren't following this channel yet.";
            public static string StreamOffline = "@{0} The stream is currently offline, but the bots should still be working. The stream will be back soon!";

            // Save Trade Code
            public static string SetCode_BlacklistedCode = "Your wanted Link Code is blacklisted, this Link Code is used by other people already! Please save a different Link Code!";
            public static string SetCode_Success = "Your Link Code is now saved!";
            public static string SetCode_Error = "Your wanted Link Code is the wrong length (8 digits) or contains non-digits! If you are trying to save a 3DS friend code, use '!savefc' instead!";


            // Transfer Pcoins
            public static string Give_Success = "{0} transferred {1} Pcoins to {2}";
            public static string Give_NegativeAmount = "You can't transfer a negative amount or gibberish Kappa";
            public static string Give_Error = "Failed to transfer Pcoins";
            public static string Give_SameUser = "You can't transfer Pcoins to yourself!";


            // Find Friendcodes
            public static string FindFriendcode_Success = "The friend code from user: {0} is: {1}";
            public static string FindFriendcode_NotFound = "User not found.";
            public static string FindFriendcode_NotSaved = "User: {0} never saved a friend code.";

            // Find Users by Friendcode
            public static string FindUserFriendcode_Success = "User(s) with this friend code: {0}";
            public static string FindUserFriendcodeNone = "Nobody has this friend code saved.";
            public static string FindUserFriendcode_Null = "Friend code is invalid.";

            // Bans
            public static string Ban_SuccessWithFriendcode = "[Ban Message] User: {0} has been banned from chat, reason: {1}, friend code/NNID: {2} has been banned globally.";
            public static string Ban_SuccessWithoutFriendcode = "[Ban Message] User: {0} has been banned from chat, reason: {1}, user didn't save a friend code/NNID yet, no friend code/NNID was banned.";
            public static string BanFriendcode_Success = "@{0} has banned the friend code/NNID: {1} from user: {2}";
            public static string Ban_Success = "[Ban Message] User: {0} has been banned from chat, reason: {1}, friend code/NNID will be blocked from now on if saved.";
            public static string BanFriendcode_NotFound = "Nobody has this friend code/NNID saved.";


            // Unban
            public static string Unban_Success = "@{0} has unbanned the friend code/NNID: {1} from user: {2}";
            public static string Unban_NotBanned = "This user isn't banned.";
            public static string Unban_NotFound = "This user was not found/never saved a friend code/NNID.";


            // Last Seen
            public static string LastSeen_IsHere = "{0} is currently here!";
            public static string LastSeen_Success = "The user: {0} last visited the stream {1} days, {2} hours, and {3} minutes ago.";
            public static string LastSeen_NotFound = "User not found.";

            // Trainer Details
            public static string TrainerDetails_Locked = "Your trainer details are now locked!";
            public static string TrainerDetails_Unlocked = "Your trainer details are now unlocked!";
            public static string TrainerDetails_NotSaved = "You have no trainer details saved, check '!help takeown' for steps to save your trainer details!";


            // Cooldowns
            public static string TradeCooldownMessage = "You currently have a trade cooldown! Remaining time: {0} minutes and {1} seconds! mitsukiAngry";
            public static string TradeCooldownOver = "You can request a trade!";
            public static string TradeCooldownSubMessage = "As a sub you don't have a trade cooldown!";
            public static string TimeCapsule_Success = @"You took a step into the future, there are over 5000 Pokémon now and it looks like here you don't have a trade cooldown ¯\_(ツ)_/¯";
            public static string TimeCapsule_Error = "You don't have enough Pcoins to use a timecapsule! [{0}/5000 Pcoins]";
            public static string TimeCapsule_AlreadyInQueue = "You're currently in the queue! Wait until your trade is processed to reset your trade cooldown!";
            public static string TimeCapsule_SubscriberError = "As a sub you don't need to use timecapsules!";


            // Trades
            public static string Trade_CodeNotSaved = "[Switch] You haven't saved a Link Code yet! Use '!setcode ####-####' to save a Link Code! If you are on a 3DS game, use '!trade' (SUMO/USUM) or '!tradeORAS' (XY/ORAS) instead!";
            public static string Trade_FriendcodeBanned = "So you're trying to trade? Too bad, your friend code is banned! mitsukiLUL";
            public static string Trade_NNIDBanned = "So you're trying to trade? Too bad, your Nintendo Network ID is banned! mitsukiLUL";
            public static string Trade_TooLonginQueue = "It seems you've been in the queue for way too long, you will be removed from the queue! Please request again!";
            public static string Trade_AlreadyInQueue = "You're already in the queue, please wait a bit!";
            public static string Trade_Cooldown = "You currently have a trade cooldown! Remaining time:";
            public static string Trade_NoFriendCodeSaved = "[3DS] You haven't saved your friend code yet! Use '!savefc ####-####-####' to save your friend code! If you are on a Switch game, use '!tradeBDSP' (BDSP) or '!strade' (SWSH) instead!";
            public static string Trade_ShowdownConvertError = "Wrong command usage!";
            public static string Trade_Failed_Error = "Trade request failed! Reason(s): {0}";
            public static string Trade_Success_Normal = "Your trade has been accepted!";
            public static string Trade_Success_Cparty = "Your community party trade has been accepted!";
            public static string Trade_Success_Subscriber = "Your subscriber trade has been accepted!";

            public static string TradeCancel_Success = "You've been removed from the queue!";
            public static string TradeCancel_Error = "You're not in the queue!";
            public static string TradeCancel_ToEarly = "No need to hurry, wait a minimum of 15 minutes!";

            public static string Trade_Showdown_Gen67_Disclaimer = "(The deposit Pokémon defaults to Trubbish for Gen 6/7 Showdown sets if not specified!)";


            // Wondertrade Winner Message
            public static string Wondertrade_Winner_Block = "";
            public static string Wondertrade_Winner = "Was lucky and has won a {0} via Wonder Trade! mitsukiPlsRNG SabaPing , total wins: {1}";


            // Forms
            public static string Form_Success = "Available forms:";
            public static string Form_Alcremie_List = "Available Alcremie forms: [Cream/Swirl] Vanilla Cream, Ruby Cream, Matcha Cream, Mint Cream, Lemon Cream, Salted Cream, Ruby Swirl, Caramel Swirl, Rainbow Swirl // [Sweet] Strawberry, Berry, Love, Star, Clover, Flower, Ribbon // [Format] Form: [Cream/Swirl] [Sweet] // [Example] Form: Ruby Swirl Ribbon";
            public static string Form_NonExist = "No special forms available.";
            public static string Form_Error = "This species is unknown, must be too QT for this world!";


            // Trivia 
            public static string Trivia_Win = "Winner, Winner, Chicken Dinner! Trivia Winner: {0}, Right Answer: {1}, Time Taken: {2} Seconds, WPM: {3}, Current Streak: {4} [+1000 Pcoins]";
            public static string Trivia_End_Winner_Log = "[Trivia] Trivia Ended! Winner: {0}, Correct Answer: {1} [+1000 Pcoins]";
            public static string Trivia_End_NoWinner = "[Trivia] Trivia Ended! Correct Answer: {0}, better luck next time folks!";
            public static string User_Request_Hint = "Requested a hint:";


            // Rewards
            public static string RewardPcoinsMessage = "{0} redeemed {1} UwU's and got rewarded with {2}!";
            public static string RewardTestMessage = "{0} Ok Boomer.";
            public static string RewardCparty = "{0} redeemed {1} and extended the Community Party by {2}";
            public static string RewardUserSuccess = "@{0} rewarded @{1} with {2} Pcoins!";
            public static string RewardUserFail = "@{0} failed to reward '{1}', user not found.";

            // Jackpot
            public static string Jackpot_BankAmount = "The jackpot bank has a total Pcoin amount of";
            public static string Jackpot_NotEnoughPcoins = "You don't have enough Pcoins to play jackpot! [{0}/5000 Pcoins]";
            public static string Jackpot_Winner = "You won the JACKPOT of";
            public static string Jackpot_Loser = "You lose! Better luck next time! [-5000 Pcoins]";
            public static string Jackpot_Cooldown = "You currently have a gamble cooldown! Remaining time:";


            // Gamble
            public static string Gamble_Winner = "Hail Hydra! You won! [+{0} Pcoins]";
            public static string Gamble_Loser = "mitsukiOof You lose! [-{0} Pcoins]";
            public static string Gamble_Coinflip_Winner = "4Head Hail Hydra! You won! [+{0} Pcoins]";
            public static string Gamble_Coinflip_Loser = "PJSalt mitsukiOof You lose! [-{0} Pcoins]";
            public static string Gamble_NotEnoughPcoins = "You don't have that many Pcoins!";
            public static string Gamble_Cooldown = "You currently have a gamble cooldown! Remaining time:";
            public static string Gamble_ToMuchInput = "You can't gamble over 50000 Pcoins!";


            // Raffle
            public static string RaffleNotEnoughPcoins = "You don't have enough Pcoins to enter the raffle! [{0}/5000 Pcoins]";
            public static string RaffleSuccess = "You entered the raffle! Total entries so far:";
            public static string RaffleTextBegin = "[Raffle] 💰 A raffle has started! Type '!raffle' to join and have a chance of winning all bets!";
            public static string RaffleOver = "[Raffle] 💰 Time's up! Total entries: {0}, the winner is: {1} and has won: {2} Pcoins!";
            public static string RaffleOverNoEntries = "[Raffle] Time's up! No winner because nobody joined! NotLikeThis";


            // Roulette
            public static string Roulette_Winner = "You won! Bet: {0}, Spin: {1} [+{2} Pcoins]";
            public static string Roulette_Loser = "You lose! Bet: {0}, Spin: {1} [-{2} Pcoins]";
            public static string Roulette_Negative = "You can't gamble a zero/negative amount!";
            public static string Roulette_Invalid = "@{0} Invalid command usage! !roulette [type] [amount]";

            // Daily Bonus
            public static string DailyBonus_Sub_Success = "You requested your daily subscriber bonus! [+10000 Pcoins]";
            public static string DailyBonus_Success = "You requested your daily bonus! [+5000 Pcoins]";
            public static string DailyBonus_AlreadyRequested = "You already requested your daily bonus! Daily will reset in {0} hours, {1} minutes, and {2} seconds (12 AM / 00:00 CET)";


            // Pcoins
            public static string PcoinsMessage = "{0} You currently have: {1} Pcoins, are Level: {2}, and have actively watched the stream for: {3} days, {4} hours, and {4} minutes.";

            //Stats
            public static string Stats = "[Stats] Pcoins: {0}, Trivia Wins: {1}, Longest Trivia Streak: {2}, Watch Time: {3} days, {4} hours, and {5} minutes, Wonder Trade Wins: {6}, Total Trades: {7}";
            public static string CheckStats = "[Stats] User: @{0}, Pcoins: {1}, Trivia Wins: {2}, Longest Trivia Streak: {3}, Watch Time: {4} days, {5} hours, and {6} minutes, Wonder Trade Wins: {7}, Total Trades: {8}";

            // Global Cooldown
            public static string GlobalCooldown_Success = "Updated the general trade cooldown to:";
            public static string GlobalCooldown_ToLow = "This trade cooldown is way too low, please apply a minimum of 10 minutes.";


            // Cparty
            public static string CPartyActive = "It's Community Party time! Extra customization is available for non-subs! mitsukiLUL Remaining Community Party trades:";
            public static string CpartyNotAktive = "There currently isn't a Community Party running! Cheer now to get 25 trades for 50 Bits!";


            // Sound play
            public static string SoundPlaySuccess = "Paid 5000 Pcoins to play the sound:";
            public static string SoundPlayNotEnoughPcoins = "You don't have enough Pcoins to play a sound! [{0}/5000 Pcoins]";
            public static string SoundPlayError = "We don't have that sound!";


            // TTS
            public static string TTS_Success = "Paid 5000 Pcoins to text-to-speech:";
            public static string TTS_MessageToLong = "Please don't spam!";
            public static string TTS_NotEnoughPcoins = "You don't have enough Pcoins to use TTS! [{0}/5000 Pcoins]";


            // Tax
            public static string TaxSuccess = "Paid 8% ({0} Pcoins) in taxes to the bank.";


            // Checkban
            public static string CheckBan_FriendcodeNotSaved = "This user hasn't saved a friend code yet.";
            public static string CheckBan_ListofUsers = "List of users with this friend code:";
            public static string CheckBan_NotBanned = "This user's friend code isn't banned.";

            public static string CheckBan_NNIDNotSaved = "This user hasn't saved a NNID yet.";
            public static string CheckBan_NNIDListofUsers = "List of users with this NNID:";
            public static string CheckBan_NNIDNotBanned = "This user's NNID isn't banned.";

            public static string CheckBan_NNIDFriendcodeNotBanned = "This user's friend code/NNID isn't banned.";


            // Leaderboard
            public static string Leaderboard_Trivia = "Trivia Leaderboard: ";
            public static string Leaderboard_GTS = "GTS / Link Trade Leaderboard: ";
            public static string Leaderboard_Wondertrade = "Wonder Trade Leaderboard: ";
            public static string Leaderboard_Level_Watchtime = "Level / Watch Time Leaderboard: ";
            public static string Leaderboard_Pcoins = "Pcoin Leaderboard: ";


            // Current Song / Skip Song
            public static string CurrentSong = "Current song: {0} - {1}";
            public static string SkipSong = "Skipped song, now playing: {0} - {1}";


            // Follow
            public static string New_Follower = "New follower detected: {0}, hope you enjoy our stream!";


            // Trivia Bans
            public static string TriviaBan_Success = "{0} has been timed out from trivia for {1} minutes!";
            public static string TriviaBan_UserNotFound = "User not found.";
            public static string TriviaBan_RemainingTime = "@{0} You are currently timed out from trivia, you can do trivia again in {1} hours, {2} minutes, and {3} seconds.";

            public static string TriviaUnBan_Success = "Removed the trivia timeout for user: {0}";
            public static string TriviaUnBan_UserNotBanned = "{0} isn't timed out from trivia.";
            public static string TriviaUnBan_UserNotFound = "User not found.";

            // Queue
            public static string Queue_SubSuccess = "{0} The sub queue currently has: {1} people, your position: {2}/{3}, estimated wait time: {4} hours, {5} minutes, and {6} seconds.";
            public static string Queue_SubSQLFlood = "{0} The sub queue currently has: {1} people, you are not in the sub queue.";
            public static string Queue_Success = "{0} The queue currently has: {1} people, your position: {2}/{3}, estimated wait time: {4} hours, {5} minutes, and {6} seconds.";
            public static string Queue_SQLFlood = "{0} The queue currently has: {1} people, you are not in the queue.";
            public static string Queue_All = "{0} The queue currently has a total of: {1} people.";
            public static string Queue_NonSubSuccess = "{0} The queue currently has: {1} people.";

            // Every 5min Random Text
            public static List<string> SpamMessages = new List<string> {
                "Join our Discord: mitsukiLUL https://discord.gg/5mdVKq9 mitsukiWink",
                "Follow us on Twitter: https://twitter.com/ThatChrisWhite mitsukiSmug",
                "Win the trivia to earn some sweet Pcoins!",
                "Friendly reminder, Mega Stones and TrainerID customizations are sub-only, so don't wait and sub today with Prime Gaming for free! mitsukiHappy",
                "This stream will always be updated and improved! Enjoy our future projects and updates! mitsukiWoah",
                "What did you guys win from Wonder Trade? Some sweet mythical Pokémon from us? Don't be shy and spread the love in chat! mitsukiKiss",
                "Friendly reminder, mythical Pokémon can't be requested from the Gen 7 (SUMO/USUM) GTS trades! mitsukiAngry",
                "You can cheer Bits to give non-subs extra customizations! 50 Bits = 25 cparty trades for non-subs, first come first served! mitsukiOof",
                "[SUBS ONLY] Use '!unlockdetails' and '!lockdetails' for un/locking your TID/SID!",
                "Have you found a bug/glitch and want to tell us? Post it in the #support channel in our Discord server and it will be fixed :)",
                "If you're stuck in the queue, use '!canceltrade' to remove yourself from the queue, however this command only works if you've been stuck in the queue for at least 15 minutes!",
                "Remember to use the correct command for your trade system: !tradeORAS (XY/ORAS), !trade (SUMO/USUM), !strade (SWSH), !tradeBDSP (BDSP)",
                "———————————————————————— TwitchVotes You have been gifted a subscription. Type !dad to activate————————————————————————"
            };
        }


        public static class HelpCommandsStrings
        {
            public static string TradeHelp6 = "[XY/ORAS] 1) Save your 12-digit 3DS friend code using '!savefc ####-####-####', 2) Deposit a Pokémon in the GTS leaving the Gender and Level set to 'Any', 3) Request a trade using '!tradeORAS Deposit: [Pokémon Deposited]', 4) Wait for MitsukiBot to say your Pokémon has been traded!";
            public static string TradeHelp7 = "[SUMO/USUM] 1) Save your 12-digit 3DS friend code using '!savefc ####-####-####', 2) Deposit a Pokémon in the GTS leaving the Gender and Level set to 'Any', 3) Request a trade using '!trade Deposit: [Pokémon Deposited]', 4) Wait for MitsukiBot to say your Pokémon has been traded! (MYTHICAL POKÉMON CAN'T BE REQUESTED FROM THE GEN 7 GTS TRADES!)";
            public static string TradeHelpSWSH = "[SWSH] 1) Save a custom 8-digit Link Code using '!setcode ####-####', 2) Request a trade using '!strade Request: [Pokémon Wanted]', 3) Search with your saved Link Code!";
            public static string TradeHelpBDSP = "[BDSP] 1) Save a custom 8-digit Link Code using '!setcode ####-####', 2) Request a trade using '!tradeBDSP Request: [Pokémon Wanted]', 3) Enter the Global Room with your saved Link Code, 4) Wait for the bot to appear in the center of the room, 5) Talk to the bot after it calls for a trade!";

            public static string Error = "Specify what error you're getting: '!help union' for BDSP Union Room, '!help link' for SWSH Link Trade, '!help gts' for Gen 6/7 GTS, '!help invalid' for invalid customizations, or ask for help in the #support channel in our Discord server!";
            public static string ErrorUnion = "[BDSP] 1) Using Global Room?, 2) Searching with saved Link Code? (Global Room -> Yes, with a Link Code), 3) Do not change your Link Code after requesting a trade, 4) Try saving a new Link Code, 5) Try restarting your Switch";
            public static string ErrorLink = "[SWSH] 1) Connected to the Internet? (Y-Comm -> (+) Connect to the Internet), 2) Searching with saved Link Code? (Link Trade -> Set Link Code), 3) Do not change your Link Code after requesting a trade, 4) Try saving a new Link Code, 5) Try restarting your Switch";
            public static string ErrorGTS = "[3DS] 1) Correct friend code saved? ('!myfc'), 2) Correct trade command used? ('!trade' for Gen 7, '!tradeORAS' for Gen 6), 3) Correct Pokémon specified in 'Deposit: [Pokémon]' command? (Pokémon deposited, not Pokémon wanted), 4) Gender and Level in GTS left at default settings? ('Any' or fixed Gender), 5) Deposited Trubbish or specified deposit Pokémon if using Showdown set?, 6) Can't request mythical Pokémon in Gen 7! ('!help mythicals7')";
            public static string ErrorInvalid = "If your customizations are not valid, the bot will cancel the trade and remove you from the queue. You can try to fix your command in the #command_testing channel or ask for help in the #support channel in our Discord server!";

            public static string Mythicals = "Specify what game you're on: '!help mythicals8b' for BDSP, '!help mythicals8' for SWSH, '!help mythicals7' for SUMO/USUM, '!help mythicals6' for XY/ORAS, or check this link for a list of mythical Pokémon: https://www.serebii.net/pokemon/legendary.shtml#mythical";
            public static string Mythicals6 = "[XY/ORAS] Mythical Pokémon can be requested from the Gen 6 GTS trades as long as the customizations are for a mythical event distributed in Gen 6.";
            public static string Mythicals7 = "[SUMO/USUM] Mythical Pokémon CANNOT be requested from the Gen 7 GTS trades: Mew, Celebi, Jirachi, Deoxys, Manaphy, Darkrai, Shaymin, Arceus, Victini, Keldeo, Meloetta, Genesect, Diancie, Hoopa, Volcanion, Magearna, Marshadow, Zeraora";
            public static string MythicalsSWSH = "[SWSH] Mythical Pokémon can be requested from the SWSH link trades as long as they are in the game // Mythical Pokémon in SWSH: Mew, Celebi, Jirachi, Victini, Keldeo, Genesect, Diancie, Volcanion, Magearna, Marshadow, Zeraora, Meltan, Melmetal, Zarude";
            public static string MythicalsBDSP = "[BDSP] Mythical Pokémon can be requested from the BDSP Union Room trades as long as they are in the game // Mythical Pokémon currently available in BDSP: Mew, Jirachi, Phione, Manaphy (all shiny locked)";

            public static string Cooldown = "Non-subs have a {0}-min cooldown between trades, check the time remaining on your cooldown using '!cd', pay 5000 Pcoins to skip your cooldown using '!cap'";
            public static string Cparty = "Community Party is activated whenever someone cheers Bits and allows non-subs to use extra customizations (OT, Event, Event_ID, Pokerus, Ribbons, Mark, Language, Origin), check if a cparty is active and the number of remaining trades using '!cparty'";
            public static string Deposit = "[3DS] The 'Deposit: [Pokémon]' command tells the bot what Pokémon to search for in the GTS, make sure to put the name of the Pokémon you left in the GTS, NOT the Pokémon you want to receive!";
            public static string Eggs = "[SUBS ONLY] [SWSH/BDSP] Eggs can be requested on SWSH/BDSP by adding 'IsEgg: Yes' to your trade command // Supported egg customizations: IsShiny, Gender, Ball, Ability, Nature, Moves, IVs, Form, Pokerus, Language // Move order: 1) Moves learned at level one, 2) Moves learned via level up, 3) Egg moves from parents, 4) Volt Tackle (Pichu only)";
            public static string Events = "[CPARTY/SUBS ONLY] Event Pokémon can be requested by adding 'Event: Yes, OT: [Event OT]' to your trade command (replace [Event OT] with the actual OT of the event) // Event database: https://www.serebii.net/events/";
            public static string Format = "Deposit: xxx, Request: xxx, Form: xxx, Gmax: xxx, IsShiny: xxx, Gender: xxx, Nickname: xxx, Ball: xxx, Level: xxx, Item: xxx, Ability: xxx, Nature: xxx, Move1: xxx, Move2: xxx, Move3: xxx, Move4: xxx, EV_HP: xxx, EV_ATK: xxx, EV_DEF: xxx, EV_SPA: xxx, EV_SPD: xxx, EV_SPE: xxx, etc.";
            public static string FriendCode = "[3DS] How to find your friend code: Select the friend list icon (orange smiley) on the HOME Menu, your 12-digit friend code can be found at the bottom of your friend card (identified by a gold crown)";
            public static string Language = "List of languages: JPN/Japanese, ENG/English, FRE/French, ITA/Italian, GER/German, ESP/Spanish, KOR/Korean, CHS/ChineseS, CHT/ChineseT";
            public static string Marks = "[SWSH] List of marks: https://www.serebii.net/swordshield/marks.shtml";
            public static string Origin = "List of origins: Red, Blue, Yellow, Green, Gold, Silver, Crystal, Ruby, Sapphire, Emerald, Fire Red, Leaf Green, Col, XD, Diamond, Pearl, Platinum, Heart Gold, Soul Silver, Black, White, Black 2, White 2, X, Y, Omega Ruby, Alpha Sapphire, Sun, Moon, Ultra Sun, Ultra Moon, LGP, LGE, Sword, Shield, Brilliant Diamond, Shining Pearl, GO";
            public static string ShinyState = "Requested Pokémon are shiny by default unless shiny locked or only shiny via event, check this link for a list of shiny locked Pokémon: https://www.serebii.net/games/shiny.shtml";
            public static string Showdown = "Showdown/Smogon sets are supported using this format: '!tradeORAS/!trade/!strade/!tradeBDSP [Showdown set]' // 'Deposit: xxx' can be added to specify a deposit Pokémon for Gen 6/7 GTS (defaults to Trubbish if deposit not specified)";
            public static string Sub = "Sub perks: no trade cooldown, trade priority, own trainer details on requested Pokémon, Mega Stones via GTS (Gen 6/7), eggs via Link Trade (Gen 8), sub-only chat commands";
            public static string Takeown = "[SUBS ONLY] 1) '!unlockdetails', 2) Request a trade and send the bot a Pokémon caught/hatched by you, 3) '!trainer' to verify your IGN and TrainerID are correct, 4) '!lockdetails', 5) Add 'TakeOwn: Yes' to your trade command to apply your trainer details to requested Pokémon!";
            public static string WonderTrade = "[3DS] Trade when the countdown timer from MitsukiBot says 'Go Wonder Trade!' to try your luck at winning a mythical Pokémon!";

            public static string PCoins = "Pcoins are this stream's currency, check your Pcoin amount using '!pcoins', pay 5000 Pcoins to skip your trade cooldown using '!cap', give Pcoins to other viewers using '!give [username] [amount]', and earn Pcoins from the daily bonus (!daily), gambling (!gamble, !bandit, !raffle, !jackpot, !roulette), trivia (1000 Pcoins per win), or by just being in chat!";
            public static string Raffle = "Raffle happens every 10 minutes and gives you the chance to win the total Pcoins from all the entries, pay 5000 Pcoins to enter using '!raffle'";
            public static string Bandit = "Bandit/slots multiplies your gamble if you match 3 emotes, try your luck using '!bandit ###' // Allowed gamble amounts: 1-50000 | quarter | half | all // Multipliers: mitsukiWill (20x) | mitsukiLick (10x) | mitsukiLUL (8x) | mitsukiWhat (6x) | mitsukiFlirt (4x) | mitsukiThink (2x)";
            public static string Gamble = "Gamble/coinflip gives you a 50/50 chance to double your gamble if you win, try your luck using '!gamble ###' // Allowed gamble amounts: 1-50000 | quarter | half | all";
            public static string Jackpot = "Jackpot gives you a ~1% chance to win a large prize (500K+ Pcoins), pay 5000 Pcoins to try your luck using '!jackpot', check the prize amount using '!bank'";
            public static string Roulette = "Roulette multiplies your bet if it matches the spin, place a bet using '!roulette [type] [amount]' // Allowed bet amounts: 1-50000 | quarter | half | all // Bet types: black/red (2x) | even/odd (2x) | high/low (2x) | first/second/third (3x) | 0-36 (36x)";
            public static string Sounds = "[SUBS ONLY] List of sounds: {0}.";
            public static string Trivia = "Trivia happens every 2 minutes and gives you 1000 Pcoins if you guess the correct answer first, get a hint if you're stuck using '!hint'";

            public static string FormList = "List of available forms: https://bit.ly/2OYRzUm";
            public static string CommandList = "List of available commands: https://bit.ly/2m9qcwN";

            public static string Options = "Help options: [Trading] gen6, gen7, swsh, bdsp, cooldown, cparty, error, friendcode, mythicals, sub, wondertrade // [Customizations] commands, format, showdown, deposit, eggs, events, forms, language, marks, origin, shiny, takeown // [Pcoins] pcoins, bandit, gamble, jackpot, raffle, roulette, sounds, trivia";
            public static string InvalidArgsMessage = "Specify what help you're looking for: '!help bdsp' for BDSP Union Room, '!help swsh' for SWSH Link Trade, '!help gen7' for SUMO/USUM GTS, '!help gen6' for XY/ORAS GTS, '!help options' for other help options, or ask for help in the #support channel in our Discord server!";
        }

        public static class RegularTextCommands
        {
            public static string Info = "The stream runs 24/7 and offers Pokémon trades for XY/ORAS, SUMO/USUM, SWSH, and BDSP! Type !help for more info on requesting Pokémon!";
            public static string ShinyLockedPokemon = "Shiny locked Pokémon: Cosmog, Cosmoem, Eternatus, Kubfu, Urshifu, Articuno-Galar, Zapdos-Galar, Moltres-Galar, Glastrier, Spectrier, Calyrex, Victini, Keldeo, Meloetta, Hoopa, Volcanion, Magearna, Marshadow, Zarude (https://www.serebii.net/games/shiny.shtml)";
            public static string UnobtainablePokemon7 = "Mythical Pokémon: Mew, Celebi, Jirachi, Deoxys, Phione, Manaphy, Darkrai, Shaymin, Arceus, Victini, Keldeo, Meloetta, Genesect, Diancie, Hoopa, Volcanion, Magearna, Marshadow, Zeraora, Meltan, Melmetal, Zarude (https://www.serebii.net/pokemon/legendary.shtml#mythical)";
            public static string Hype = "SUB HYPE mitsukiFlirt mitsukiFlirt mitsukiFlirt mitsukiFlirt mitsukiFlirt mitsukiFlirt mitsukiFlirt mitsukiFlirt mitsukiFlirt mitsukiFlirt mitsukiFlirt mitsukiFlirt mitsukiFlirt ";
            public static string CommandsListURL = "List of available commands: https://bit.ly/2m9qcwN";
            public static string RulesURL = "Stream rules: https://bit.ly/3wDHp00";
            public static string FormListURL = "List of available forms: https://bit.ly/2OYRzUm";
            public static string TwitterURL = "Twitter account: https://twitter.com/ThatChrisWhite";
            public static string DiscordURL = "Discord server: https://discordapp.com/invite/5mdVKq9";
            public static string SubscribeMessage = "You can support us with only $4.99 and gain awesome subscriber-only perks! (Check '!help sub' for a list of perks) - https://www.twitch.tv/products/mitsuki_tv/ticket - If you have Amazon Prime it's completely free (or a 30-day free trial) - https://twitch.amazon.com/prime";
            public static string FreeTrialSub = "Start your 30-day free trial with Amazon Prime - https://twitch.amazon.com/prime";
            public static string BigShaq = "The ting goes skrrrahh, PAP, PAP, ka-ka-ka, Skidiki-pap-pap-pap. QUICK MATH, SKRRRAHH, MANS NOT HOT, No Ketchup, just sauce.";
            public static string PoGoFriendcode = "Add me on Pokémon GO! Friend code: 3816-5046-0159";
            public static string ClaimCommandMessage = $"/me MitsukiBot gifted a Tier 1337 Subscription to @SouthrnJedi!";
            public static string Hungry = "You should try {0} with {1} and {2}!";
        }
    }
}