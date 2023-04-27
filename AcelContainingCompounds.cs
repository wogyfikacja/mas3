using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mas3
{
    public abstract class AcelContainingCompounds
    {
        private string vernacular;
        private string chemicalName;
        private int molarMass;
        private int density;
        public string Vernacular { get => vernacular; set => vernacular = value; }
        public string ChemicalName { get => chemicalName; set => chemicalName = value; }
        public int MolarMass { get => molarMass; set => molarMass = value; }
        public int Density { get => density; set => density = value; }

        public AcelContainingCompounds(string vernacular, string chemicalName, int molarMass, int density)
        {
            this.vernacular = vernacular;
            this.chemicalName = chemicalName;
            this.molarMass = molarMass;
            this.density = density;
        }
        //to string
        public override string ToString()
        {
            return $"{chemicalName} {vernacular} {molarMass} {density}";
        }
    }
}