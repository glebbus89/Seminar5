// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных элементов массива.

// Генерировать массив наполненый случайными числами

/*int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных элементов массива.
*/
/*int GetSumOfNegatives(int[] array)
{
    int sum = 0;

    for (int i=0; i < array.Length; i++)
        if (array[i] < 0) 
            sum += array[i];
    
    return sum;
}

Console.Write("Input a quanity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

Console.Write($"Sum of negative elements is " + GetSumOfNegatives(myArray));
*/


// Task 1. Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

/*int[] MakePositive(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = array[i] * (-1);
            
    return array;
}
Console.Write("Input a quanity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
MakePositive(myArray);
ShowArray(myArray);
*/



// Task 2. Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

/*bool HaveChosenNumber (int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) 
        {
        Console.WriteLine($"There is such number in the current array.");
        return true;
        }
    }
    Console.WriteLine($"There is NO such number in the current array.");
    return false; 
}

Console.Write("Input a quanity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input chousen number, please: ");;
int chousenNum = Convert.ToInt32(Console.ReadLine());

int [] array = CreateRandomArray(size, min, max);
ShowArray(array);
HaveChosenNumber(chousenNum, array);
*/

// Задайте одномерный массив из m случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [a,b].


// Homework. Task 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

/*Console.WriteLine("Input lenght array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
RandonNumbers(num);
Console.WriteLine("In array: ");
PrintArray(num);

void RandonNumbers(int[] num)
{
    for(int i = 0; i < size; i++)
    {
        num[i] = new Random().Next(100,1000);
    }
}
int count = 0;

for (int i = 0; i < num.Length; i++)
{
if (num[i] % 2 == 0)
count++;
}
Console.WriteLine($"из {num.Length} чисел, {count} четных");


void PrintArray(int[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/

// Task 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/


// Task 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

/*Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/