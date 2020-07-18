using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PokemonFusionFirstApproximation
{
    class BasePokemonMove
    {
        string Name;
        RedLib.PokemonTypes type;
        byte basePower;
        RedLib.physicalSpecial physSpec;

        public Action moveFunction
        {
            get; set;
        }

        public BasePokemonMove(string n, RedLib.PokemonTypes t, byte bp, RedLib.physicalSpecial pS, Action moveFunc )
        {
            Name = n;
            type = t;
            basePower = bp;
            moveFunction = moveFunc;
        }

    }
}
