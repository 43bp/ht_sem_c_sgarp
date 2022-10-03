// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.

Console.WriteLine("Введите натуральное число (N): ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
int end = num - 1;
if (num < 2)
{
    Console.WriteLine($"Четные натуральные числа в диапазоне от {num} до 1 отсутствуют");
}
else
{
    while (i < end)
    {
        i += 2;
        Console.Write(i);
        if (i < end)
        {
            Console.Write(", ");
        }
    }
}