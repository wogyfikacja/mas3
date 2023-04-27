using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mas3
{
    public interface IGasable
    {
        double vanDerWaalsA { get;}
        double vanDerWaalsB { get;}

        double CriticalTemperature { get; }
    }
}