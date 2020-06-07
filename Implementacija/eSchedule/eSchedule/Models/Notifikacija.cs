using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSchedule.Models
{
    public class Notifikacija
    {
        private string naslov;
        private string sadrzaj;

        public Notifikacija(string naslov, string sadrzaj)
        {
            this.naslov = naslov;
            this.sadrzaj = sadrzaj;
        }

        public string getNaslov()
        {
            return naslov;
        }

        public string getSadrzaj()
        {
            return sadrzaj;
        }
        
        public void setNaslov(string naslov)
        {
            this.naslov = naslov;
        }


        public void setSadrzaj(string sadrzaj)
        {
            this.sadrzaj = sadrzaj;
        }
    }
}
