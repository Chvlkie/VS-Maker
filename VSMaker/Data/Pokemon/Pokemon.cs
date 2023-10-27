using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
