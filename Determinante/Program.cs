System.Console.WriteLine("Escriba los numeros de la ecuacion.");
int a = Int32.Parse(Console.ReadLine());
int b = Int32.Parse(Console.ReadLine());
int c = Int32.Parse(Console.ReadLine());
double determinante = Math.Pow(b,2)-4*a*c;
switch (determinante)
{
    case <0:
    System.Console.WriteLine("No tiene solucion.");
    break;
    case >0:
    int solution1 = Convert.ToInt32((-b + Math.Sqrt(determinante))/2*a);
    int solution2 = Convert.ToInt32((-b - Math.Sqrt(determinante))/2*a);
     System.Console.WriteLine("Las soluciones son x={0} o x={1}.",solution1,solution2);
    break;
    default:
    System.Console.WriteLine("La solucion es {0}.",(-b + Math.Sqrt(determinante))/2*a);
    break;
}