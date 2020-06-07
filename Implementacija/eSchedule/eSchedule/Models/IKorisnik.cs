using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSchedule.Models
{
    interface IKorisnik
    {
        public string getKorisnickoIme();
        public void setKorisnickoIme(string korisnickoIme);
        public string getLozinka();
        public void setLozinka(string lozinka);
        public string getIme();
        public void setIme(string ime);
        public string getPrezime();
        public void setPrezime(string prezime);
        public string getJmbg();
        public void setJmbg(string jmbg);
        public string getEMail();
        public void setEMail(string eMail);

        public string getId();

        public List<Predmet> getPredmeti();
        public void setPredmeti(List<Predmet> predmeti);

        public List<LaboratorijskaGrupa> getLaboratorijskeGrupe();
        public void setLaboratorijskeGrupe(List<LaboratorijskaGrupa> grupe);

        public List<Notifikacija> getNotifikacije();
        public void setNotifikacije(List<Notifikacija> notifikacije);

    }
}
