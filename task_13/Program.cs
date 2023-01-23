/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
       
Console.WriteLine("Введите первое число");     
string str = Console.ReadLine();
 int amount = str.ToString().Length;

if (amount < 3 )
        {
            Console.WriteLine("третьей цифры нет");
        }
        else
{
  Console.WriteLine(str[2]);  
}


