internal class Program
{
    private static void Main(string[] args)
    {
        //jagged array
        int[][] jaggedArray = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } };

        int[][] jaggedArray2 = new int[3][];
        jaggedArray2[0] = new int[3] { 1, 2, 3 };
        jaggedArray2[1] = new int[2] { 4, 5 };
        jaggedArray2[2] = new int[3] { 6, 7, 8 };

        for (int i = 0; i < jaggedArray2.Length; i++)
        {
            Console.Write($"Element {i} array:");

            for(int j = 0; j < jaggedArray2[i].Length; j++)
            {
                Console.Write(jaggedArray2[i][j] + " ");
            }
            Console.WriteLine();
        }

        //to find the smallest and largest number in a array
        int[] array = [1, 2, 4, 7, 10, -20, 500, -100, 250, 499, 501];
        int largest = int.MinValue;
        int smallest = int.MaxValue;
        foreach(int number in array)
        {
            if(number > largest)
            {
                largest = number;
            }
            if(number < smallest)
            {
                smallest = number;
            }
        }
        Console.WriteLine($"smallest no: {smallest} and the largest no: {largest}");

        //to perform linear search
        int target = 10;
        bool isfound = false;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] == target)
            {
                isfound = true;
                Console.WriteLine($"Target found at index {i}");
                break;
            }
        }
        if(!isfound)
            Console.WriteLine($"not found {-1}");

        //Reverse an array
        int start = 0;
        int end = array.Length - 1;
        int temp;
        int[] reversedArray = array;
        while (start < end)
        {
            temp = reversedArray[start];
            reversedArray[start] = reversedArray[end];
            reversedArray[end] = temp;

            start++;
            end--;
        }
        Console.WriteLine("Reversed Array");
        foreach(int number in reversedArray)
        {
            Console.Write(number + " ");
        }



        string[] orderID = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

        foreach (string id in orderID)
        {
            if(id.StartsWith("B"))
            {
                System.Console.WriteLine(id);
            }
        }


        int largest2 = 0;
        int secondLargest2 = 0;
        foreach (int number in array)
        {
            if (number > largest2) { 
                secondLargest2 = largest2;
                largest2 = number;
            }
            else if (number > secondLargest2 && number < largest2)
            {
                secondLargest2 = number;
            }
        }
        System.Console.WriteLine($"Largest: {largest2}, Second Largest: {secondLargest2}");

        int sum = 0, a = 10, b = 15;

        for(int i = 0;i <5; i++)
        {
            sum += a * b;
            Console.WriteLine(sum );
        }
    }
}