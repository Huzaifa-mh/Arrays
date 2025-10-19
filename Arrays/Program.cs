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
    }
}