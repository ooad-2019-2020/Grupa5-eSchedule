using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSchedule.Models
{
    public class LaboratorijskaGrupa
    {
        private string Id { get; set; }
        private string Naziv { get; set; }
        private Predmet Predmet { get; set; }
        private int MaksimalniKapacitet { get; set; }
        private int TrenutniKapacitet { get; set; }
        private List<Student> Studenti { get; set; }
        private List<Asistent> Asistenti { get; set; }
        private List<Demonstrator> Demonstratori { get; set; }

        public LaboratorijskaGrupa(string id, string naziv, Predmet predmet, int maksimalniKapacitet, int trenutniKapacitet,
            List<Student> studenti, List<Asistent> asistenti, List<Demonstrator> demonstratori)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Predmet = predmet;
            this.MaksimalniKapacitet = maksimalniKapacitet;
            this.TrenutniKapacitet = trenutniKapacitet;
            this.Studenti = studenti;
            this.Asistenti = asistenti;
            this.Demonstratori = demonstratori;
        }

        
    }

}
