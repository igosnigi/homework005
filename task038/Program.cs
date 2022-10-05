//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();

double[] array = new double[5];
FillArray(array);
PrintArray(array);

double diff = 0;
FindDiff(array);

Console.WriteLine(" ");
Console.WriteLine("{0:f2}", diff);



void FillArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100,1001)) / 100;
        }
}

void PrintArray(double[] array)


{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void FindDiff(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    diff = max - min;
}

