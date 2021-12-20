using System; 

class DIO {

    static void Main(string[] args) { 

      double a, c, S = 0;
            for (int i = 1; i <= 100; i++)
            {
                c = 1 / i ;  //coloque a sua lógica nos espaços em branco
                S +=  c ;
            }
            double x=Math.Round(S,2);
            Console.WriteLine(x);
    }

}