using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.ConsoleApp
{
    public class ConversaoIndoArabicoParaRomano
    {
        private Dictionary<int, string> inteirosParaRomanos = new Dictionary<int, string>()
        {
            { 10000, "X̄" },{ 9000, "ĪX̄" },{ 8000, "V̄ĪĪĪ" },{ 7000, "V̄ĪĪ" }, { 6000, "V̄Ī" },
            { 5000, "V̄" }, { 4000, "ĪV̄" },{ 1000, "M" },{ 900, "CM" },{ 500, "D" },
            { 400, "CD"} , { 100, "C" },{ 90, "XC" },{ 50, "L" }, { 40, "XL" },
            { 10, "X" }, { 9, "IX" },{ 5, "V" }, { 4, "IV" },{ 1, "I" },
        };

        public string Converter(int algarismoIndoArabico)
        {
            foreach (int numero in inteirosParaRomanos.Keys)
                if (algarismoIndoArabico >= numero) 
                    return inteirosParaRomanos[numero] + Converter(algarismoIndoArabico - numero);         
            return "";
        }
    }

}
