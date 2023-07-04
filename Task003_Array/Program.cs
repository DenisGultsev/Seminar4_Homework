// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19-> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]

// ВАРИАНТ 1. Рандом

int[] arr = new int[8];
Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(100);
}

string output = string.Join(", ", arr) + " -> [" + string.Join(", ", arr) + "]";
Console.WriteLine(output);

// ВАРИАНТ 2. Ручной ввод

/*int[] arr = new int[8];
Console.WriteLine("Введите 8 элементов массива через пробел:");
string userInput = Console.ReadLine();
string[] inputArr = userInput.Split(' ');

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(inputArr[i]);
}

string output = string.Join(", ", arr) + " -> [" + string.Join(", ", arr) + "]";
Console.WriteLine(output);*/