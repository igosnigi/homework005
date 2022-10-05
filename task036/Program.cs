//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();

int[] array = new int[5];
FillArray(array);
PrintArray(array);

int sum = 0;

Console.WriteLine(" ");

Sum(array);
Console.WriteLine(sum);


void FillArray(int[] array)
{
    Random rand = new Random();
for (int i = 0; i < 5; i++)
{
    array[i] = rand.Next(-100, 101);
}
}

void PrintArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void Sum (int[] array)
{
    for (int i = 1; i < array.Length; i=i+2)
    {
        sum += array[i]; 
    }
}