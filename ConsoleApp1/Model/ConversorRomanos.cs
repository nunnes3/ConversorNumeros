using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class ConversorRomanos:ConversorBase
    {

        public ConversorRomanos()
        {
            AdicionandoNoDicionarioNumerico();
        }

        public int Conversor(string valorRomano)
        {

            string recebeValorPosTeste = TirandoMacron(valorRomano);

            int concatenadorResultado = 0;
            foreach (char letra in recebeValorPosTeste)
            {
                concatenadorResultado += RetornaNumero(letra);
            }

            concatenadorResultado = VerificaSubtracao(recebeValorPosTeste, concatenadorResultado);

            return concatenadorResultado;
        }

        private static int VerificaSubtracao(string recebeValorPosTeste, int concatenadorResultado)
        {
            if (recebeValorPosTeste.Contains("IV") || recebeValorPosTeste.Contains("IX"))
                concatenadorResultado -= 2;

            if (recebeValorPosTeste.Contains("iV") || recebeValorPosTeste.Contains("iX"))
                concatenadorResultado -= 2000;

            if (recebeValorPosTeste.Contains("iv") || recebeValorPosTeste.Contains("ix"))
                concatenadorResultado -= 2000;

            if (recebeValorPosTeste.Contains("XL") || recebeValorPosTeste.Contains("XC"))
                concatenadorResultado -= 20;

            if (recebeValorPosTeste.Contains("xL") || recebeValorPosTeste.Contains("xC"))
                concatenadorResultado -= 20000;

            if (recebeValorPosTeste.Contains("CD") || recebeValorPosTeste.Contains("CM"))
                concatenadorResultado -= 200;

            if (recebeValorPosTeste.Contains("cD") || recebeValorPosTeste.Contains("cM"))
                concatenadorResultado -= 20000;
            return concatenadorResultado;
        }

        private string TirandoMacron(string valorRomano)
        {
            string tiraMacron = valorRomano.ToUpper();

            tiraMacron = tiraMacron.Replace("Ī","i");
            tiraMacron = tiraMacron.Replace("V̄", "v");
            tiraMacron = tiraMacron.Replace("X̄", "x");

            return tiraMacron;
        }


        private int RetornaNumero(char letra)
        {
            int recebeNumero = 0;

            switch (letra)
            {
                case 'v':
                    {
                        return recebeNumero = dicionarioNumeros['v'];
                    }

                case 'x':
                    {
                        return recebeNumero = dicionarioNumeros['x'];
                    }

                case 'i':
                    {
                        return recebeNumero = dicionarioNumeros['i'];
                    }

                case 'M':
                    {
                        return recebeNumero = dicionarioNumeros['M'];
                    }
                case 'C':
                    {
                        return recebeNumero = dicionarioNumeros['C'];
                    }
                case 'L':
                    {
                        return recebeNumero = dicionarioNumeros['L'];
                    }
                case 'X':
                    {
                        return recebeNumero = dicionarioNumeros['X'];
                    }
                case 'V':
                    {
                        return recebeNumero = dicionarioNumeros['V'];
                    }
                case 'I':
                    {
                        return recebeNumero = dicionarioNumeros['I'];
                    }
                
            }

            return recebeNumero;
        }



        
    }
}


            
            



