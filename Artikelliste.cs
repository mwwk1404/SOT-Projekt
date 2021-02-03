using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOT_Projekt_Fahrradladen
{
    class Artikelliste
    {
        public List<Artikel> Ausgewählteartikel = new List<Artikel>();
       


        public void Artikelhinzufügen(Artikel t)
        {
            Ausgewählteartikel.Add(t);
           
        }

        
    }
}
