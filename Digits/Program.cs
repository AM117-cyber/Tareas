System.Console.WriteLine("Ingrese un numero entero.");                                                                                                                                                                                                                                                                     
double number = Double.Parse(Console.ReadLine());
while(true)
{
   System.Console.WriteLine(Numberofdigits(number));
number = Double.Parse(Console.ReadLine());
}

static double Numberofdigits(double number){
     int digits = 0;
    for (int i = 0; i < int.MaxValue; i++)
    {
        double divisor = Math.Pow(10,i);
        if (number-(number%divisor)==0)
        {
            digits = i;
            break;
        }
   
} return digits;
}

