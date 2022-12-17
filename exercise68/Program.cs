// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("even num M: ");
Console.WriteLine("positive num M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("even num N: ");
Console.WriteLine("positive num N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SummaDigits(m, n));
Console.WriteLine(AkkermanFunc(m, n));

int SummaDigits(int num1, int num2)
{
    if (num1 == num2) 
        {
            return num1;
        }   
    else if (num1 < num2)
        { 
            return num2 + SummaDigits(num1, num2 - 1);
        }
    else return num2 + SummaDigits(num1, num2 + 1);
}
int AkkermanFunc(int m, int n)
{
    if (m == 0)
        { 
            return n + 1;
        }
    else if (m > 0 && n == 0) 
        {
            return AkkermanFunc(m - 1, 1);
        }
    else return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}