// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными ВЕЩЕСТВЕННЫМИ числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
double [,] Arr ()
{
    Console.Write("введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите количество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите миним возможное значение: ");
    int minA = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите максим возможное значение: ");
    int maxA = Convert.ToInt32(Console.ReadLine());
    
    double [,] NewA=new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j=0; j<n; j++)
        {
            NewA[i,j]= Math.Round(new Random().Next(minA, maxA+1)+new Random().NextDouble(),2); 
            //a[i] =new Random().Next(x,y+1)+ new Random().NextDouble();
        }
    }
    return NewA;
}
void Show2dArray (double[,]arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] +"  ");  
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Show2dArray(Arr());
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет

int [,] CreateRandom2dArray()
{
    Console.Write("введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите миним возможное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите максим возможное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int [,]newArray = new int[rows,columns];

    for (int i=0; i<rows; i++)
        for (int j=0; j<columns; j++)
            newArray[i,j]= new Random().Next(minValue,maxValue+1);
    return newArray;
}

void Show2dArray(int[,]array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+" ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,]myArray = CreateRandom2dArray();
Show2dArray(myArray);

void Num (int [,]A, int n, int m)
{
    if  (m>A.GetLength(0) || n>A.GetLength(1) || m<=0 || n<=0) {
        Console.WriteLine("такого числа нет");
    }
    else {
     Console.WriteLine(A[n-1,m-1]);        
    }
}
Console.Write("введите строку элемента: ");
    int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите столбец элемента: ");
    int m = Convert.ToInt32(Console.ReadLine());
Num(myArray,n,m);


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double [] SrAr (int[,]A)
{
    double[]SA=new double [A.GetLength(1)];
    
    double srar=0;
    for (int j=0; j<A.GetLength(1); j++)
    {
        double sum=0;
        for (int i=0; i<A.GetLength(0); i++)  
    {
        sum = sum+A[i,j]; 
    }
    srar=Math.Round(sum/A.GetLength(0),2);
    SA[j]=srar;
    Console.Write(srar + " ");
    } 
      return SA;  
}
SrAr(myArray);