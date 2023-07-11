using System;
using System.Globalization;


namespace Course{
    class notas{
        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public double NotaFinal(){
            return (N1 + N2 + N3) / 3;
        }

         public override string ToString()
        {
            return "Nota final: " +  NotaFinal().ToString("F2", CultureInfo.InvariantCulture);
        }

         

    }
}