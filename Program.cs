using System;

namespace mas3 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //abstract class
           AcelContainingCompounds first = new Acid(0.0,"woda","h2o",1,1);
           var possibleSmells = new List<string>{"smelly","apple"};
           AcelContainingCompounds second = new Ester(true,2.0,2.0,possibleSmells,"kwiatowy","k20",1,1);
           
           //this is because i was a little too lazy, and thats how the language works. should only use one type of inheritance from what i see
           var secondButEster = (Ester)second;
           Console.WriteLine(first.ToString());
           Console.WriteLine(second.ToString());
           Console.WriteLine("---------------");
           
           //overlapping
           var solubility = SubstanceSolubility.ACOET_SOLUBLE |  SubstanceSolubility.DCM_SOLUBLE
                ;
           var substance = new Substances("h20","water",solubility);
           Console.WriteLine(substance.ToString());
           Console.WriteLine("---------------");

           //multiple inheritance
           secondButEster.Smell("apple");
           var temp = secondButEster.CriticalTemperature;
           Console.WriteLine(temp);
           Console.WriteLine("---------------");
           
           //dynamic
           Dictionary<string,int> dictionary = new Dictionary<string,int>();
           dictionary.Add("key",1);
           IRoom dynamic = new Storage(1,1,dictionary);
           Console.WriteLine(dynamic.ToString());
           dynamic = new Laboratory(dynamic,dictionary);
           Console.WriteLine(dynamic.ToString());
        }
    }
}