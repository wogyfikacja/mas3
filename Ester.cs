using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mas3
{
    public class Ester : AcelContainingCompounds, IGasable, ISmellable
    {
        public bool isAryl {get; private set;}
        public double vanDerWaalsA { get; private set;}
        public double vanDerWaalsB { get; private set;}
        public List<string> PossibleSmell {get; private set;}

        public double CriticalTemperature => 8*vanDerWaalsA/(27*vanDerWaalsB*Constants.GasConstant);

        public Ester(bool isAryl, double vanDerWaalsA, double vanDerWaalsB,List<string> possibleSmell, string vernacular, string chemicalName, int molarMass, int density) : base(vernacular, chemicalName, molarMass, density)
        {
            this.isAryl = isAryl;
            this.vanDerWaalsA = vanDerWaalsA;
            this.vanDerWaalsB = vanDerWaalsB;
            this.PossibleSmell = possibleSmell;
        }
        public override string ToString()
        {
            return $"Ester: {base.ToString()} IsAryl: {isAryl}";
        }

        public void Smell(string smell)
        {
            var isSmell = PossibleSmell.Contains(smell);
            if(isSmell)
            {
                Console.WriteLine($"Ester smells to some like {smell}");
            }
            else
            {
                Console.WriteLine("Ester smells nothing like that");
            }
        }
    }
}