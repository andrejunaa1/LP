using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "XDXD";
            string b = @"""to o""";
            Console.WriteLine(a);
            Console.WriteLine(b);

            string c = "Hello" + " " + "Jr";
            Console.WriteLine(c);

            string d = $"{5} mais{3} é igual a {5 + 3}";
            Console.WriteLine(d);

        }
    }
}
