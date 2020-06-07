using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSchedule.Models
{
    enum TipAktivnosti
    {
        Predavanje,
        Tutorijal,
        Kviz,
        Ispit,
        Usmeni_ispit,
        Nadoknada,
        Zadaca
    }

    public class Aktivnost
    {
        private int PredmetId { get; set; }
        private TipAktivnosti TipAktivnosti { get; set; }
        private string NazivAktivnosti { get; set; }
        private string Opis { get; set; }
        private DateTime Datum { get; set; }
        private DateTime Vrijeme { get; set; }
        private Sala Sala { get; set; }


    }
}
