using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class ConversorBase
    {
        public Dictionary<int, string> dicionarioRomanos;
        public Dictionary<char, int> dicionarioNumeros;
        public void AdicionandoNoDicionarioRomano()
        {
            dicionarioRomanos = new Dictionary<int, string>();
            dicionarioRomanos.Add(10000, "X̄");
            dicionarioRomanos.Add(9000, "ĪX̄");
            dicionarioRomanos.Add(8000, "V̄ĪĪĪ");
            dicionarioRomanos.Add(7000, "V̄ĪĪ");
            dicionarioRomanos.Add(6000, "V̄Ī");
            dicionarioRomanos.Add(5000, "V̄");
            dicionarioRomanos.Add(4000, "ĪV̄");
            dicionarioRomanos.Add(1000, "M");
            dicionarioRomanos.Add(900, "CM");
            dicionarioRomanos.Add(500, "D");
            dicionarioRomanos.Add(400, "CD");
            dicionarioRomanos.Add(100, "C");
            dicionarioRomanos.Add(90, " XC");
            dicionarioRomanos.Add(50, "L");
            dicionarioRomanos.Add(40, "XL");
            dicionarioRomanos.Add(10, "X");
            dicionarioRomanos.Add(9, "IX");
            dicionarioRomanos.Add(5, "V");
            dicionarioRomanos.Add(4, "IV");
            dicionarioRomanos.Add(1, "I");

        }

        public void AdicionandoNoDicionarioNumerico()
        {
            dicionarioNumeros = new Dictionary<char, int>();
            dicionarioNumeros.Add('x', 10000);
            dicionarioNumeros.Add('v', 5000);
            dicionarioNumeros.Add('i', 1000);
            dicionarioNumeros.Add('M', 1000);
            dicionarioNumeros.Add('C', 100);
            dicionarioNumeros.Add('L', 50);
            dicionarioNumeros.Add('X', 10);
            dicionarioNumeros.Add('V', 5);
            dicionarioNumeros.Add('I', 1);
        }
    }
}
