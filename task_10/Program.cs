// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет 





internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число");
        string numbersStr1 = Console.ReadLine();
        int numbers = Convert.ToInt32(numbersStr1);

        if (!(numbers != 7 && numbers != 6))
        {
            Console.WriteLine("Выходной");
        }
        else
        {
            Console.WriteLine("на работу");
        }
    }
}