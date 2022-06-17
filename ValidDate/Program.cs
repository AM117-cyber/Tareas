// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese una fecha con este formato: day/month/year.");
string [] datedata = Console.ReadLine().Split('/');
int day = Int32.Parse(datedata [0]);
int month = Int32.Parse(datedata [1]);
int year = Int32.Parse(datedata[2]);
System.Console.WriteLine(IsItValid(day,month,year));

static bool IsItValid (int day, int month, int year){
    if(day <= 0 || day > 31 ||month > 12 || month < 0 || year <= 0)
    {
       return false;
    }
      if(day <= 31 && (month%2!=0 || month==8 || month ==10 || month ==12))
      {
        return true;
      }else if(day<=30 && month!=2)
      {
        return true;
      }
      switch (day)
      {
        case <=28:
        return true;
        case 29:
        if (year %4 == 0 && year % 100 != 0)
        {
            return true;
        }
        break;
      }
      return false;
    }