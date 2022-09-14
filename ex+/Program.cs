// Программа заполняет массив 8 случайными числами. 
// Задача А. Напишите функцию, которая находит среднее арифметическое чисел в массиве.
// Задача Б. Напишите функцию, которая принимает массив и находит в нём наибольший элемент. 
// Задача В. Напишите функцию, которая проверяет, верно ли, что все числа в массиве чётные. 
// Задача Г. Напишите функцию, которая проверяет, верно ли, что числа в массиве идут по возрастанию. 

int[] array = new int[8];

System.Console.WriteLine("Введите 1 для случайного заполнения массива, 2 для ручного ввода");
switch (int.Parse(Console.ReadLine()!))
{
    case 1:
        array = CreateArray();
        break;
    case 2:
        array = InputArray();
        break;
    default:
        System.Console.WriteLine("Не верный ввод");
        break;
}

System.Console.WriteLine("Числа в массиве");
PrintArray(array);

System.Console.Write("Средне арифметическое - ");
System.Console.WriteLine(SearchMedium(array));

System.Console.Write("Максимальное число в массиве - ");
System.Console.WriteLine(SearchMax(array));

System.Console.Write("проверка на четность - ");
System.Console.WriteLine(СheckEven(array));

System.Console.Write("проверка на возрастание - ");
System.Console.WriteLine(СheckIncrease(array));


int[] CreateArray()
{
    int[] arr = new int[8];
    for (int i = 0; i < 8; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}

int[] InputArray()
{
    System.Console.WriteLine("Введите 8 чисел разделяя пробелами");
    string stringArr = Console.ReadLine()!;
    string[] parts = stringArr.Split(' ');
    int[] arr = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
    if (parts.Length == 8)
    {
        for (int i = 0; i < 8; i++)
        {
            arr[i] = int.Parse(parts[i]);
        }
    }
    else
    {
        System.Console.WriteLine("Не верный ввод");
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < 8; i++)
    {
        System.Console.Write(arr[i]);
        if (i < 7)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.WriteLine();
}

double SearchMedium(int[] arr)
{
    double sum = 0;
    for (int i = 0; i < 8; i++)
    {
        sum += arr[i];
    }
    double Medium = sum / 8;
    return Medium;
}

int SearchMax(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < 8; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

string СheckEven(int[] arr)
{
    string even = "";
    for (int i = 0; i < 8; i++)
    {
        if (arr[i] % 2 != 0)
        {
            even = "Присутствуют не четные числа";
        }
    }
    if (even == "")
    {
        even = "все элементы четные";
    }
    return even;
}

string СheckIncrease(int[] arr)
{
    string increase = "";
    for (int i = 1; i < 8; i++)
    {
        if (arr[i] < arr[i - 1])
        {
            increase = "Числа расположены не по возрастанию";
        }
    }
    if (increase == "")
    {
        increase = "Все числа расположены по возрастанию";
    }
    return increase;
}

