using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonFusionFirstApproximation
{
    class BasePokemon
    {
        public string NameFirst;
        public string NameSecond;
        public Tuple<RedLib.PokemonTypes, RedLib.PokemonTypes> types;
        public byte[] statistics;
        public string[] ability;
        public Dictionary<int,BasePokemonMove> learnSet;

        public BasePokemon(byte[] stats,
                           string[] ab,
                           Dictionary<int, BasePokemonMove> lS,
                           string nF = "",
                           string nS = "",
                           RedLib.PokemonTypes tP = RedLib.PokemonTypes.typeless,
                           RedLib.PokemonTypes tS = RedLib.PokemonTypes.typeless
                          )
        {

            NameFirst = nF;
            NameSecond = nS;
            types = new Tuple<RedLib.PokemonTypes, RedLib.PokemonTypes>( tP, tS );
            statistics = stats;
            ability = ab;
            learnSet = lS;

        }
    }
}
