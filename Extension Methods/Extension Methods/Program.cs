Console.WriteLine("Enter You DOB");
DateTime birthDate;
if (DateTime.TryParse(Console.ReadLine(), out birthDate))
{
    int age = birthDate.CalculateAge();
    Console.WriteLine($"You are {age}");
}
else
{
    Console.WriteLine("Invalid");
}

Console.WriteLine("Enter the date to check if it is a weekday");
DateTime date;
if (DateTime.TryParse(Console.ReadLine(),out date))
{
    bool isWeekday = date.IsWeekday();

    if (isWeekday)
    {
        Console.WriteLine("is weekday");
    }
    else
    {
        Console.WriteLine("is not weekday");
    }
}


public static class DateTimeExtensions
{
    public static int CalculateAge(this DateTime birthDate)
    {
        var today = DateTime.Today;
        int age = today.Year - birthDate.Year;

        if (birthDate.Date > today.AddYears(-age))
        {
            age--;
        }
        return age;
    }

    public static bool IsWeekday(this DateTime date)
    {
        DayOfWeek dayOfWeek = date.DayOfWeek;
        return dayOfWeek >= DayOfWeek.Monday && dayOfWeek <= DayOfWeek.Friday;
    }
}