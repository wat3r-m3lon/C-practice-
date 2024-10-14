class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b) { return a + b; }

    public int Add(int a, int b, int c) { return a + b + c; }
}

Calculator c = new Calculator();
int sum1 = c.Add(1, 2);
int sum2 = c.Add(2, 3 + 4);
double sum3 = c.Add(4.2, 4.4);
Console.WriteLine(sum1);
Console.WriteLine(sum2);
Console.WriteLine(sum3);