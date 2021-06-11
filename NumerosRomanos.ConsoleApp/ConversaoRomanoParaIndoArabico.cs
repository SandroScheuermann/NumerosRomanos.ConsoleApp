using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.ConsoleApp
{
    public class ConversaoRomanoParaIndoArabico
    {
        private Dictionary<string, int> romanosParaInteiros = new Dictionary<string, int>()
        {
            { "I", 1 },{"V", 5 },{"X", 10},{"L", 50},{"C", 100},{"D", 500},{"M", 1000}
        };
        List<int> listaDeNumerosConvertidos = new List<int>();
        string numeroRomano = "";

        public int Converter(string numeroRomano)
        {
            this.numeroRomano = numeroRomano;

            for (int algarismo = 0; algarismo < numeroRomano.Length; algarismo++)
                if (CasoForMacronNoXV(algarismo))
                    AdicionaInteiroMacronXV(algarismo);
                else if (CasoForMacronNoI(algarismo))
                    AdicionaInteiroMacronI();
                else
                    AdicionaInteiroNormal(numeroRomano, algarismo);

            return ConverteParaValorFinal();
        }

        private int ConverteParaValorFinal()
        {
            int valorFinal = 0;

            for (int i = 0; i < listaDeNumerosConvertidos.Count; i++)
                valorFinal = VerificaSeTemSubtracaoIXC(i) ? valorFinal = SubtraiIXC(i, valorFinal) : valorFinal += listaDeNumerosConvertidos[i];

            return valorFinal;
        }

        private void AdicionaInteiroNormal(string numeroRomano, int i)
        {
            listaDeNumerosConvertidos.Add(romanosParaInteiros[numeroRomano[i] + ""]);
        }

        private void AdicionaInteiroMacronI()
        {
            listaDeNumerosConvertidos.Add(romanosParaInteiros["I"] * 1000);
        }

        private void AdicionaInteiroMacronXV(int i)
        {
            listaDeNumerosConvertidos[i - 1] = (romanosParaInteiros[numeroRomano[i - 1] + ""]) * 1000;
        }

        private bool CasoForMacronNoI(int i)
        {
            const int MACRON_NO_I = 298;
            return numeroRomano[i] == MACRON_NO_I;
        }

        private bool CasoForMacronNoXV(int i)
        {
            const int MACRON = 772;
            return i > 0 && numeroRomano[i] == MACRON;
        }

        private bool VerificaSeTemSubtracaoIXC(int i)
        {
            return i > 0 && listaDeNumerosConvertidos[i - 1] < listaDeNumerosConvertidos[i];
        }

        private int SubtraiIXC(int i, int valorFinal)
        {
            return (valorFinal - listaDeNumerosConvertidos[i - 1]) + listaDeNumerosConvertidos[i] - listaDeNumerosConvertidos[i - 1];
        }
    }
}