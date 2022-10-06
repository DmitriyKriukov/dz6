void task1()
{
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите общее количество чисел: ");
int[] array = FillArray();
PrintArray(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) 
    count++;
}
Console.WriteLine("Чисел больше 0: " + count);
Console.ReadKey();
}


int[] FillArray()
{
    int numbers = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[numbers];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число №{i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + String.Join("; ", array) + "]");
}


void task2()
{
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
 
 
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
 
Console.WriteLine($"Пересечение в точке: ({x}; {y})");
Console.ReadKey();
}


void Main()
{
    Console.Clear();
    Console.WriteLine("\n Выберите задачу:\n\t1 - Задача 41 \n\t2 - Задача 43 \n\t3 - Выйти");
    int num = Convert.ToInt32(Console.ReadLine()); 
    switch (num)
    {
        case 1:
            task1();
            Main();
            break;
        case 2:
            task2();
            Main();
            break;  
        case 3:
            Console.WriteLine("Конец");
            Console.ReadKey();
            break;
    }
}
Main();