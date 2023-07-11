namespace Course{
    class ConversordeMoeda{
        public static double Conversor(double dolar, double comprar ){
            double valo1 =  dolar * comprar;
            double valor2 = 6 * valo1 / 100;
            return  valo1 + valor2;
        }
    }
}