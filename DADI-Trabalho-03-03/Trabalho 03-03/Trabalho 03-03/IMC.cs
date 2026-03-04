using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_03_03
{
    internal class IMC
    {
        public static float calcular (float peso, float altura)
        {
            return peso / (altura * altura);
        }
        public static string classificar(double imc)
        {
            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (imc < 25)
            {
                return "Peso normal";
            }
            else if (imc < 30)
            {
                return "Sobrepeso";
            }
            else
            {
                return "Obesidade";
            }
        }
    }
}
