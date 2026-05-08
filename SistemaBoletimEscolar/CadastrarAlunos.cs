using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBoletimEscolar
{
    internal class CadastrarAlunos
    {
        public string Nomes;
        public List<double> Notas = new List<double> { };

        public double Media ()
        {
            double soma = 0;
            if (Notas.Count == 0) {
                return 0;
            }
            else
            {
                foreach (double nota in Notas) 
                {
                    soma += nota;
                }
                return soma / Notas.Count;
            }
        }
    }
}
