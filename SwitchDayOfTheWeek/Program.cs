
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

//sobob selleks et kontrollida vaid 1 väärtust. Nädalapäev saab olla vaid 1 väärtusega.
//teame, et väärtus on vahemikus 0-6

switch(weekDay) //väärtus mida kontrollitakse
{
    case 0: //case 0 on võrdne if kontrolliga ==if(weekDay==0)
        Console.WriteLine("It´s Sunday");
        break;// selleks et saaks switchi töö lõpetada, muidu jääbki kontrollima
    case 1:
        Console.WriteLine("It´s Monday");
        break;
    case 2:
        Console.WriteLine("It´s Tuesday");
        break;
    case 3:
        Console.WriteLine("It´s Wednesday");
        break;
    case 4:
        Console.WriteLine("It´s Thursday");
        break;
    case 5:
        Console.WriteLine("It´s Friday");
        break;
    case 6:
        Console.WriteLine("It´s Saturday");
        break;
    default:
        Console.WriteLine("Oops. Your calender must be broken");
        break;
}
Console.WriteLine("Have a nice day!");
