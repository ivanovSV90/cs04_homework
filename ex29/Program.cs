// Задача 29: Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] InputArray()
{
    System.Console.WriteLine("Введите 8 чисел разделяя пробелами");
    string stringArr = Console.ReadLine()!;
    string[] parts = stringArr.Split(' ');
    int[] arr = new int[8];
    for (int i = 0; i < 8; i++)
    {
        arr[i] = int.Parse(parts[i]);
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


int[] array = InputArray();
PrintArray(array);
