// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
// Решение
    
class program
{

    static void Main()
    {
    Console.WriteLine("Введите размер массив: ");
    int size = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите минимальное число: ");
    int min = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Введите максимальное число: ");
    int max = Convert.ToInt32(Console.ReadLine());


    int [] CreateRandowArray(int size, int min, int max)        // Создаем функицю которая будет выдвавать случайный массив 
{
    int [] array = new int[size];
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)        // Создаем функцию которая будет вводить нам массив
{
    for(int i = 0; i < array.Length; i++)
    {
        Console. Write(array[i] + " ");
    }   
    Console. WriteLine();
}

int [] myArray = CreateRandowArray(size, min, max);
PrintArray(myArray);

Console.WriteLine("Элементы массива, начиная с конца:"); 
        PrintArrayReverse(myArray, myArray.Length - 1); 
    } 
 
    static void PrintArrayReverse(int[] arr, int index) 
    { 
        if (index >= 0) 
        { 
            Console.Write(arr[index] + " "); 
            PrintArrayReverse(arr, index - 1); 
        } 
    } 
}