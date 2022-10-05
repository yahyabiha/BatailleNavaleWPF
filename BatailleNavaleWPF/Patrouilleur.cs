using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class Patrouilleur : Navire
    {
        
        public Patrouilleur(Case[] cases) : base(cases)
        {

        }

        public override string GetCourteName()
        {
            return "P";
        }
    }
}
