namespace Weboo.Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Case1();
        }

        static void Case1()
        {
            Console.WriteLine("Case 1");
            int[] numeros = new int[] {-10,-34,-5,0,23,-6,12,-32,-1,-80,10};
            int[][] soluciones = new int[][]
            {
                new int[] { -8, -2, 1, 20},
            };
            Test(numeros, soluciones);
        }

        static void Test(int[] numeros, int[][] soluciones)
        {
            int[] solucionObtenida = Solucion.MejorRotacion(numeros);
            if (soluciones.Any(solucion => solucion.SequenceEqual(solucionObtenida)))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("OK");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR");
                Console.WriteLine($"Se obtuvo: {{ {string.Join(", ", solucionObtenida)} }}");
                Console.WriteLine("Se esperaba una de las siguientes soluciones:");
                foreach (var solucion in soluciones)
                    Console.WriteLine($"- {{ {string.Join(", ", solucion)} }}");
                Console.ResetColor();
            }
        }
    }
}
