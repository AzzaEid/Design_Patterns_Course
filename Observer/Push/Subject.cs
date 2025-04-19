using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Push
{
    public interface Subject      // Observer
    {
        public void registerObserver(Observer o);
        public void removeObserver(Observer o);
        public void notifyObservers();

    }
}
