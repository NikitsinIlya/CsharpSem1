Console.Clear();
// Task 1
// Напиши программу, котрая на вход принимает 2 числа и выдает, какое число больше, а какое меньше
/*
Console.Clear();

Console.Write("Введите 1-e число : ");
    int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-e число : ");
    int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"max = {number1} , min = {number2}");
}
else
{
    Console.WriteLine($"max = {number2} , min = {number1}");
}

*/

//Task 2
// Напиши программу, которая принемает на вход 3 числа и выдает максимальное из этих 3 чисел.
/*

Console.Write("Введите 1-е число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
    int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if (max <= number2)
    {
        max = number2;
    }
else if (max <= number3)
{
    max = number3;
}  
Console.WriteLine($"Максимальное число из {number1} , {number2} , {number3} Будет {max}");

*/

// Task 3
// Напиши программу, которая на вход принимает число и выдает, является ли число четным (делится на 2 без остатка)
/*
Console.Write("Введите 1-e число : ");
    int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 % 2 == 0)
{
    Console.WriteLine($"Число {number1} четное.");
}
else
{
    Console.WriteLine($"Число {number1} нечетное.");
}
*/ 
// Task 4
// Напиши программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N


Console.Write("Введите число N : ");
    int number1 = Convert.ToInt32(Console.ReadLine());
int m = 1;
while(m <= number1)
{
    if(m % 2 == 0)
    {
        Console.Write($"{m} ,");
    }
m++;

}
