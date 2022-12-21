// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine ("Введите число: ");
int num = int.Parse(Console.ReadLine());

if(num > -100 && num < 100)
    {
    Console.WriteLine("Здесь нет третьей цифры ");
    }
else
{   
    if(num < 0)
    num = num * -1;
    {
    while(num > 1000)
    num = num / 10;
    }
    {
    while(num >= 10)
    num = num -10;
    }
}
Console.WriteLine($"Третья цифра {num}");
