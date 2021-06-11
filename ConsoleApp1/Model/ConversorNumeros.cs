using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class ConversorNumeros : ConversorBase
    {
        
        private int recebeValorNumerico;
        public ConversorNumeros()
        {
            AdicionandoNoDicionarioRomano();
        }

        public string RetornaNumeroRomano(int valor)
        {
            StringBuilder recebeCaracteresRomanos = new StringBuilder();
            recebeValorNumerico = valor;
            foreach (int numero in dicionarioRomanos.Keys)
            {
                while(recebeValorNumerico >= numero)
                {
                    recebeCaracteresRomanos.Append(dicionarioRomanos[numero]);
                    recebeValorNumerico -= numero;
                    
                }
            }

            return recebeCaracteresRomanos.ToString();
        }
    }
}
