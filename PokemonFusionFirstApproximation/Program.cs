using System;
using System.Runtime.CompilerServices;

namespace PokemonFusionFirstApproximation
{
    class Program
    {
        static void Main(string[] args)
        {

            OwnedPokemon testFreak = new OwnedPokemon(dB: new DexPokemon(DatabasePokemon.Mewtwo, DatabasePokemon.Omastar), 1);
            Console.WriteLine(testFreak.getName());
            Console.WriteLine(testFreak.getType());
            
        }
    }
}
