// Задча 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Для решения задания использование цикла for является обязательным условием

int Summa(int number)
{
    string StrNumber = number.ToString();
    int sum = 0;
    for (int i = 0; i < StrNumber.Length; i++)
    {
        sum = sum + Convert.ToInt32(StrNumber[i].ToString());
    }
    return sum;
}

Console.WriteLine("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
    Console.WriteLine("Введено некорректное число");
    return;
}
else
{
    Console.WriteLine($"Сумма цифр в числе {number}={Summa(number)}");
}