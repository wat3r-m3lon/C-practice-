using System;

public class MyContainer<T>
{
    private T _value;

    public void setValue(T value)
    {
        _value = value;
    }

    public T getValue()
    {
        return _value;
    }
}

public static void Swap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b;
    b = temp;
}

// Top-level statements
MyContainer<int> intContainer = new MyContainer<int>();
intContainer.setValue(30);
Console.WriteLine("int value: " + intContainer.getValue());

MyContainer<string> stringContainer = new MyContainer<string>(); // Use 'string' instead of 'String'
stringContainer.setValue("hello");
Console.WriteLine("String value: " + stringContainer.getValue());

int a = 1;
int b = 2;
Console.WriteLine($"Before: a={a}, b={b}");
Swap(ref a, ref b);
Console.WriteLine($"After: a={a}, b={b}");
