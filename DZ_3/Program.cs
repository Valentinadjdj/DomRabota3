using System;
// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

/*Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
void CheckThisNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Данное число: {number} - является палиндромом.");
  }
  else Console.WriteLine($"Данное число: {number} -не является палиндромом.");
}
if (number!.Length == 5){
  CheckThisNumber(number);
}
else Console.WriteLine($"Введено некорректное число");*/

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*Console.WriteLine("Введите координаты первой точки");
Console.Write("x1= ");int x1 = int.Parse(Console.ReadLine());
Console.Write("y1= ");int y1 = int.Parse(Console.ReadLine());
Console.Write("z1= ");int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("x2= ");int x2 = int.Parse(Console.ReadLine());
Console.Write("y2= ");int y2 = int.Parse(Console.ReadLine());
Console.Write("z2= ");int z2 = int.Parse(Console.ReadLine());
double distance = DistanceBeetweenpoints(x1,y1,z1,x2,y2,z2);
Console.WriteLine("Расстояние между точками равно = ");
//Console.Write(distance);
Console.Write(Math.Round (distance,2));
//double DistanceBeetween(double distance, int digits, MidpointRounding mode);
double DistanceBeetweenpoints(int x1, int x2, int y1, int y2, int z1, int z2){
    double result = Math.Sqrt(Math.Pow((x2-x1), 2) +  Math.Pow((y2-y1), 2) +  Math.Pow((z2-z1), 2));
    return result;
}*/

//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/*Console.WriteLine("Введите число: ");
Console.Write("number = ");
int n = int.Parse(Console.ReadLine());
int[] tableofcube = PrintStringCube(n);
Console.WriteLine(string.Join(" , ",tableofcube));
int [] PrintStringCube(int number){
    int []tableofcube = new int [number];
    for(int i=0;i<tableofcube.Length;i++)
    {
    int index =i+1;
     tableofcube[i] = index*index*index;
    }
    return tableofcube;
}*/

//Семинар 5
//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
//из промежутка [-9, 9]. Найдите сумму отрицательных и положительных 
//элементов массива.

/*int[] array = GenerateRandomArray(4);

Console.WriteLine(string.Join(", ", array));
// string.Join(разделитель, массив) -> строку элементов разделенные - ", "

int sumPositiveNumbers = GetSumPositiveNumbers(array);
Console.Write("Sum positive numbers = ");
Console.WriteLine(sumPositiveNumbers);
int sumNegativeNumbers = GetSumNegativeNumbers(array);
Console.Write("Sum negative numbers = ");
Console.WriteLine(sumNegativeNumbers);

int GetSumPositiveNumbers(int[] array)
{
    int sum = 0;

    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }

    return sum;
}

int GetSumNegativeNumbers(int[] array)
{
    int sum = 0;

    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }

    return sum;
}


int[] GenerateRandomArray(int length)
{
    int[] array = new int[length];

    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-9, 10);
    }

    return array;
}

//Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
int[] randomArray = GenerateRandomArray(5);

Console.WriteLine("Initial array - ");
PrintArray(randomArray);
ChangeSignOfNumbers(randomArray);
Console.WriteLine("Result array - ");
PrintArray(randomArray);

void ChangeSignOfNumbers(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        //array[i] = array[i] * (-1);
        array[i] = -array[i];
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
}
//Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

int[] Array = GenerateRandomArray(10);
PrintArray(array);

Console.Write("Введите число - ");
int number = int.Parse(Console.ReadLine());

bool result = Contains(number, array);
Console.WriteLine(result);

bool Contains(int number, int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            return true;
        }
    }

    return false;
}

Console.WriteLine(array.Contains(number));
*/
/*Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].*/

int[] array = GenerateRandomArray(10, 10, 200);

PrintArray(array);

int count = CountElementsInRange(array, 10, 99);

Console.WriteLine(count);

int CountElementsInRange(int[] array, int startOfRange, int endOfRange)
{
    int count = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if(array[i] >= startOfRange & array[i]<= endOfRange)
        {
            count++;
        }
    }

    return count;
}
void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
}

int[] GenerateRandomArray(int length,int minValue, int maxValue)
{
    int[] array = new int[length];

    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minValue,maxValue);
    }

    return array;
}

//Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.

int[] Array = GenerateRandomArray(5, 0, 10);
PrintArray(array);


MultiplyPairsInArray(array);

void MultiplyPairsInArray(int[] array)
{
    for (var i = 0; i < array.Length / 2; i++)
    {
        Console.Write(array[i] * array[array.Length - 1 - i]);
        Console.Write(" ");
    }

    if (array.Length % 2 != 0)
    {
        Console.Write(array[(array.Length) / 2]);
    }
}

//Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.

int[] array = GenerateRandomArray(6, 0, 10);
PrintArray(array);


int[] result = MultiplyPairsInArray(array);
PrintArray(result);

int[] MultiplyPairsInArray(int[] array)
{
    int[] result = new int[array.Length / 2 + array.Length % 2];
    for (var i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }

    if (array.Length % 2 != 0)
    {
        result[result.Length - 1] = array[(array.Length) / 2];
    }

    return result;
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
}

int[] GenerateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];

    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minValue, maxValue);
    }

    return array;
}



void MultiplyPairsInArray(int[] array)
{
    for (var i = 0; i < array.Length / 2; i++)
    {
        Console.Write(array[i] * array[array.Length - 1 - i]);
        Console.Write(" ");
    }

    if (array.Length % 2 != 0)
    {
        Console.Write(array[(array.Length) / 2]);
    }
}