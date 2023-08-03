using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraForms
{






    class ControlCalculadora
    {
        private double operacao;
        public ControlCalculadora()
        {
            ConsultarOperacao = 0;
        }//fim do construtor

        public double ConsultarOperacao
        {
            get { return operacao; }
            set { this.operacao = value; }
        }//fim do método


        public double Somar(double num)
        {
            return ConsultarOperacao += num;
        }//fim do somar

        public double Subtrair(double num)
        {
            return ConsultarOperacao -= num;
        }//fim do subtrair

        public double Dividir(double num)
        {
            if (ConsultarOperacao <= 0)
            {
                return ConsultarOperacao = num;
            }
            return ConsultarOperacao /= num;

        }//fim do dividir

        public double Multiplicar(double num)
        {
            if (ConsultarOperacao <= 0)
            {
                return ConsultarOperacao = num;
            }
            return ConsultarOperacao *= num;


        }//fim do ultiplicacao

        public double potencia(double num)
        {
            if (ConsultarOperacao <= 0)
            {
                return ConsultarOperacao = num;
            }
            return Math.Pow(ConsultarOperacao, num);

        }

        public double raiz(double num)
        {

            if (ConsultarOperacao <= 0)
            {
                return ConsultarOperacao = num;
            }
            return Math.Sqrt(ConsultarOperacao);
        }

    }

}




