using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSchedule.Models
{
    public class Schedule
    {
        private static Schedule instance;
        private Korisnik trenutniKorisnik;

        private Schedule()
        {
            //trenutniKorisnik = ulogovani korisnik
        }

        public Schedule getInstance()
        {
            if(instance == null) { instance = new Schedule(); }
            return instance;
        }

        public void posaljiNotifikaciju(Notifikacija notifikacija)
        {

        }

        public void provjeriLogIn()
        {

        }

        public Memento saveUser()
        {
            return null;
        }

        public void restoreUser(Memento memento)
        {

        }
    }
}
