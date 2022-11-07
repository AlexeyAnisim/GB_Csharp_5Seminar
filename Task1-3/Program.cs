Start();
void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();
        System.Console.WriteLine("Задание 1 (введите 1)");
        System.Console.WriteLine("Задание 2 (введите 2)");
        System.Console.WriteLine("Задание 3 (введите 3)");
        System.Console.WriteLine("End (если введено - 0)");
        int numTask = Convert.ToInt32(Console.ReadLine());

        switch (numTask)
        {
            case 0: return; break;
            case 1: EvenNumbers(); break;
            case 2: OddSumm(); break;
            case 3: DifferencMaxMin(); break;
            default: System.Console.WriteLine("Ошибка ввода"); break;
        }
    }
}
// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void EvenNumbers()
{
    Console.Clear();
    Console.WriteLine("Введите количество элементов массива:  ");

    int size = Convert.ToInt32(Console.ReadLine());

    int[] numbers = new int[size];

    FillArrayRandomNumbers(numbers);

    int count = 0;

    for (int i = 0; i < numbers.Length; i++)
    if (numbers[i] % 2 == 0)
    count++;

    Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

    void FillArrayRandomNumbers(int[] numbers)
    {
    for(int i = 0; i < numbers.Length; i++)
    {
    numbers[i] = new Random().Next(100,1000);
    System.Console.WriteLine(numbers[i]+" ");
    }
    }
}
// End

//Задача 36:Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

void OddSumm()
{
    Console.Clear();
    Console.WriteLine("Введите размер массива");

    int size = Convert.ToInt32(Console.ReadLine());

    int[] numbers = new int[size];
    Console.WriteLine("Массив: ");

    FillArrayRandomNumbers(numbers);

    int sum = 0;

    for (int i = 0; i < numbers.Length; i+=2)

    sum = sum + numbers[i];

    Console.WriteLine($"всего из {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

    void FillArrayRandomNumbers(int[] numbers)
    {
    for(int i = 0; i < numbers.Length; i++)
    {
    numbers[i] = new Random().Next(-100,100);
    Console.Write(numbers[i] + " ");
    }
    }
}
// End

//Задача 38:Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

void DifferencMaxMin()
{
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];

FillArrayRandomNumbers(numbers);

Console.WriteLine("Вывод массива: ");

PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
if (numbers[i] > max)
{
max = numbers[i];
}
if (numbers[i] < min)
{
min = numbers[i];
}
}
Console.WriteLine($"Максимальное значение - {max}, минимальное значение - {min}");
Console.WriteLine($"Разница между max и min - {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
for(int i = 0; i < numbers.Length; i++)
{
numbers[i] = Convert.ToDouble(new Random().Next(-100,1000));
}
}
void PrintArray(double[] numbers)
{
for(int i = 0; i < numbers.Length; i++)
{
Console.Write(numbers[i] + " ; ");
}
Console.WriteLine();
}
}
// End