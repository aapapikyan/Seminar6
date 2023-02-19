// Задача 1: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int InputInt(string message)
{
    Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}

int[] InputArray(int amount)
{
    int[] array = new int[amount];
    for (int i = 0; i < amount; i++)
    {
        array[i] = InputInt($"ВВедите числое № {i + 1}");
    }
    return array;
}

void PrintMassive(int[] array)
{
    Console.Write("Вы ввели следующие числа: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int CalculateNegative(int[] array)
{
    int  count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) {count++;}
    }
    return count;
}

int amount = InputInt("Введите количество чисел, которое хотите ввести");
if (amount > 0)
{
    int[] array = InputArray(amount);
    PrintMassive(array);
    Console.WriteLine($"Количество введенных отрицательных чисел равно {CalculateNegative(array)}");
}
else {Console.WriteLine("Количество чисел должно быть больше 0");}
