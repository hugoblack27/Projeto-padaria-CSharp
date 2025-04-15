using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padaria
{
    internal class Operacoes
    {
        public Operacoes() 
        {
        
        }
        public double somaValor(double v1, double v2) 
        {
            return (v1 + v2);
        }
        public double subtracaoValor(double v1, double v2)
        {
            return (v1 - v2);
        }
        public double multiplicacaoValor(double v1, double v2)
        {
            return (v1 * v2);
        }
        public double divisaoValor(double v1, double v2)
        {
            return (v1 / v2);
        }
    }
}
