using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSMaker.ROMFiles;

namespace VSMaker.Data
{
    public class Pokemon
    {
        public int PokemonId { get; set; }
        public string? PokemonName { get; set; }
        public short Level { get; set; }
        public int DV { get; set; }
        public int Gender { get; set; }
        public bool IsShiny { get; set; }
        public int IV { get; set; }
        public int Move1Id { get; set; }
        public int Move2Id { get; set; }
        public int Move3Id { get; set; }
        public int Move4Id { get; set; }
        public int NatureId { get; set; }
        public int FormId { get; set; }
        public int? Ability1 { get; set; }
        public int? Ability2 { get; set; }
        public int? SelectedAbility { get; set; }
        public int HeldItemId { get; set; }
    }

    /// <summary>
    /// A list of Pokemon names to exlude from DropDown Boxes - such as "Bad Egg" etc.
    /// </summary>
    public static class ExcludePokeNames
    {
        private static List<string> excludeNames;
        public static List<string> ExcludeNames
        {
            get => excludeNames ?? new List<string> 
            {
                "-----",
                "bad egg",
                "egg"
            };
            set => excludeNames = value;
        }
    }

    public static class PokemonForms
    {
        public enum Pikachu
        {
            Default = 172,
            Cosplay = 172,
            RockStar = 172,
            Belle = 172,
            PopStar = 172,
            Phd = 172,
            Libre = 172,
            OriginalCap = 172,
            HoennCap = 172,
            SinnohCap = 172,
            UnovaCap = 172,
            KalosCap = 172,
            AlolaCap = 172,
            PartnerCap = 172,
            WorldCap = 172,
        }
        public enum Tauros
        {
            Default = 172,
            PaldeanCombat = 172,
            PaldeanBlaze = 172,
            PaldeanAqua = 172,
        }
        public enum Meowth
        {
            Default = 172,
            SpikyEar = 172,
        }
        public enum Geodude
        {
            Default = 172,
        }
        public enum Graveller
        {
            Default = 172,
        }
        public enum Golem
        {
            Default = 172,
        }
        public enum Pichu
        {
            Default = 172,
        }
        public enum Unown
        {
            A = 201,
            B = 201,
            C = 201,
            D = 201,
            E = 201,
            F = 201,
            G = 201,
            H = 201,
            I = 201,
            J = 201,
            K = 201,
            L = 201,
            M = 201,
            N = 201,
            O = 201,
            P = 201,
            Q = 201,
            R = 201,
            S = 201,
            T = 201,
            U = 201,
            V = 201,
            W = 201,
            X = 201,
            Y = 201,
            Z = 201,
            Exclamation = 201,
            Question = 201,        
        }
        public enum Castform
        {
            Normal = 351,
            Sunny = 351,
            Rainy = 351,
            Snowy = 351,
        }

        public enum Kyogre
        {
            Default = 382,
            Primal = 386,
        }

        public enum Groudon
        {
            Default = 383,
            Primal = 386,
        }

        public enum Deoxys
        {
            Default = 386,
            Attack = 386,
            Defense = 386,
            Speed = 386,
        }
        public enum Burmy
        {
            PlantCloak = 412,
            SandyCloak = 412,
            TrashCloak = 412,
        }
        public enum Wormadam
        {
            PlantCloak = 413,
            SandyCloak = 413,
            TrashCloak = 413,
        }
        public enum Cherim
        {
            Overcast = 422,
            Sunshine = 422,
        }
        public enum Shellos
        {
            West = 422,
            East = 422,
        }
        public enum Gastrodon
        {
            West = 423,
            East = 423,
        }
        public enum Rotom
        {
            Default = 479,
            Heat = 479,
            Wash = 479,
            Frost = 479,
            Fan = 479,
            Mow = 479,
        }
        public enum Dialga
        {
            Default = 489,
            Origin = 491,
        }
        public enum Palkia
        {
            Default = 490,
            Origin = 491,
        }
        public enum Girantina
        {
            Default = 491,
            Origin = 491,
        }
        public enum Shaymin
        {
            Land = 492,
            Sky = 492,
        }
        public enum Arceus
        {
            Normal = 493,
            Fire = 493,
            Water = 493,
            Electric = 493,
            Grass = 493,
            Ice = 493,
            Fighting = 493,
            Poison = 493,
            Ground = 493,
            Flying = 493,
            Psychic = 493,
            Bug = 493,
            Rock = 493,
            Ghost = 493,
            Dragon = 493,
            Dark = 493,
            Steel = 493,
            Fairy = 493,
        }

        public enum Basculin
        {
            RedStripe = 492,
            BlueStrip = 492,
            WhiteStripe = 492,
        }

        public enum Darmanitan
        {
            Default = 492,
            Zen = 492,
            Galarian = 492,
            GalarianZen = 492,
        }

        public enum Deerling
        {
            Spring = 492,
            Summer = 492,
            Autumn = 492,
            Winter = 492,
        }

        public enum Sawsbuck
        {
            Spring = 492,
            Summer = 492,
            Autumn = 492,
            Winter = 492,
        }

        public enum Tornadus
        {
            Incarnate = 492,
            Therian = 492,
        }

        public enum Thundurus
        {
            Incarnate = 492,
            Therian = 492,
        }

        public enum Landorus
        {
            Incarnate = 492,
            Therian = 492,
        }

        public enum Enamorus
        {
            Incarnate = 492,
            Therian = 492,
        }

        public enum Kyurim
        {
            Default = 492,
            White = 492,
            Black = 492,
        }

        public enum Keldeo
        {
            Default = 492,
            Resolute = 492,
        }

        public enum Meloetta
        {
            Aria = 492,
            Pirouerette = 492,
        }
    }
}
