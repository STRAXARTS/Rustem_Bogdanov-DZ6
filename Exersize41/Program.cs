// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
Console.Write("Введите количество вводимых чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int [] array = new int [M];
for (int i = 0; i <= M-1; i++)
{
    Console.Write($"Введите {i+1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Массив введённых чисел: [{string.Join(", ", array)}]");
int count = 0;
for (int i = 0; i <= M-1; i++)
{
    if (array[i] > 0) count++;
}
Console.Write($"Количество положительных чисел: {count}");
