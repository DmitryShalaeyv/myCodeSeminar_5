/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.*/

void Task_34()
{
    Console.WriteLine("Задайте длину массива");
    string size_str = Console.ReadLine();
    int size = int.Parse(size_str);
    Console.WriteLine("---------------");

    int[] CreateArray(int size, int min = 100, int max = 1000)
    {
        int[] array = new int[size];
        for(int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(min, max);
        }
        return array;
    }
    int[] arr = CreateArray(size);

    void WriteArray(int[] array)
    {
        foreach(var item in array) Console.WriteLine(item);
    }
    
    int CountEvenNumbers(int[] array)
    {
        int evenNumbers = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] % 2 == 0) evenNumbers++;
        }
        return evenNumbers;
    }
    int count = CountEvenNumbers(arr);
    WriteArray(arr);
    Console.WriteLine($"Количество четных чисел {count}");
}

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*/

void Task_36()
{
    Console.WriteLine("Задайте длину массива");
    string size_str = Console.ReadLine();
    int size = int.Parse(size_str);

    Console.WriteLine("Задайте минимальный элемент массива");
    string min_str = Console.ReadLine();
    int min = int.Parse(min_str);

    Console.WriteLine("Задайте максимальный элемент массива");
    string max_str = Console.ReadLine();
    int max = int.Parse(max_str);
    Console.WriteLine("---------------");


    int[] CreateArray(int size, int min, int max)
    {
        int[] array = new int[size];
        for(int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(min, max + 1);
        }
        return array;
    }
    int[] arr = CreateArray(size, min, max);

    void WriteArray(int[] array)
    {
        foreach(var item in array) Console.WriteLine(item);
    }

    int SumOfElements(int[] array)
    {
        int sum = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(i % 2 != 0) sum += array[i];
        }
        return sum;
    }

    int sumElements = SumOfElements(arr);
    WriteArray(arr);
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumElements}");
}

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.*/

void Task_38()
{
    Console.WriteLine("Задайте длину массива");
    string size_str = Console.ReadLine();
    int size = int.Parse(size_str);

    Console.WriteLine("---------------");

    double[] CreateArray(int size)
    {
        Random rand = new Random();
        double[] array = new double[size];
        for(int i = 0; i < size; i++)
        {
            array[i] = Math.Round(rand.NextDouble() * 100, 4);
        }
        return array;
    }
    double[] arr = CreateArray(size);

    void WriteArray(double[] array)
    {
        foreach(var item in array) Console.WriteLine(item);
    }

    double Diff(double[] array) 
    {
        double diff = array.Max() - array.Min();
        return diff;
    }

    double MaxElemArray(double[] array) 
    {
        return array.Max();
    }

    double MinElemArray(double[] array) 
    {
        return array.Min();
    }

    double diffElement = Diff(arr);
    WriteArray(arr);
    Console.WriteLine($"Max {MaxElemArray(arr)} Min {MinElemArray(arr)}->разность: {diffElement}");
}

Console.WriteLine("Введите номер задачи -> ");
string num_str = Console.ReadLine();
int num = int.Parse(num_str);
if(num == 34)
{
    Task_34();
    return;
} 
if(num == 36)
{
    Task_36();
    return;
} 
if(num == 38)
{
    Task_38();
    return;
} 
else Console.WriteLine("Неверный номер задачи");
