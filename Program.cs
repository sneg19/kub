// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int one = 1;
while (one <= number)
{
    int num1 = Convert.ToInt32(Math.Pow(one, 3));
    Console.WriteLine(num1);
    one++;
}

