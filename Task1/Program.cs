// Задание 1
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// Решение 
using System.Transactions;

class Program 
{ 
    static void Main() 
    { 
        Console.Write("Введите значение M: "); 
        int M = Convert.ToInt32(Console.ReadLine()); 
 
        Console.Write("Введите значение N: "); 
        int N = Convert.ToInt32(Console.ReadLine()); 
 
        PrintNaturalNumbers(M, N); 
    } 
 
    static void PrintNaturalNumbers(int current, int N) 
    { 
        if (current < 0)
        {
        current = 0;
        } 
        if (current <= N) 
        { 
            Console.Write(current + " "); 
            PrintNaturalNumbers(current + 1, N); 
        } 
    } 
}


