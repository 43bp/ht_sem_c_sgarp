// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно без остатка на 2)

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine($"Число {num} - четное");
}
else
{
    Console.WriteLine($"Число {num} - нечетное");
}