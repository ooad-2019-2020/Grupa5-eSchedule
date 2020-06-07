using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSchedule.Models
{
    public class Caretaker
    {
        private Schedule instance;
        private List<Memento> history;

        public void save()
        {
            history.Add(instance.saveUser());
        }

        public void undo()
        {
            instance.restoreUser(history.Last());
        }
    }
}
