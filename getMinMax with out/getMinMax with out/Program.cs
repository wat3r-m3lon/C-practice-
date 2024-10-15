void GetMinMax(int[] numbers, out int max, out int min) {
max=numbers[0];
    min=numbers[1];
    foreach (int n in numbers) {
        if (n > max) { max = n; }
        if (n < min) { min = n; }
    }
}

int[] numbers = { 5, 6, 7, 8, 5, 2, 2 };
GetMinMax(numbers, out int max, out int min);

Console.WriteLine($"max {max}, min {min}");