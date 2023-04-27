using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mas3
{
    public interface ISmellable
    {
        List<string> PossibleSmell{ get;}

        void Smell(string smell);
    }
}