using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrumentNamespace
{
    //Ma classe
    public class Instrument
    {
        public Instrument(string nom, string famille, string description)
        {
            Nom = nom;
            Famille = famille;
            Description = description;
        }

        //Propriétés
        public string Nom { get; set; }
        public string Famille { get; set; }
        public DateTime DateDeCreation { get; set; }


        //  accessibilité  type    nom         accesseur (getteur et setteur)
        public string Description{ get; set; }

    }
}
