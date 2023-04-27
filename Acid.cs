using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mas3
{
    public class Acid : AcelContainingCompounds
    {
        private double pka;
        public double Pka { get => pka; set => pka = value; }

        public Acid(double pka, string? vernacular, string? chemicalName, int molarMass, int density) : base(vernacular, chemicalName, molarMass, density)
        {
            this.pka = pka;
            this.Vernacular = vernacular;
            this.ChemicalName = chemicalName;
            this.MolarMass = molarMass;
            this.Density = density;
        }

        public override string ToString()
        {
            return $"Acid: {base.ToString()} Pka: {pka}";
        }
    }
}