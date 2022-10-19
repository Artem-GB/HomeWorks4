//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*
double Fdegree (double num1, double num2)
{
        return Math.Sqrt(Math.Pow(num1 * num1, num2));
}
Console.WriteLine("input number 1");
double num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number 2");
double num2 = Convert.ToInt32(Console.ReadLine());
double result = Fdegree(num1, num2);
Console.WriteLine($"Число {num1} в степени {num2} = {result}");
*/


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*
int SumNumber (int num)
{
    int sum = 0;
    for(int i = num; i > 1; i = i/10)
    {
        sum = sum + i % 10;
    }
    return sum;
}

Console.Write("Input number:");
int num = Convert.ToInt32(Console.ReadLine());

int sum = SumNumber(num);
Console.WriteLine($"Сумма цифр в числе {num} равна {sum}");
*/


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue +1);
    }
    return myArray;
}

void ShowArray(int[] array)
{
    Console.Write("Получившийся массив -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Массив будет равен 8 эелементам, далее задайте его значения:");
Console.WriteLine("Введите минимальное значение элемента:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента:");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateArray(8, min, max);
ShowArray(myArray);
