using System;

// Pass by value method
void PassByValue(int num)
{
    num = 20;  // Attempt to modify the value
    Console.WriteLine("Inside PassByValue, num: " + num);
}

// Pass by reference method
void PassByReference(ref int num)
{
    num = 20;  // Modify the original value
    Console.WriteLine("Inside PassByReference, num: " + num);
}

// Executable code (Top-level statement)
int num = 10;

// Pass by value
Console.WriteLine("Before PassByValue, num: " + num);
PassByValue(num);
Console.WriteLine("After PassByValue, num: " + num);

Console.WriteLine("----------------------------");

// Pass by reference
Console.WriteLine("Before PassByReference, num: " + num);
PassByReference(ref num);
Console.WriteLine("After PassByReference, num: " + num);
