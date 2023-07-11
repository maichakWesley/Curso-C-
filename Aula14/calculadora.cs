
namespace Course {
    class Calculadora{
        public  static double Pi = 3.14; //aqui usamos o public para poder acessar essas classes no main principal 
        //aqui como os valores são os mesmo estão usamos o static para facilitar o uso no main, agora chamamos as operaçoes pelo nome das classes
                
        public static double Circuferencia(double raio){

            return 2.0 * Pi * raio;

        } 

        public static double Volume(double raio){

            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);

        } 
    }
}