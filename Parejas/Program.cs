using System;

namespace Parejas
{
    class Program
    {
        static void Main(string[] args)
        {
            var sistema = new Sistema();
            Console.WriteLine(sistema.Saludo("1daw3"));

            var parejas = sistema.PosibleParejas(sistema.Personas);
            parejas.ForEach(p=> Console.WriteLine($"{p.Item1} {p.Item2}"));
        }
    }
}
