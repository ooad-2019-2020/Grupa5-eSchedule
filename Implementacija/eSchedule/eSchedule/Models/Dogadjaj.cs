using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSchedule.Models
{
    public class Dogadjaj
    {
        
        private TipDogadjaja TipDogadjaja { get; set; }
        private string Naziv { get; set; }
        private string Poruka { get; set; }
        private DateTime Datum { get; set; }

        public Dogadjaj(TipDogadjaja tip, string naziv, string poruka, DateTime datum)
        {
            TipDogadjaja = tip;
            Naziv = naziv;
            Poruka = poruka;
            Datum = datum;
        }

    }
}
