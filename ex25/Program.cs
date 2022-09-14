// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int a, int b)
{
    int result = a;
    for (int i = 0; i < b - 1; i++)
    {
        result *= a;
    }
    return result;
}

Console.WriteLine("Введите число которое будет возведенное в степень = ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine(Exponentiation(a, b));