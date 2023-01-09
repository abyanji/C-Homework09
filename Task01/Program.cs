// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int DataEntry(string message)
{
    System.Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int AllNumbersFromSpecToOne(int num)
{
    if (num == 1) return 1;
    System.Console.Write($"{num} ");
    return AllNumbersFromSpecToOne(num-1);
}

int number = DataEntry("Enter the number ");
System.Console.WriteLine(AllNumbersFromSpecToOne(number));
