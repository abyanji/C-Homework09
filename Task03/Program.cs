// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

uint DataEntry(string message)
{
    System.Console.Write(message);
    uint num = uint.Parse(Console.ReadLine());
    return num;
}

uint Ackermann(uint n, uint m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if ((n != 0) && (m == 0))
    {
        return Ackermann(n - 1, 1);
    }
    else
    {
        return Ackermann(n - 1, Ackermann(n, m - 1));
    }
}

uint n = DataEntry("Enter the N ");
uint m = DataEntry("Enter the M ");
uint meaningAckermann = Ackermann(n, m);
System.Console.WriteLine($"Ackermann function for numbers ({n},{m}) = {meaningAckermann}");