using System;
using System.Globalization;
namespace Course{
    class funcionario{
        public string Nome;
        public double Salario;
        public double Imposto;

        public double CalculoImposto(){
           return  Salario - Imposto;
        }

        public void AumentarSalario(double porcentagem){
           double P =  porcentagem * CalculoImposto() / 100;
          Salario = CalculoImposto() + P;
        }

        public override string ToString()
        {
            return "Nome funcionário: " + Nome + ", salário $" + Salario.ToString("F2", CultureInfo.InvariantCulture) + ", salário com desconto de imposto: $" + CalculoImposto().ToString("F2", CultureInfo.InvariantCulture);
        }

      


    }
}