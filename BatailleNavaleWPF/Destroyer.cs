using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
//ajout commentaire pour but de test 
     class Destroyer : Navire
    {
        public Destroyer(Case[] cases):base(cases)
        {

        }

        public override string GetCourteName()
        {
            return "D";
        }
    }
}
