using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSchedule.Models
{
    public class Asistent : Korisnik
    {
        private string asistentId;

        public Asistent(string id, string korisnickoIme, string lozinka, string ime, string prezime, string jmbg, string eMail, string asistentId)
        {
            this.id = id;
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.eMail = eMail;
            this.asistentId = asistentId;
        }

        public override string getEMail()
        {
            return eMail;
        }

        public override string getId()
        {
            return id;
        }

        public override string getIme()
        {
            return ime;
        }

        public override string getJmbg()
        {
            return jmbg;
        }

        public override string getKorisnickoIme()
        {
            return korisnickoIme;
        }

        public override string getLozinka()
        {
            return lozinka;
        }

        public override List<Predmet> getPredmeti()
        {
            return predmeti;
        }

        public override string getPrezime()
        {
            return prezime;
        }

        public override void setEMail(string eMail)
        {
            this.eMail = eMail;
        }

        public override void setIme(string ime)
        {
            this.ime = ime;
        }

        public override void setJmbg(string jmbg)
        {
            this.jmbg = jmbg;
        }

        public override void setKorisnickoIme(string korisnickoIme)
        {
            this.korisnickoIme = korisnickoIme;
        }

        public override void setLozinka(string lozinka)
        {
            this.lozinka = lozinka;
        }

        public override void setPredmeti(List<Predmet> predmeti)
        {
            this.predmeti = predmeti;
        }

        public override void setPrezime(string prezime)
        {
            this.prezime = prezime;
        }

        public override List<LaboratorijskaGrupa> getLaboratorijskeGrupe()
        {
            return laboratorijskeGrupe;
        }

        public override void setLaboratorijskeGrupe(List<LaboratorijskaGrupa> laboratorijskeGrupe)
        {
            this.laboratorijskeGrupe = laboratorijskeGrupe;
        }

        public override List<Notifikacija> getNotifikacije()
        {
            return notifikacije;
        }

        public override void setNotifikacije(List<Notifikacija> notifikacije)
        {
            this.notifikacije = notifikacije;
        }

        public string getAsistentId()
        {
            return asistentId;
        }

        public void setAsistentId(string asistentId)
        {
            this.asistentId = asistentId;
        }

        public void unesiPrisustvo()
        {

        }

        public void pomjeriVjezbe()
        {

        }

        public void dodajULaboratorijskuGrupu()
        {

        }
    }
}
