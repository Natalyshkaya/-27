// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Заполнение массива производит пользователь.

int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    Console.WriteLine($"Введите {i+1} элемент массива");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Вы ввели массив:");
for (int i = 0; i < 8; i++)
{
    Console.Write($"{array[i]} ");
}