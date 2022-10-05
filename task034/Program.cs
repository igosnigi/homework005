//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();

int[] array = new int[5];

int count = 0;

FillArray(array);
PrintArray(array);

Console.WriteLine(" ");

NewArray(array);
Console.WriteLine(count);



void FillArray(int[] array)
{
    Random rand = new Random();
for (int i = 0; i < 5; i++)
{
    array[i] = rand.Next(100, 1000);
}
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void NewArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
}