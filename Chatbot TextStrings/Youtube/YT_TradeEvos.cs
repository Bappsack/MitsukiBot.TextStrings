using PKHeX.Core;
using System.Collections.Generic;

namespace Chatbot_TextStrings
{
    public static class YT_TradeEvos
    {
        public static bool CanTradeEvo(int species, int Form)
        {
            if (species is (int)Species.Slowpoke && Form != 0)
                return false;

            if (TradeEvolutions.Contains((Species)species))
                return true;
            return false;
        }
        public readonly static HashSet<Species> TradeEvolutions = new()
        {
            Species.Kadabra,
            Species.Machoke,
            Species.Graveler,
            Species.Haunter,
            Species.Poliwhirl,
            Species.Slowpoke,
            Species.Onix,
            Species.Scyther,
            Species.Seadra,
            Species.Porygon,
            Species.Feebas,
            Species.Rhydon,
            Species.Electabuzz,
            Species.Magmar,
            Species.Porygon2,
            Species.Dusclops,
            Species.Boldore,
            Species.Gurdurr,
            Species.Spritzee,
            Species.Swirlix,
            Species.Phantump,
            Species.Pumpkaboo,
        };

        public static int GetTradeEvoItem(Species species, int Form, bool BDSP)
        {
            return species switch
            {
                Species.Poliwhirl => 221,
                Species.Slowpoke when Form is 0 => 221,
                Species.Onix => 233,
                Species.Scyther => 233,
                Species.Seadra => 235,
                Species.Porygon => 252,
                Species.Porygon2 => 324,
                Species.Feebas when !BDSP => 537,
                Species.Rhydon => 321,
                Species.Electabuzz => 322,
                Species.Magmar => 323,
                Species.Dusclops => 325,
                Species.Spritzee => 647,
                Species.Swirlix => 646,
                _ => 0
            };
        }
    }
}
