using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.ConsoleApp
{
    class ValoresRomanos
    {
        private Dictionary<string, int> romanosParaInteiros = new Dictionary<string, int>();
        private Dictionary<int, string> inteirosParaRomanos = new Dictionary<int, string>();

        public ValoresRomanos()
        {

            romanosParaInteiros.Add("I", 1);
            romanosParaInteiros.Add("V", 5);
            romanosParaInteiros.Add("X", 10);
            romanosParaInteiros.Add("L", 50);
            romanosParaInteiros.Add("C", 100);
            romanosParaInteiros.Add("D", 500);
            romanosParaInteiros.Add("M", 1000);

            inteirosParaRomanos.Add(1, "I");
            inteirosParaRomanos.Add(5, "V");
            inteirosParaRomanos.Add(10, "X");
            inteirosParaRomanos.Add(50, "L");
            inteirosParaRomanos.Add(100, "C");
            inteirosParaRomanos.Add(500, "D");
            inteirosParaRomanos.Add(1000, "M");
        }

        public Dictionary<string, int> RomanosParaInteiros { get => romanosParaInteiros; }
        public Dictionary<int, string> InteirosParaRomanos { get => inteirosParaRomanos; }
    }
}
