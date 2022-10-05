using System;

namespace BatailleNavale
{
     abstract class Navire: INavire
    {
        //public TypeNavire Type { get; }
        public bool Coule { get => EstCoule(); }

        private readonly Case[] cases;

        public Navire(Case[] carres)

        {
            //Type = type;
            cases = carres;

            foreach (Case carre in cases)
            {
                carre.Navire = this;
            }
        }

        private bool EstCoule()
        {
            foreach (Case carre in cases)
            {
                if (!carre.Touche) return false;
            }
            return true;
        }
        
        // public abstract override string ToString();

        public abstract string GetCourteName();
    }
}
