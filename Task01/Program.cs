

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
