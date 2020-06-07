using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSchedule.Models
{
    public abstract class Korisnik : IKorisnik
    {
        protected string id;
        protected string korisnickoIme;
        protected string lozinka;
        protected string ime;
        protected string prezime;
        protected string jmbg;
        protected string eMail;
        protected List<Predmet> predmeti;
        protected List<LaboratorijskaGrupa> laboratorijskeGrupe;
        protected List<Notifikacija> notifikacije;

        public abstract string getEMail();
        public abstract string getId();
        public abstract string getIme();
        public abstract string getJmbg();
        public abstract string getKorisnickoIme();
        public abstract List<LaboratorijskaGrupa> getLaboratorijskeGrupe();
        public abstract string getLozinka();
        public abstract List<Notifikacija> getNotifikacije();
        public abstract List<Predmet> getPredmeti();
        public abstract string getPrezime();
        public abstract void setEMail(string eMail);
        public abstract void setIme(string ime);
        public abstract void setJmbg(string jmbg);
        public abstract void setKorisnickoIme(string korisnickoIme);
        public abstract void setLaboratorijskeGrupe(List<LaboratorijskaGrupa> grupe);
        public abstract void setLozinka(string lozinka);
        public abstract void setNotifikacije(List<Notifikacija> notifikacije);
        public abstract void setPredmeti(List<Predmet> predmeti);
        public abstract void setPrezime(string prezime);


    }
}
