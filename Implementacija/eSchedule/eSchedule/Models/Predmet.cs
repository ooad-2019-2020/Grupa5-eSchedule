using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSchedule.Models
{

    public enum Smjer
    {
        Automatika_i_elektronika,
        Elektroenergetika,
        Racunarstvo_i_informatika,
        Telekomunikacije,
        Razvoj_softvera
    }
    public class Predmet
    {
        private string id; // ili integer
        private string naziv;
        private Smjer smjer;
        private int godina;
        private Semestar semestar;
        private TipPredmeta tip;
        private Profesor profesor;
        private List<Aktivnost> aktivnosti;
        

        private enum Semestar
        {
            Zimski,
            Ljetni
        }

        private enum TipPredmeta
        {
            Obavezni,
            Izborni
        }
    }
}
