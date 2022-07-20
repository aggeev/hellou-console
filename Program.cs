 // Задача № 10;


 int number,number2,number3;

 number = new Random().Next(100,999);
 Console.WriteLine(" число "+ number);
 number2 =(number / 10) % 10;
 number3 =(number + 10) % 10;
 Console.WriteLine(" второе число " + number2);
 Console.WriteLine(" третье число "+ number3);

 