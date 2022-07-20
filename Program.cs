
int number,number2,number3;
number = new Random().Next(100,999);
Console.WriteLine(" число " + number);
number2 = (number / 10) %10;
number3 = (number + 10) %10;
    Console.WriteLine(" второе число " + number2);
    Console.WriteLine(" третье число " + number3);
//......

Console.WriteLine("введите день недели");
int input = Convert.ToInt32(Console.ReadLine());
 
 switch (input)
 {
    case 1:
        Console.WriteLine("понедельник");
        break;
    case 2:
        Console.WriteLine("вторник");
        break;
    case 3:
        Console.WriteLine("среда");
        break;
    case 4:
        Console.WriteLine("четверг");
        break;
    case 5:
        Console.WriteLine("пятница");
        break;
    case 6:
        Console.WriteLine("суббота");
        break;
    case 7:
        Console.WriteLine("воскресенье"); 
        break;                      
    default:
        Console.WriteLine("такого дня не существует ,ошибка");
        break;
 }