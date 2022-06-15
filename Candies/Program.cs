Console.WriteLine("Ingrese el numero de caramelos por caja con un espacio entre las cantidades.");
//DUDA: Cuando pongo 12 4 5 me da error.
string candies =  Console.ReadLine();
string[] numbers = candies.Split(" ");
int[] candiesForMethod = new int[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    candiesForMethod[i] = Int32.Parse(numbers[i]);
}
int min = int.MaxValue;
for (int i = 0; i < numbers.Length; i++)
{
    min = Math.Min(candiesForMethod[i],min);
}
int difference = 0;
for (int i = 0; i < numbers.Length; i++)
{
    difference += candiesForMethod[i]-min;
}
System.Console.WriteLine(difference);
