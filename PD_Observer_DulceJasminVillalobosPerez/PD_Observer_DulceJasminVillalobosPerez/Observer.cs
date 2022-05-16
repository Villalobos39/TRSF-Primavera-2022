using System;
using System.Collections.Generic;
using System.Text;

namespace PD_Observer_DulceJasminVillalobosPerez
{
    public interface Observer
    {
        void update(float temp, float humidity, float pressure);
    }
}
