using System;
namespace Course{
    class triangulo{
        public double A;
        public double B;
        public double C;

        //criação de metodo 

        public double Area(){
            double p = (A + B + C) /2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));

        }


    }
}