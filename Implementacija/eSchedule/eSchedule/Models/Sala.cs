using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSchedule.Models
{
    public class Sala
    {
        private string Naziv { get; set; }
        private string Id { get; set; }
        private int Kapacitet { get; set; }

        public Sala(string naziv, string id, int kapacitet)
        {
            Naziv = naziv;
            Id = id;
            Kapacitet = kapacitet;
        }
    }
}
