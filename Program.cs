// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Clear();
int Prompt(string message)
{
    System.Console.Write($"{message} ");
    return int.Parse(Console.ReadLine());
}

int num1 = Prompt("Введите первое число:");
int num2 = Prompt("Введите первое число:");

System.Console.WriteLine(Math.Pow(num1,num2));