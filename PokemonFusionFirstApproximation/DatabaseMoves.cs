using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonFusionFirstApproximation
{
    static class DatabaseMoves
    {
        static public BasePokemonMove ancientpower = new BasePokemonMove("AncientPower",
                                                                         RedLib.PokemonTypes.rock, 
                                                                         60, 
                                                                         RedLib.physicalSpecial.physical, 
                                                                         () => { Console.WriteLine($"Used ancientpower"); });
    }
}
