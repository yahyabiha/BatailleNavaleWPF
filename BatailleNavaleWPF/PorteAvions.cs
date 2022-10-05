﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class PorteAvions : Navire
    {
        public PorteAvions(Case[] cases) : base(cases)
        {

        }

        public override string GetCourteName()
        {
            return "PA";
        }
    }
}
