using Tyuiu.AntonovDI.Sprint0.Task2.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(DataService.GetMessage("Даниил"));
        Console.ReadKey();
    }
}