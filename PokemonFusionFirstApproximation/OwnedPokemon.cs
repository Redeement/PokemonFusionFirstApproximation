using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace PokemonFusionFirstApproximation
{
    class OwnedPokemon
    {
        BasePokemonMove[] learnedMoves = new BasePokemonMove[4];
        int level;
        DexPokemon dexBase;

        public OwnedPokemon(DexPokemon dB, int lvl)
        {
            dexBase = dB;
            level = lvl;
        }
    }
}
