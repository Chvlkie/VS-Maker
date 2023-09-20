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

        public int DV { get; set; }
        public int Gender { get; set; }
        public bool IsShiny { get; set; }
        public int IV { get; set; }
        public int Move1Id { get; set; }
        public int Move2Id { get; set; }
        public int Move3Id { get; set; }
        public int Move4Id { get; set; }
        public int NatureId { get; set; }
        public int PokemonForm { get; set; }
    }
}
