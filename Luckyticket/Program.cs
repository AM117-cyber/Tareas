Console.WriteLine("Ingrese los tickets.");
string TicketAsString = Console.ReadLine();
while (true)
{
    if(TicketAsString.Length == 6)
    {
 int number = Int32.Parse(TicketAsString);
  System.Console.WriteLine(IsItLucky(number));

    }
    else
    {
        System.Console.WriteLine("Invalid ticket.");
    }
 TicketAsString = Console.ReadLine();
}
    
static string IsItLucky(int number){
    int[] ticket = new int[6];
    for (int i = 0; i < ticket.Length; i++)
    {
        int a = Convert.ToInt32(number % Math.Pow(10,i+1));
        int b = Convert.ToInt32(Math.Pow(10,i));
        ticket[i] = a/b;
    }
    if (ticket[0]+ticket[1]+ticket[2]== ticket[4]+ticket[3]+ticket[5])
    {
        return "Yes";
    }
    return "No";
}

