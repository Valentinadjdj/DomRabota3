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