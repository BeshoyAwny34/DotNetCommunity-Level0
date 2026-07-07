namespace Task5;

internal class Program
{
    static void Main(string[] args)
    {
        int FirstNumber = 5, SecondNumber = 6,SwapNumber;
        SwapNumber = FirstNumber;
        FirstNumber = SecondNumber;
        SecondNumber = SwapNumber;
        Console.WriteLine($"First Number : {FirstNumber}");
        Console.WriteLine($"Second Number : {SecondNumber}");

    }
}
