using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMosquitoVelho
{
    public class Operacoes
    {
        //método construtor
        public Operacoes()
        {

        }

        public double somar(double v1, double v2)
        {
            return (v1 + v2);
        }
        public double subtrair(double v1, double v2)
        {
            return (v1 - v2);
        }
        public double multiplicar(double v1, double v2)
        {
            return (v1 * v2);
        }
        public double dividir(double v1, double v2)
        {
            if (v2 != 0)
            {
                return (v1 / v2);
            }
            else
            {
                return 25;
            }
        }

    }
}
