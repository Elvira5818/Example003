// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//    14212 -> нет
//  23432 -> да
// 12821 -> да

Console.Clear();

Console.Write("Введите пятизначное число: ");
int x1 = int.Parse(Console.ReadLine() ?? "");
if (x1 < 10000)
{

    Console.WriteLine($"Введено некорректное значение");
}
else if (x1 >= 100000)
{

    Console.WriteLine($"Введено некорректное значение");

}
else
{

    int firstnumber = x1 / 10000;
    int secondnumber = (x1 / 1000) - (firstnumber * 10);
    int fifthnumber = x1 % 10;
    int fourtnumber = ((x1 % 100) - fifthnumber) / 10;
    if (firstnumber == fifthnumber && secondnumber == fourtnumber)
    {

        Console.WriteLine($"Число {x1} является палиндромом");
    }

    else
    {

        Console.WriteLine($"Число {x1} не является палиндромом");
    }
}

