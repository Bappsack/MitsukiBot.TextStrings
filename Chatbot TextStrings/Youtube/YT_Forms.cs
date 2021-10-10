using PKHeX.Core;
using System.Collections.Generic;
using System.IO;

namespace Chatbot_TextStrings
{
    public static class YT_Forms
    {

        /// <summary>
        /// Returns the Form Identifier and the Species Name.
        /// </summary>
        /// <param name="Nickname">Nicknamed Pokemon from User</param>
        /// <returns>Formated Nickname Identifier and PKHEX Formated Species Name</returns>
        public static (string, string, int) GetFormIdentifier(string Nickname)
        {
            try
            {
                var formFile = NicknameForms[Nickname];

                var pk = PKMConverter.GetPKMfromBytes(File.ReadAllBytes(formFile));

                return (Path.GetFileName(formFile).Replace(".pk8", string.Empty), ((Species)pk.Species).ToString(),pk.Form);
            }
            catch { return (null, null,-1); }
        }

        private static Dictionary<string, string> NicknameForms = new Dictionary<string, string>() {
          {
            "pikachuo",
            "c:\\pokemon8\\pikachu\\original.pk8"
          }, {
            "25o",
            "c:\\pokemon8\\pikachu\\original.pk8"
          }, {
            "pikachuh",
            "c:\\pokemon8\\pikachu\\hoenn.pk8"
          }, {
            "25h",
            "c:\\pokemon8\\pikachu\\hoenn.pk8"
          }, {
            "pikachus",
            "c:\\pokemon8\\pikachu\\sinnoh.pk8"
          }, {
            "25s",
            "c:\\pokemon8\\pikachu\\sinnoh.pk8"
          }, {
            "pikachuu",
            "c:\\pokemon8\\pikachu\\unova.pk8"
          }, {
            "25u",
            "c:\\pokemon8\\pikachu\\unova.pk8"
          }, {
            "pikachuk",
            "c:\\pokemon8\\pikachu\\kalos.pk8"
          }, {
            "25k",
            "c:\\pokemon8\\pikachu\\kalos.pk8"
          }, {
            "pikachua",
            "c:\\pokemon8\\pikachu\\alola.pk8"
          }, {
            "25a",
            "c:\\pokemon8\\pikachu\\alola.pk8"
          }, {
            "pikachup",
            "c:\\pokemon8\\pikachu\\partner.pk8"
          }, {
            "25p",
            "c:\\pokemon8\\pikachu\\partner.pk8"
          }, {
            "pikachuw",
            "c:\\pokemon8\\pikachu\\world.pk8"
          }, {
            "25w",
            "c:\\pokemon8\\pikachu\\world.pk8"
          }, {
            "raichua",
            "c:\\pokemon8\\raichu\\alola.pk8"
          }, {
            "26a",
            "c:\\pokemon8\\raichu\\alola.pk8"
          }, {
            "sandshrewa",
            "c:\\pokemon8\\sandshrew\\alola.pk8"
          }, {
            "27a",
            "c:\\pokemon8\\sandshrew\\alola.pk8"
          }, {
            "sandslasha",
            "c:\\pokemon8\\sandslash\\alola.pk8"
          }, {
            "28a",
            "c:\\pokemon8\\sandslash\\alola.pk8"
          }, {
            "vulpixa",
            "c:\\pokemon8\\vulpix\\alola.pk8"
          }, {
            "37a",
            "c:\\pokemon8\\vulpix\\alola.pk8"
          }, {
            "ninetalesa",
            "c:\\pokemon8\\ninetales\\alola.pk8"
          }, {
            "38a",
            "c:\\pokemon8\\ninetales\\alola.pk8"
          }, {
            "digletta",
            "c:\\pokemon8\\diglett\\alola.pk8"
          }, {
            "50a",
            "c:\\pokemon8\\diglett\\alola.pk8"
          }, {
            "dugtrioa",
            "c:\\pokemon8\\dugtrio\\alola.pk8"
          }, {
            "51a",
            "c:\\pokemon8\\dugtrio\\alola.pk8"
          }, {
            "meowtha",
            "c:\\pokemon8\\meowth\\alola.pk8"
          }, {
            "52a",
            "c:\\pokemon8\\meowth\\alola.pk8"
          }, {
            "meowthg",
            "c:\\pokemon8\\meowth\\galar.pk8"
          }, {
            "52g",
            "c:\\pokemon8\\meowth\\galar.pk8"
          }, {
            "persiana",
            "c:\\pokemon8\\persian\\alola.pk8"
          }, {
            "53a",
            "c:\\pokemon8\\persian\\alola.pk8"
          }, {
            "ponytag",
            "c:\\pokemon8\\ponyta\\galar.pk8"
          }, {
            "77g",
            "c:\\pokemon8\\ponyta\\galar.pk8"
          }, {
            "rapidashg",
            "c:\\pokemon8\\rapidash\\galar.pk8"
          }, {
            "78g",
            "c:\\pokemon8\\rapidash\\galar.pk8"
          }, {
            "slowpokeg",
            "c:\\pokemon8\\slowpoke\\galar.pk8"
          }, {
            "79g",
            "c:\\pokemon8\\slowpoke\\galar.pk8"
          }, {
            "slowbrog",
            "c:\\pokemon8\\slowbro\\galar.pk8"
          }, {
            "80g",
            "c:\\pokemon8\\slowbro\\galar.pk8"
          }, {
            "farfetchdg",
            "c:\\pokemon8\\farfetchd\\galar.pk8"
          }, {
            "83g",
            "c:\\pokemon8\\farfetchd\\galar.pk8"
          }, {
            "exeggutora",
            "c:\\pokemon8\\exeggutor\\alola.pk8"
          }, {
            "103a",
            "c:\\pokemon8\\exeggutor\\alola.pk8"
          }, {
            "marowaka",
            "c:\\pokemon8\\marowak\\alola.pk8"
          }, {
            "105a",
            "c:\\pokemon8\\marowak\\alola.pk8"
          }, {
            "weezingg",
            "c:\\pokemon8\\weezing\\galar.pk8"
          }, {
            "110g",
            "c:\\pokemon8\\weezing\\galar.pk8"
          }, {
            "mrmimeg",
            "c:\\pokemon8\\mrmime\\galar.pk8"
          }, {
            "122g",
            "c:\\pokemon8\\mrmime\\galar.pk8"
          }, {
            "articunog",
            "c:\\pokemon8\\articuno\\galar.pk8"
          }, {
            "144g",
            "c:\\pokemon8\\articuno\\galar.pk8"
          }, {
            "zapdosg",
            "c:\\pokemon8\\zapdos\\galar.pk8"
          }, {
            "145g",
            "c:\\pokemon8\\zapdos\\galar.pk8"
          }, {
            "moltresg",
            "c:\\pokemon8\\moltres\\galar.pk8"
          }, {
            "146g",
            "c:\\pokemon8\\moltres\\galar.pk8"
          }, {
            "slowkingg",
            "c:\\pokemon8\\slowking\\galar.pk8"
          }, {
            "199g",
            "c:\\pokemon8\\slowking\\galar.pk8"
          }, {
            "corsolag",
            "c:\\pokemon8\\corsola\\galar.pk8"
          }, {
            "222g",
            "c:\\pokemon8\\corsola\\galar.pk8"
          }, {
            "zigzagoong",
            "c:\\pokemon8\\zigzagoon\\galar.pk8"
          }, {
            "263g",
            "c:\\pokemon8\\zigzagoon\\galar.pk8"
          }, {
            "linooneg",
            "c:\\pokemon8\\linoone\\galar.pk8"
          }, {
            "264g",
            "c:\\pokemon8\\linoone\\galar.pk8"
          }, {
            "shellose",
            "c:\\pokemon8\\shellos\\east.pk8"
          }, {
            "422e",
            "c:\\pokemon8\\shellos\\east.pk8"
          }, {
            "shellosw",
            "c:\\pokemon8\\shellos\\west.pk8"
          }, {
            "422w",
            "c:\\pokemon8\\shellos\\west.pk8"
          }, {
            "gastrodone",
            "c:\\pokemon8\\gastrodon\\east.pk8"
          }, {
            "423e",
            "c:\\pokemon8\\gastrodon\\east.pk8"
          }, {
            "gastrodonw",
            "c:\\pokemon8\\gastrodon\\west.pk8"
          }, {
            "423w",
            "c:\\pokemon8\\gastrodon\\west.pk8"
          }, {
            "rotomh",
            "c:\\pokemon8\\rotom\\heat.pk8"
          }, {
            "479h",
            "c:\\pokemon8\\rotom\\heat.pk8"
          }, {
            "rotomw",
            "c:\\pokemon8\\rotom\\wash.pk8"
          }, {
            "479w",
            "c:\\pokemon8\\rotom\\wash.pk8"
          }, {
            "rotomfr",
            "c:\\pokemon8\\rotom\\frost.pk8"
          }, {
            "479fr",
            "c:\\pokemon8\\rotom\\frost.pk8"
          }, {
            "rotomfa",
            "c:\\pokemon8\\rotom\\fan.pk8"
          }, {
            "479fa",
            "c:\\pokemon8\\rotom\\fan.pk8"
          }, {
            "rotomm",
            "c:\\pokemon8\\rotom\\mow.pk8"
          }, {
            "479m",
            "c:\\pokemon8\\rotom\\mow.pk8"
          }, {
            "basculinr",
            "c:\\pokemon8\\basculin\\red.pk8"
          }, {
            "550r",
            "c:\\pokemon8\\basculin\\red.pk8"
          }, {
            "basculinb",
            "c:\\pokemon8\\basculin\\blue.pk8"
          }, {
            "550b",
            "c:\\pokemon8\\basculin\\blue.pk8"
          }, {
            "darumakag",
            "c:\\pokemon8\\darumaka\\galar.pk8"
          }, {
            "554g",
            "c:\\pokemon8\\darumaka\\galar.pk8"
          }, {
            "darmanitang",
            "c:\\pokemon8\\darmanitan\\galar.pk8"
          }, {
            "555g",
            "c:\\pokemon8\\darmanitan\\galar.pk8"
          }, {
            "yamaskg",
            "c:\\pokemon8\\yamask\\galar.pk8"
          }, {
            "562g",
            "c:\\pokemon8\\yamask\\galar.pk8"
          }, {
            "stunfiskg",
            "c:\\pokemon8\\stunfisk\\galar.pk8"
          }, {
            "618g",
            "c:\\pokemon8\\stunfisk\\galar.pk8"
          }, {
            "tornadusi",
            "c:\\pokemon8\\tornadus\\incarnate.pk8"
          }, {
            "641i",
            "c:\\pokemon8\\tornadus\\incarnate.pk8"
          }, {
            "tornadust",
            "c:\\pokemon8\\tornadus\\therian.pk8"
          }, {
            "641t",
            "c:\\pokemon8\\tornadus\\therian.pk8"
          }, {
            "thundurusi",
            "c:\\pokemon8\\thundurus\\incarnate.pk8"
          }, {
            "642i",
            "c:\\pokemon8\\thundurus\\incarnate.pk8"
          }, {
            "thundurust",
            "c:\\pokemon8\\thundurus\\therian.pk8"
          }, {
            "642t",
            "c:\\pokemon8\\thundurus\\therian.pk8"
          }, {
            "landorusi",
            "c:\\pokemon8\\landorus\\incarnate.pk8"
          }, {
            "645i",
            "c:\\pokemon8\\landorus\\incarnate.pk8"
          }, {
            "landorust",
            "c:\\pokemon8\\landorus\\therian.pk8"
          }, {
            "645t",
            "c:\\pokemon8\\landorus\\therian.pk8"
          }, {
            "pumpkaboosm",
            "c:\\pokemon8\\pumpkaboo\\small.pk8"
          }, {
            "710sm",
            "c:\\pokemon8\\pumpkaboo\\small.pk8"
          }, {
            "pumpkabooa",
            "c:\\pokemon8\\pumpkaboo\\average.pk8"
          }, {
            "710a",
            "c:\\pokemon8\\pumpkaboo\\average.pk8"
          }, {
            "pumpkabool",
            "c:\\pokemon8\\pumpkaboo\\large.pk8"
          }, {
            "710l",
            "c:\\pokemon8\\pumpkaboo\\large.pk8"
          }, {
            "pumpkaboosu",
            "c:\\pokemon8\\pumpkaboo\\super.pk8"
          }, {
            "710su",
            "c:\\pokemon8\\pumpkaboo\\super.pk8"
          }, {
            "gourgeistsm",
            "c:\\pokemon8\\gourgeist\\small.pk8"
          }, {
            "711sm",
            "c:\\pokemon8\\gourgeist\\small.pk8"
          }, {
            "gourgeista",
            "c:\\pokemon8\\gourgeist\\average.pk8"
          }, {
            "711a",
            "c:\\pokemon8\\gourgeist\\average.pk8"
          }, {
            "gourgeistl",
            "c:\\pokemon8\\gourgeist\\large.pk8"
          }, {
            "711l",
            "c:\\pokemon8\\gourgeist\\large.pk8"
          }, {
            "gourgeistsu",
            "c:\\pokemon8\\gourgeist\\super.pk8"
          }, {
            "711su",
            "c:\\pokemon8\\gourgeist\\super.pk8"
          }, {
            "zygarde1",
            "c:\\pokemon8\\zygarde\\10%.pk8"
          }, {
            "7181",
            "c:\\pokemon8\\zygarde\\10%.pk8"
          }, {
            "zygarde1c",
            "c:\\pokemon8\\zygarde\\10%-c.pk8"
          }, {
            "7181c",
            "c:\\pokemon8\\zygarde\\10%-c.pk8"
          }, {
            "zygarde5",
            "c:\\pokemon8\\zygarde\\50%.pk8"
          }, {
            "7185",
            "c:\\pokemon8\\zygarde\\50%.pk8"
          }, {
            "zygarde5c",
            "c:\\pokemon8\\zygarde\\50%-c.pk8"
          }, {
            "7185c",
            "c:\\pokemon8\\zygarde\\50%-c.pk8"
          }, {
            "rockruffd",
            "c:\\pokemon8\\rockruff\\dusk.pk8"
          }, {
            "744d",
            "c:\\pokemon8\\rockruff\\dusk.pk8"
          }, {
            "lycanrocmd",
            "c:\\pokemon8\\lycanroc\\midday.pk8"
          }, {
            "745md",
            "c:\\pokemon8\\lycanroc\\midday.pk8"
          }, {
            "lycanrocmn",
            "c:\\pokemon8\\lycanroc\\midnight.pk8"
          }, {
            "745mn",
            "c:\\pokemon8\\lycanroc\\midnight.pk8"
          }, {
            "lycanrocd",
            "c:\\pokemon8\\lycanroc\\dusk.pk8"
          }, {
            "745d",
            "c:\\pokemon8\\lycanroc\\dusk.pk8"
          }, {
            "magearnao",
            "c:\\pokemon8\\magearna\\original.pk8"
          }, {
            "801o",
            "c:\\pokemon8\\magearna\\original.pk8"
          }, {
            "toxtricitya",
            "c:\\pokemon8\\toxtricity\\amped.pk8"
          }, {
            "849a",
            "c:\\pokemon8\\toxtricity\\amped.pk8"
          }, {
            "toxtricityl",
            "c:\\pokemon8\\toxtricity\\low key.pk8"
          }, {
            "849l",
            "c:\\pokemon8\\toxtricity\\low key.pk8"
          }, {
            "sinisteap",
            "c:\\pokemon8\\sinistea\\phony.pk8"
          }, {
            "854p",
            "c:\\pokemon8\\sinistea\\phony.pk8"
          }, {
            "sinisteaa",
            "c:\\pokemon8\\sinistea\\antique.pk8"
          }, {
            "854a",
            "c:\\pokemon8\\sinistea\\antique.pk8"
          }, {
            "polteageistp",
            "c:\\pokemon8\\polteageist\\phony.pk8"
          }, {
            "855p",
            "c:\\pokemon8\\polteageist\\phony.pk8"
          }, {
            "polteageista",
            "c:\\pokemon8\\polteageist\\antique.pk8"
          }, {
            "855a",
            "c:\\pokemon8\\polteageist\\antique.pk8"
          }, {
            "urshifus",
            "c:\\pokemon8\\urshifu\\single strike.pk8"
          }, {
            "892s",
            "c:\\pokemon8\\urshifu\\single strike.pk8"
          }, {
            "urshifur",
            "c:\\pokemon8\\urshifu\\rapid strike.pk8"
          }, {
            "892r",
            "c:\\pokemon8\\urshifu\\rapid strike.pk8"
          }, {
            "zaruded",
            "c:\\pokemon8\\zarude\\dada.pk8"
          }, {
            "893d",
            "c:\\pokemon8\\zarude\\dada.pk8"
          }, {
            "alcremie1",
            "c:\\pokemon8\\alcremie\\vanilla cream strawberry.pk8"
          }, {
            "8691",
            "c:\\pokemon8\\alcremie\\vanilla cream strawberry.pk8"
          }, {
            "alcremie2",
            "c:\\pokemon8\\alcremie\\vanilla cream berry.pk8"
          }, {
            "8692",
            "c:\\pokemon8\\alcremie\\vanilla cream berry.pk8"
          }, {
            "alcremie3",
            "c:\\pokemon8\\alcremie\\vanilla cream love.pk8"
          }, {
            "8693",
            "c:\\pokemon8\\alcremie\\vanilla cream love.pk8"
          }, {
            "alcremie4",
            "c:\\pokemon8\\alcremie\\vanilla cream star.pk8"
          }, {
            "8694",
            "c:\\pokemon8\\alcremie\\vanilla cream star.pk8"
          }, {
            "alcremie5",
            "c:\\pokemon8\\alcremie\\vanilla cream clover.pk8"
          }, {
            "8695",
            "c:\\pokemon8\\alcremie\\vanilla cream clover.pk8"
          }, {
            "alcremie6",
            "c:\\pokemon8\\alcremie\\vanilla cream flower.pk8"
          }, {
            "8696",
            "c:\\pokemon8\\alcremie\\vanilla cream flower.pk8"
          }, {
            "alcremie7",
            "c:\\pokemon8\\alcremie\\vanilla cream ribbon.pk8"
          }, {
            "8697",
            "c:\\pokemon8\\alcremie\\vanilla cream ribbon.pk8"
          }, {
            "alcremie8",
            "c:\\pokemon8\\alcremie\\ruby cream strawberry.pk8"
          }, {
            "8698",
            "c:\\pokemon8\\alcremie\\ruby cream strawberry.pk8"
          }, {
            "alcremie9",
            "c:\\pokemon8\\alcremie\\ruby cream berry.pk8"
          }, {
            "8699",
            "c:\\pokemon8\\alcremie\\ruby cream berry.pk8"
          }, {
            "alcremie10",
            "c:\\pokemon8\\alcremie\\ruby cream love.pk8"
          }, {
            "86910",
            "c:\\pokemon8\\alcremie\\ruby cream love.pk8"
          }, {
            "alcremie11",
            "c:\\pokemon8\\alcremie\\ruby cream star.pk8"
          }, {
            "86911",
            "c:\\pokemon8\\alcremie\\ruby cream star.pk8"
          }, {
            "alcremie12",
            "c:\\pokemon8\\alcremie\\ruby cream clover.pk8"
          }, {
            "86912",
            "c:\\pokemon8\\alcremie\\ruby cream clover.pk8"
          }, {
            "alcremie13",
            "c:\\pokemon8\\alcremie\\ruby cream flower.pk8"
          }, {
            "86913",
            "c:\\pokemon8\\alcremie\\ruby cream flower.pk8"
          }, {
            "alcremie14",
            "c:\\pokemon8\\alcremie\\ruby cream ribbon.pk8"
          }, {
            "86914",
            "c:\\pokemon8\\alcremie\\ruby cream ribbon.pk8"
          }, {
            "alcremie15",
            "c:\\pokemon8\\alcremie\\matcha cream strawberry.pk8"
          }, {
            "86915",
            "c:\\pokemon8\\alcremie\\matcha cream strawberry.pk8"
          }, {
            "alcremie16",
            "c:\\pokemon8\\alcremie\\matcha cream berry.pk8"
          }, {
            "86916",
            "c:\\pokemon8\\alcremie\\matcha cream berry.pk8"
          }, {
            "alcremie17",
            "c:\\pokemon8\\alcremie\\matcha cream love.pk8"
          }, {
            "86917",
            "c:\\pokemon8\\alcremie\\matcha cream love.pk8"
          }, {
            "alcremie18",
            "c:\\pokemon8\\alcremie\\matcha cream star.pk8"
          }, {
            "86918",
            "c:\\pokemon8\\alcremie\\matcha cream star.pk8"
          }, {
            "alcremie19",
            "c:\\pokemon8\\alcremie\\matcha cream clover.pk8"
          }, {
            "86919",
            "c:\\pokemon8\\alcremie\\matcha cream clover.pk8"
          }, {
            "alcremie20",
            "c:\\pokemon8\\alcremie\\matcha cream flower.pk8"
          }, {
            "86920",
            "c:\\pokemon8\\alcremie\\matcha cream flower.pk8"
          }, {
            "alcremie21",
            "c:\\pokemon8\\alcremie\\matcha cream ribbon.pk8"
          }, {
            "86921",
            "c:\\pokemon8\\alcremie\\matcha cream ribbon.pk8"
          }, {
            "alcremie22",
            "c:\\pokemon8\\alcremie\\mint cream strawberry.pk8"
          }, {
            "86922",
            "c:\\pokemon8\\alcremie\\mint cream strawberry.pk8"
          }, {
            "alcremie23",
            "c:\\pokemon8\\alcremie\\mint cream berry.pk8"
          }, {
            "86923",
            "c:\\pokemon8\\alcremie\\mint cream berry.pk8"
          }, {
            "alcremie24",
            "c:\\pokemon8\\alcremie\\mint cream love.pk8"
          }, {
            "86924",
            "c:\\pokemon8\\alcremie\\mint cream love.pk8"
          }, {
            "alcremie25",
            "c:\\pokemon8\\alcremie\\mint cream star.pk8"
          }, {
            "86925",
            "c:\\pokemon8\\alcremie\\mint cream star.pk8"
          }, {
            "alcremie26",
            "c:\\pokemon8\\alcremie\\mint cream clover.pk8"
          }, {
            "86926",
            "c:\\pokemon8\\alcremie\\mint cream clover.pk8"
          }, {
            "alcremie27",
            "c:\\pokemon8\\alcremie\\mint cream flower.pk8"
          }, {
            "86927",
            "c:\\pokemon8\\alcremie\\mint cream flower.pk8"
          }, {
            "alcremie28",
            "c:\\pokemon8\\alcremie\\mint cream ribbon.pk8"
          }, {
            "86928",
            "c:\\pokemon8\\alcremie\\mint cream ribbon.pk8"
          }, {
            "alcremie29",
            "c:\\pokemon8\\alcremie\\lemon cream strawberry.pk8"
          }, {
            "86929",
            "c:\\pokemon8\\alcremie\\lemon cream strawberry.pk8"
          }, {
            "alcremie30",
            "c:\\pokemon8\\alcremie\\lemon cream berry.pk8"
          }, {
            "86930",
            "c:\\pokemon8\\alcremie\\lemon cream berry.pk8"
          }, {
            "alcremie31",
            "c:\\pokemon8\\alcremie\\lemon cream love.pk8"
          }, {
            "86931",
            "c:\\pokemon8\\alcremie\\lemon cream love.pk8"
          }, {
            "alcremie32",
            "c:\\pokemon8\\alcremie\\lemon cream star.pk8"
          }, {
            "86932",
            "c:\\pokemon8\\alcremie\\lemon cream star.pk8"
          }, {
            "alcremie33",
            "c:\\pokemon8\\alcremie\\lemon cream clover.pk8"
          }, {
            "86933",
            "c:\\pokemon8\\alcremie\\lemon cream clover.pk8"
          }, {
            "alcremie34",
            "c:\\pokemon8\\alcremie\\lemon cream flower.pk8"
          }, {
            "86934",
            "c:\\pokemon8\\alcremie\\lemon cream flower.pk8"
          }, {
            "alcremie35",
            "c:\\pokemon8\\alcremie\\lemon cream ribbon.pk8"
          }, {
            "86935",
            "c:\\pokemon8\\alcremie\\lemon cream ribbon.pk8"
          }, {
            "alcremie36",
            "c:\\pokemon8\\alcremie\\salted cream strawberry.pk8"
          }, {
            "86936",
            "c:\\pokemon8\\alcremie\\salted cream strawberry.pk8"
          }, {
            "alcremie37",
            "c:\\pokemon8\\alcremie\\salted cream berry.pk8"
          }, {
            "86937",
            "c:\\pokemon8\\alcremie\\salted cream berry.pk8"
          }, {
            "alcremie38",
            "c:\\pokemon8\\alcremie\\salted cream love.pk8"
          }, {
            "86938",
            "c:\\pokemon8\\alcremie\\salted cream love.pk8"
          }, {
            "alcremie39",
            "c:\\pokemon8\\alcremie\\salted cream star.pk8"
          }, {
            "86939",
            "c:\\pokemon8\\alcremie\\salted cream star.pk8"
          }, {
            "alcremie40",
            "c:\\pokemon8\\alcremie\\salted cream clover.pk8"
          }, {
            "86940",
            "c:\\pokemon8\\alcremie\\salted cream clover.pk8"
          }, {
            "alcremie41",
            "c:\\pokemon8\\alcremie\\salted cream flower.pk8"
          }, {
            "86941",
            "c:\\pokemon8\\alcremie\\salted cream flower.pk8"
          }, {
            "alcremie42",
            "c:\\pokemon8\\alcremie\\salted cream ribbon.pk8"
          }, {
            "86942",
            "c:\\pokemon8\\alcremie\\salted cream ribbon.pk8"
          }, {
            "alcremie43",
            "c:\\pokemon8\\alcremie\\ruby swirl strawberry.pk8"
          }, {
            "86943",
            "c:\\pokemon8\\alcremie\\ruby swirl strawberry.pk8"
          }, {
            "alcremie44",
            "c:\\pokemon8\\alcremie\\ruby swirl berry.pk8"
          }, {
            "86944",
            "c:\\pokemon8\\alcremie\\ruby swirl berry.pk8"
          }, {
            "alcremie45",
            "c:\\pokemon8\\alcremie\\ruby swirl love.pk8"
          }, {
            "86945",
            "c:\\pokemon8\\alcremie\\ruby swirl love.pk8"
          }, {
            "alcremie46",
            "c:\\pokemon8\\alcremie\\ruby swirl star.pk8"
          }, {
            "86946",
            "c:\\pokemon8\\alcremie\\ruby swirl star.pk8"
          }, {
            "alcremie47",
            "c:\\pokemon8\\alcremie\\ruby swirl clover.pk8"
          }, {
            "86947",
            "c:\\pokemon8\\alcremie\\ruby swirl clover.pk8"
          }, {
            "alcremie48",
            "c:\\pokemon8\\alcremie\\ruby swirl flower.pk8"
          }, {
            "86948",
            "c:\\pokemon8\\alcremie\\ruby swirl flower.pk8"
          }, {
            "alcremie49",
            "c:\\pokemon8\\alcremie\\ruby swirl ribbon.pk8"
          }, {
            "86949",
            "c:\\pokemon8\\alcremie\\ruby swirl ribbon.pk8"
          }, {
            "alcremie50",
            "c:\\pokemon8\\alcremie\\caramel swirl strawberry.pk8"
          }, {
            "86950",
            "c:\\pokemon8\\alcremie\\caramel swirl strawberry.pk8"
          }, {
            "alcremie51",
            "c:\\pokemon8\\alcremie\\caramel swirl berry.pk8"
          }, {
            "86951",
            "c:\\pokemon8\\alcremie\\caramel swirl berry.pk8"
          }, {
            "alcremie52",
            "c:\\pokemon8\\alcremie\\caramel swirl love.pk8"
          }, {
            "86952",
            "c:\\pokemon8\\alcremie\\caramel swirl love.pk8"
          }, {
            "alcremie53",
            "c:\\pokemon8\\alcremie\\caramel swirl star.pk8"
          }, {
            "86953",
            "c:\\pokemon8\\alcremie\\caramel swirl star.pk8"
          }, {
            "alcremie54",
            "c:\\pokemon8\\alcremie\\caramel swirl clover.pk8"
          }, {
            "86954",
            "c:\\pokemon8\\alcremie\\caramel swirl clover.pk8"
          }, {
            "alcremie55",
            "c:\\pokemon8\\alcremie\\caramel swirl flower.pk8"
          }, {
            "86955",
            "c:\\pokemon8\\alcremie\\caramel swirl flower.pk8"
          }, {
            "alcremie56",
            "c:\\pokemon8\\alcremie\\caramel swirl ribbon.pk8"
          }, {
            "86956",
            "c:\\pokemon8\\alcremie\\caramel swirl ribbon.pk8"
          }, {
            "alcremie57",
            "c:\\pokemon8\\alcremie\\rainbow swirl strawberry.pk8"
          }, {
            "86957",
            "c:\\pokemon8\\alcremie\\rainbow swirl strawberry.pk8"
          }, {
            "alcremie58",
            "c:\\pokemon8\\alcremie\\rainbow swirl berry.pk8"
          }, {
            "86958",
            "c:\\pokemon8\\alcremie\\rainbow swirl berry.pk8"
          }, {
            "alcremie59",
            "c:\\pokemon8\\alcremie\\rainbow swirl love.pk8"
          }, {
            "86959",
            "c:\\pokemon8\\alcremie\\rainbow swirl love.pk8"
          }, {
            "alcremie60",
            "c:\\pokemon8\\alcremie\\rainbow swirl star.pk8"
          }, {
            "86960",
            "c:\\pokemon8\\alcremie\\rainbow swirl star.pk8"
          }, {
            "alcremie61",
            "c:\\pokemon8\\alcremie\\rainbow swirl clover.pk8"
          }, {
            "86961",
            "c:\\pokemon8\\alcremie\\rainbow swirl clover.pk8"
          }, {
            "alcremie62",
            "c:\\pokemon8\\alcremie\\rainbow swirl flower.pk8"
          }, {
            "86962",
            "c:\\pokemon8\\alcremie\\rainbow swirl flower.pk8"
          }, {
            "alcremie63",
            "c:\\pokemon8\\alcremie\\rainbow swirl ribbon.pk8"
          }, {
            "86963",
            "c:\\pokemon8\\alcremie\\rainbow swirl ribbon.pk8"
          },

        };
    }
}
