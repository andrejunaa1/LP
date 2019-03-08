using System;

namespace cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variaveis
            string altura, raio;
            double a, r;
            double v, s;
            double pi = 3.1415926;

            //pedir altura ao user
            Console.Write("insira Altura: ");
            altura = Console.ReadLine();

            //pedir o raio ao user
            Console.Write("insira raio");
            raio= Console.ReadLine();

            //converter a altura p double
            a = Convert.ToDouble(altura);
            //converter raio p double
            r = Convert.ToDouble(raio);
            //calcular volume
            v = pi * r  *  a;
            //calcular sup
            s = 2 * pi*r * (r + a);
            //mostrar resultados
            Console.WriteLine($"volume= {v:f2}");
            Console.WriteLine($"areasup={s:f2]}");



        }
    }
}
