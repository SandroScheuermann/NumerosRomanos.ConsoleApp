using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.ConsoleApp
{
    public class ConversaoRomanoParaIndoArabico
    {
        ValoresRomanos dicionariosRomanos = new ValoresRomanos();
        List<int> listaDeNumerosConvertidos = new List<int>();
        int valorFinal = 0;

        public int Converter(string numeroRomano)
        {
            for (int i = 0; i < numeroRomano.Length; i++)
            {
                if (i > 0 && numeroRomano[i] == 772)
                    listaDeNumerosConvertidos[i - 1] = (dicionariosRomanos.RomanosParaInteiros[(char)numeroRomano[i - 1] + ""]) * 1000;
                else if (numeroRomano[i] == 298)
                    listaDeNumerosConvertidos.Add(dicionariosRomanos.RomanosParaInteiros["I"] * 1000);
                else
                    listaDeNumerosConvertidos.Add(dicionariosRomanos.RomanosParaInteiros[numeroRomano[i] + ""]);
            }

            for (int i = 0; i < listaDeNumerosConvertidos.Count; i++)
                valorFinal = VerificaSeHaSubtracaoIXC(i) ? valorFinal = SubtraiIXC(i) : valorFinal += listaDeNumerosConvertidos[i];

            return valorFinal;
        }
        private bool VerificaSeHaSubtracaoIXC(int i)
        {
            return i > 0 && listaDeNumerosConvertidos[i - 1] < listaDeNumerosConvertidos[i];
        }
        private int SubtraiIXC(int i)
        {
            return (valorFinal - listaDeNumerosConvertidos[i - 1]) + listaDeNumerosConvertidos[i] - listaDeNumerosConvertidos[i - 1];
        }
    }
}