System.Console.WriteLine("Escriba su id:");
long id = Int64.Parse(Console.ReadLine());
int birthdate = Convert.ToInt32(id/100000);
int year = birthdate/10000;
if(year>=23)
{
    year = 1900 + year;
}else
{
    year = 2000 + year;
}
System.Console.WriteLine("Tu fecha de nacimiento es {2}/{1}/{0}.", year, (birthdate%10000)/100, birthdate%100);
long sex = ((id%100)/10);
if ((sex%2)!=0)
{
 System.Console.WriteLine("Sexo:Femenino.");
}else
{
    System.Console.WriteLine("Sexo:Masculino.");
}
