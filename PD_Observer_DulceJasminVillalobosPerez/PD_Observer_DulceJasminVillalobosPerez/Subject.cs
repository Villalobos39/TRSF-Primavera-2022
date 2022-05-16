using System;
using System.Collections.Generic;
using System.Text;

namespace PD_Observer_DulceJasminVillalobosPerez
{
    public interface Subject
    {
        void registerObserver(Observer o);
        void removeObserver(Observer o);
        void notifyObservers();
    }
}
