internal class Program
{
    private static void Main(string[] args)
    {
        string[] orderID = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

        foreach (string id in orderID)
        {
            if(id.StartsWith("B"))
            {
                System.Console.WriteLine(id);
            }
        }

        int[] array = [1, 2, 4, 7, 10];

        int largest = 0;
        int secondLargest = 0;
        foreach (int number in array)
        {
            if (number > largest) { 
                secondLargest = largest;
                largest = number;
            }
            else if (number > secondLargest && number < largest)
            {
                secondLargest = number;
            }
        }
        System.Console.WriteLine($"Largest: {largest}, Second Largest: {secondLargest}");

        int sum = 0, a = 10, b = 15;

        for(int i = 0;i <5; i++)
        {
            sum += a * b;
            Console.WriteLine(sum);
        }
    }
}