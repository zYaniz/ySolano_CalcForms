using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ysolano_CalcForms.Operacion
{
    class Operacion
    {
        public int Sumar(int N1, int N2)
        {
            int Suma;
            Suma = N1 + N2;
            return Suma;
        }
        public int Restar(int N1, int N2)
        {
            int Resta;
            Resta = N1 - N2;
            return Resta;
        }
        public int Multiplicar(int N1, int N2)
        {
            int Multi;
            Multi = N1 * N2;
            return Multi;
        }
        public int Division(int N1, int N2)
        {
            int Divi;
            Divi = N1 / N2;
            return Divi;
        }


    }

}
