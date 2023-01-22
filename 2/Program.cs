/* Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)
в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему). */


int[] nums = new int[10];
Console.WriteLine();
Console.Write("Полученный массив: ");
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(0,100);
    Console.Write(nums[i] + " ");
}
 
int temp;
for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] > nums[j])
        {
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
Console.WriteLine();
Console.Write("Отсортированный массив: ");
for (int i = 0; i < nums.Length; i++)
{
    Console.Write(nums[i] + " ");
}