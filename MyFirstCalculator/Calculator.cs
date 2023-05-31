using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCalculator
{
    public class Calculator
    {
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Substract(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

    }
    // Lo correcto seria "mokkar". Primero test unitario que le ayudan a hacer el codigo,
    // cuando tiene el codigo implementado hace el rest de integracion.
}
