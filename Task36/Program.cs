/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
int sum = 0;

FillArrayRandomNumbers(numbers);
WriteArray(numbers);

for (int i = 0; i < numbers.Length; i += 2)
{
    sum = sum + numbers[i];
}
Console.WriteLine($"Cумма элементов, cтоящих на нечётных позициях, равна {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
}

void WriteArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}