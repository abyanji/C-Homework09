// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();

int DataEntry(string message)
{
    System.Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int SumFromSpecToSpec(int numOne, int numTwo)
{
    if (numTwo == numOne) return numOne;
    return SumFromSpecToSpec(numOne, numTwo + 1) + numTwo;
}

int numberOne = DataEntry("Enter the right range ");
int numberTwo = DataEntry("Enter the left range ");
System.Console.WriteLine(SumFromSpecToSpec(numberOne, numberTwo));