using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSchedule.Models
{
    public class Memento
    {
        private Korisnik Korisnik { get; set; }

        private Memento(Korisnik korisnik)
        {
            Korisnik = korisnik;
        }

    }
}
