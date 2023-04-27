using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mas3
{
    public class Substances
    {
        private String? chemicalName;
        private String? vernacular;
        private SubstanceSolubility solubility;
        public Substances(String? chemicalName, String? vernacular, SubstanceSolubility solubility)
        {
            this.chemicalName = chemicalName;
            this.vernacular = vernacular;
            this.solubility = solubility;
        }
        public override String ToString()
        {
            return $"{chemicalName} {vernacular} {solubility}";
        }  
    } 
}