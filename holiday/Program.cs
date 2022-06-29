Console.WriteLine("Введите номер дня недели:");
int a = Convert.ToInt32(Console.ReadLine());
string[] weekDays = new string[] {"Mon", "Tue", "Web", "Thu", "Fri", "Sat", "Sun"};

if (a <= 5)
Console.WriteLine(weekDays[a - 1] + " No");
else
Console.WriteLine(weekDays[a - 1] + " Yes");


/*Console.WriteLine("Введите номер дня недели:");
int number = Convert.ToInt32(Console.ReadLine());

switch(number)
{
    case 1:
        Console.WriteLine("Mon no");
        break;
    case 2:
        Console.WriteLine("Tue no");
        break;
    case 3:
        Console.WriteLine("Web no");
        break;
    case 4:
        Console.WriteLine("Thu no");
        break;
    case 5:
        Console.WriteLine("Fri no");
        break;
    case 6:
        Console.WriteLine("Sat yes");
        break;
    case 7:
        Console.WriteLine("Sun yes");
        break;
    default:
        Console.WriteLine("Введите другое число!");
        break;
}*/
