
int number,number2,number3;
number = new Random().Next(100,999);
Console.WriteLine(" число " + number);
number2 = (number / 10) %10;
number3 = (number + 10) %10;
    Console.WriteLine(" второе ичисло " + number2);
    Console.WriteLine(" третье число " + number3);
