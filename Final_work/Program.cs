// ЗАДАЧА:  Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых
// меньше либо равно 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении  не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры. ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] array1 = new string[4] { "hello", "2", "world", ":-)" };
string[] array2 = new string[array1.Length];

void SecondArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

SecondArray(array1, array2);
PrintArray(array1);
Console.WriteLine();
Console.WriteLine("Массив строк, длина которых меньше либо равно 3 символам: ");
PrintArray(array2);