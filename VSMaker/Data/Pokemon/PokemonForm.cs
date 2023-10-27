using VSMaker.CommonFunctions;

namespace VSMaker.Data
{
    public static class PokemonForms
    {
        //Vanilla Pokemon Forms
        public const int Burmy = 412;
        public const int Pichu = 172;
        public const int Castform = 351;
        public const int Cherrim = 421;
        public const int Deoxys = 386;
        public const int Gastrodon = 423;
        public const int Girantina = 487;
        public const int Rotom = 479;
        public const int Shaymin = 495;
        public const int Shellos = 422;
        public const int Unown = 201;
        public const int Wormadam = 413;

        //HG Engine Expanded Forms
        public const int Kyogre = 382;
        public const int Groudon = 383;
        public const int Rattata = 19;
        public const int Raticate = 20;

        public static List<PokemonForm> GetPokemonForms(int pokemonId, bool hgEngine)
        {
            return pokemonId switch
            {
                Pichu => RomInfo.gameFamily == RomInfo.gFamEnum.HGSS ? new List<PokemonForm>
                {
                    new PokemonForm{PokemonId = pokemonId, FormId = 0, Description = "Normal", SpeciesId = 172},
                    new PokemonForm{PokemonId = pokemonId, FormId = 1, Description = "Spiky-Eared", SpeciesId = 172 },
                }
                : new List<PokemonForm>
                 {
                    new PokemonForm{PokemonId = pokemonId, FormId = 0, Description = "Default", SpeciesId = pokemonId}
                 },
                Deoxys => new List<PokemonForm>
                {
                    new PokemonForm{PokemonId = pokemonId, FormId = 0, Description = "Normal", SpeciesId = 386},
                    new PokemonForm{PokemonId = pokemonId, FormId = 1, Description = "Attack", SpeciesId = 496 },
                    new PokemonForm{PokemonId = pokemonId, FormId = 2, Description = "Defense", SpeciesId = 497},
                    new PokemonForm{PokemonId = pokemonId, FormId = 3, Description = "Speed", SpeciesId = 498},
                },
                Unown => new List<PokemonForm>
                {
                    new PokemonForm{PokemonId = pokemonId, FormId = 0, Description = "A", SpeciesId = 499},
                    new PokemonForm{PokemonId = pokemonId, FormId = 1, Description = "B", SpeciesId = 500},
                    new PokemonForm{PokemonId = pokemonId, FormId = 2, Description = "C", SpeciesId = 501},
                    new PokemonForm{PokemonId = pokemonId, FormId = 3, Description = "D", SpeciesId = 502},
                    new PokemonForm{PokemonId = pokemonId, FormId = 4, Description = "E", SpeciesId = 503},
                    new PokemonForm{PokemonId = pokemonId, FormId = 5, Description = "F", SpeciesId = 504},
                    new PokemonForm{PokemonId = pokemonId, FormId = 6, Description = "G", SpeciesId = 505},
                    new PokemonForm{PokemonId = pokemonId, FormId = 7, Description = "H", SpeciesId = 506},
                    new PokemonForm{PokemonId = pokemonId, FormId = 8, Description = "I", SpeciesId = 507},
                    new PokemonForm{PokemonId = pokemonId, FormId = 9, Description = "J", SpeciesId = 508},
                    new PokemonForm{PokemonId = pokemonId, FormId = 10, Description = "K", SpeciesId = 509},
                    new PokemonForm{PokemonId = pokemonId, FormId = 11, Description = "L", SpeciesId = 510},
                    new PokemonForm{PokemonId = pokemonId, FormId = 12, Description = "M", SpeciesId = 511},
                    new PokemonForm{PokemonId = pokemonId, FormId = 13, Description = "N", SpeciesId = 512},
                    new PokemonForm{PokemonId = pokemonId, FormId = 14, Description = "O", SpeciesId = 513},
                    new PokemonForm{PokemonId = pokemonId, FormId = 15, Description = "P", SpeciesId = 514},
                    new PokemonForm{PokemonId = pokemonId, FormId = 16, Description = "Q", SpeciesId = 515},
                    new PokemonForm{PokemonId = pokemonId, FormId = 17, Description = "R", SpeciesId = 516},
                    new PokemonForm{PokemonId = pokemonId, FormId = 18, Description = "S", SpeciesId = 517},
                    new PokemonForm{PokemonId = pokemonId, FormId = 19, Description = "T", SpeciesId = 518},
                    new PokemonForm{PokemonId = pokemonId, FormId = 20, Description = "U", SpeciesId = 519},
                    new PokemonForm{PokemonId = pokemonId, FormId = 21, Description = "V", SpeciesId = 520},
                    new PokemonForm{PokemonId = pokemonId, FormId = 22, Description = "W", SpeciesId = 521},
                    new PokemonForm{PokemonId = pokemonId, FormId = 23, Description = "X", SpeciesId = 522},
                    new PokemonForm{PokemonId = pokemonId, FormId = 24, Description = "Y", SpeciesId = 523},
                    new PokemonForm{PokemonId = pokemonId, FormId = 25, Description = "Z", SpeciesId = 524},
                    new PokemonForm{PokemonId = pokemonId, FormId = 26, Description = "!", SpeciesId = 525},
                    new PokemonForm{PokemonId = pokemonId, FormId = 27, Description = "?", SpeciesId = 526},
                },
                Burmy => new List<PokemonForm>
                {
                    new PokemonForm{PokemonId = pokemonId, FormId = 0, Description = "Plant Cloak", SpeciesId = 412},
                    new PokemonForm{PokemonId = pokemonId, FormId = 1, Description = "Sandy Cloak", SpeciesId = 527},
                    new PokemonForm{PokemonId = pokemonId, FormId = 2, Description = "Trash Cloak", SpeciesId = 528},
                },
                Wormadam => new List<PokemonForm>
                {
                    new PokemonForm{PokemonId = pokemonId, FormId = 0, Description = "Plant Cloak", SpeciesId = 413},
                    new PokemonForm{PokemonId = pokemonId, FormId = 1, Description = "Sandy Cloak", SpeciesId = 529},
                    new PokemonForm{PokemonId = pokemonId, FormId = 2, Description = "Trash Cloak", SpeciesId = 530},
                },
                Shellos => new List<PokemonForm>
                {
                    new PokemonForm{PokemonId = pokemonId, FormId = 0, Description = "West Coast", SpeciesId = 422},
                    new PokemonForm{PokemonId = pokemonId, FormId = 1, Description = "East Coast", SpeciesId = 531},
                },
                Gastrodon => new List<PokemonForm>
                {
                    new PokemonForm{PokemonId = pokemonId, FormId = 0, Description = "West Coast", SpeciesId = 423},
                    new PokemonForm{PokemonId = pokemonId, FormId = 1, Description = "East Coast", SpeciesId = 532},
                },
                Girantina => new List<PokemonForm>
                {
                    new PokemonForm{PokemonId = pokemonId, FormId = 0, Description = "Alternate", SpeciesId = 487},
                    new PokemonForm{PokemonId = pokemonId, FormId = 1, Description = "Origin", SpeciesId = 533},
                },
                Shaymin => new List<PokemonForm>
                {
                    new PokemonForm{PokemonId = pokemonId, FormId = 0, Description = "Land", SpeciesId = 495},
                    new PokemonForm{PokemonId = pokemonId, FormId = 1, Description = "Sky", SpeciesId = 534},
                },
                Rotom => new List<PokemonForm>
                {
                    new PokemonForm{PokemonId = pokemonId, FormId = 0, Description = "Normal", SpeciesId = 479},
                    new PokemonForm{PokemonId = pokemonId, FormId = 1, Description = "Heat", SpeciesId = 535},
                    new PokemonForm{PokemonId = pokemonId, FormId = 2, Description = "Fridge", SpeciesId = 536},
                    new PokemonForm{PokemonId = pokemonId, FormId = 3, Description = "Wash", SpeciesId = 537},
                    new PokemonForm{PokemonId = pokemonId, FormId = 4, Description = "Fan", SpeciesId = 538},
                    new PokemonForm{PokemonId = pokemonId, FormId = 5, Description = "Lawnmower", SpeciesId = 539},
                },
                Castform => new List<PokemonForm>
                {
                    new PokemonForm{PokemonId = pokemonId, FormId = 0, Description = "Normal", SpeciesId = 351},
                    new PokemonForm{PokemonId = pokemonId, FormId = 1, Description = "Sun", SpeciesId = 540},
                    new PokemonForm{PokemonId = pokemonId, FormId = 2, Description = "Rain", SpeciesId = 541},
                    new PokemonForm{PokemonId = pokemonId, FormId = 3, Description = "Snow", SpeciesId = 542},
                },
                Cherrim => new List<PokemonForm>
                {
                    new PokemonForm{PokemonId = pokemonId, FormId = 0, Description = "Overcast", SpeciesId = 421},
                    new PokemonForm{PokemonId = pokemonId, FormId = 1, Description = "Sun", SpeciesId = 543},
                },
                // HG Engine Expanded Forms
                Kyogre => new List<PokemonForm>
                {
                    new PokemonForm{PokemonId = pokemonId, FormId = 0, Description = "Normal", SpeciesId = 382},
                    new PokemonForm{PokemonId = pokemonId, FormId = 1, Description = "Primal", SpeciesId = 1118},
                },
                Groudon => new List<PokemonForm>
                {
                    new PokemonForm{PokemonId = pokemonId, FormId = 0, Description = "Normal", SpeciesId = 383},
                    new PokemonForm{PokemonId = pokemonId, FormId = 1, Description = "Primal", SpeciesId = 1119},
                },
                _ => new List<PokemonForm>
                {
                    new PokemonForm{PokemonId = pokemonId, FormId = 0, Description = "Default", SpeciesId = pokemonId}
                },
            };
        }
    }

    public class PokemonForm
    {
        public string Description { get; set; }
        public int FormId { get; set; }
        public int PokemonId { get; set; }
        public int SpeciesId { get; set; }
    }
}