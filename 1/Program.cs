/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

Console.Write("Введите числа через пробел: ");
string numbers = Console.ReadLine();
string[] numbers_array = numbers.Split(' ');
int count = 0;
for (int i = 0; i < numbers_array.Length; i++)
{
    if (int.Parse(numbers_array[i]) > 0) count++;
}
Console.WriteLine($"Количество чисел больше 0 введенных с клавиатуры равно {count}.");
    
