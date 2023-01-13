// Задача 0 
// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

/*

Console.Clear();
Console.Write("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n * n ;
Console.WriteLine($" Квадрат вашего числа = {m}");

*/

// Задача 1
// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

/*

Console.Clear();
Console.Write("Введите число 1: ");
    int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
    int m = Convert.ToInt32(Console.ReadLine());

if (m * m == n) 
    Console.WriteLine("yes");
else 
    Console.WriteLine("NO");

*/

// Задача 3
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

/*

Console.Clear();
Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
// && - и(логическое умножение)
// || - или(логическое сложение)
// True - 1
// False - 0
//       1    +   0   = 1(True)
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите день недели: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
    Console.WriteLine("Понедельник");
else if (n == 2)
    Console.WriteLine("Вторник");
else if (n == 3)
    Console.WriteLine("Среда");
else if (n == 4)
    Console.WriteLine("Четверг");
else if (n == 5)
    Console.WriteLine("Пятница");
else if (n == 6)
    Console.WriteLine("Суббота");
else
    Console.WriteLine("Воскресенье");

*/

// Задача 5
// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

/*

Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n * (-1);

while (m <= n )
{
    Console.Write($"{m} ");
    m = m + 1; //m++;
}

*/

// Задача 7
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

/*

Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n % 10); // - последняя цифра любого числа

*/