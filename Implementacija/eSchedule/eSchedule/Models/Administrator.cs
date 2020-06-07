using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSchedule.Models
{
    public class Administrator
    {
        private string Id { get; set; }
        private string KorisnickoIme { get; set; }
        private string Lozinka { get; set; }
        private string Ime { get; set; }
        private string Prezime { get; set; }
        private string Jmbg { get; set; }
        private string EMail { get; set; }
        private List<Dogadjaj> Dogadjaji { get; set; }

        public Administrator(string id, string korisnickoIme, string lozinka, string ime, string prezime, string jmbg, string eMail, List<Dogadjaj> dogadjaji)
        {
            Id = id;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            Ime = ime;
            Prezime = prezime;
            Jmbg = jmbg;
            EMail = eMail;
            Dogadjaji = dogadjaji;
        }

        public void kreirajStudenta()
        {

        }

        public void kreirajProfesora()
        {

        }

        public void kreirajAsistenta()
        {

        }

        public void kreirajDemonstratora()
        {

        }

        public void kreirajPredmet()
        {

        }

        public void obrisiDogadjaj()
        {

        }
        public void upisiNaPredmet()
        {

        }
    }

}
