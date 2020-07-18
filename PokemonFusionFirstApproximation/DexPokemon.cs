using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonFusionFirstApproximation
{
    class DexPokemon
    {
        public BasePokemon headComponent;
        public BasePokemon bodyComponent;
        public bool fused;


        public DexPokemon(BasePokemon hC, BasePokemon bC)
        {
            if(bC == DatabasePokemon.DefaultMon)
            {
                fused = false;
            }
            else
            {
                fused = true;
                bodyComponent = bC;
            }
            headComponent = hC;
        }

        public DexPokemon(BasePokemon hC) : this(hC, DatabasePokemon.DefaultMon)
        {

        }
    }
}
