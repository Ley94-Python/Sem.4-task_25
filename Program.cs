// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
double Sum(double x, double y)
{
double sum = 0;
for (double i = 1; i <= y; i++)
{
sum = Math.Pow(x, y);
}
return sum;
}
Console.Write("Введите число А: ");
double A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число В: ");
double B = Convert.ToInt32(Console.ReadLine());
double x = A;
double y = B;
double sum = Math.Pow(x, y);
Console.WriteLine("Ответ равен: " +sum);