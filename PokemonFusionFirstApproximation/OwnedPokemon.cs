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

        public string getName()
        {
            string[] cNames = { dexBase.headComponent.Name, dexBase.bodyComponent.Name };
            string fusionname = "";
            for (int n = 0; n < cNames.Length - 1; n++)
            {
                fusionname += cNames[n].Substring(0, cNames[n].Length / 2);
            }
            fusionname += cNames[cNames.Length - 1].Substring(cNames[cNames.Length - 1].Length / 2);
            return fusionname;
        }

        public Tuple<RedLib.PokemonTypes,RedLib.PokemonTypes> getType()
        {
            //experimental score-based typing system

            /*Dictionary<RedLib.PokemonTypes, int> typescores = new Dictionary<RedLib.PokemonTypes, int>();
            RedLib.PokemonTypes type1 = dexBase.headComponent.types.Item1;
            RedLib.PokemonTypes type2 = (dexBase.fused ? dexBase.bodyComponent.types.Item2 : dexBase.headComponent.types.Item2);
            if (dexBase.fused)
            {
                typescores.Add(dexBase.headComponent.types.Item1, 2);
                if (dexBase.headComponent.types.Item2 != RedLib.PokemonTypes.typeless)
                {
                    typescores.Add(dexBase.headComponent.types.Item2, 1);
                }

                if (typescores.ContainsKey(dexBase.bodyComponent.types.Item1))
                {
                    typescores[dexBase.bodyComponent.types.Item1]++;
                }
                else
                {
                    typescores.Add(dexBase.bodyComponent.types.Item1, 1);
                }

                if (dexBase.bodyComponent.types.Item2 != RedLib.PokemonTypes.typeless &&
                    typescores.ContainsKey(dexBase.bodyComponent.types.Item2))
                {
                    typescores[dexBase.bodyComponent.types.Item2]++;
                }
                else
                {
                    typescores.Add(dexBase.bodyComponent.types.Item2, 2);
                }

                foreach (var item in typescores)
                {
                    if (item.Value > typescores[dexBase.headComponent.types.Item1])
                    {
                        type1 = item.Key;
                    }
                    if (item.Value > typescores[dexBase.bodyComponent.types.Item2])
                    {
                        type2 = item.Key;
                    }
                }
            }
            

            return new Tuple<RedLib.PokemonTypes, RedLib.PokemonTypes>(type1, type2);*/

            // traditional priority-based typing system

            RedLib.PokemonTypes type1 = dexBase.headComponent.types.Item1;
            RedLib.PokemonTypes type2 = dexBase.fused ?
                                       (dexBase.bodyComponent.types.Item2 == RedLib.PokemonTypes.typeless ?
                                        dexBase.bodyComponent.types.Item1 :
                                        dexBase.bodyComponent.types.Item2):
                                        dexBase.headComponent.types.Item2;

            return new Tuple<RedLib.PokemonTypes, RedLib.PokemonTypes>(type1, type2);
        }
    }
}
