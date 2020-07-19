using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonFusionFirstApproximation
{
    static class DatabasePokemon
    {
        public static BasePokemon DefaultMon = new BasePokemon(n: "",
                                                               stats: new byte[] { 1, 1, 1, 1, 1, 1 },
                                                               ab: new string[] { "" },
                                                               lS: new Dictionary<int, BasePokemonMove> { { 10, DatabaseMoves.ancientpower } }
                                                               );

        public static BasePokemon Mewtwo = new BasePokemon(n: "Mewtwo",
                                                           stats: new byte[] { 100, 100, 100, 100, 100, 100 },
                                                           ab: new string[] { "pressure" },
                                                           lS: new Dictionary<int, BasePokemonMove> { { 10, DatabaseMoves.ancientpower } },
                                                           tP: RedLib.PokemonTypes.psychic
                                                           );

        public static BasePokemon Omastar = new BasePokemon(n: "Omastar",
                                                            stats: new byte[] { 90, 90, 90, 90, 90, 90 },
                                                            ab: new string[] { "battle armor", "swift swim" },
                                                            lS: new Dictionary<int, BasePokemonMove> { { 20, DatabaseMoves.ancientpower } },
                                                            tP: RedLib.PokemonTypes.water,
                                                            tS: RedLib.PokemonTypes.rock
                                                            );
    }
}
