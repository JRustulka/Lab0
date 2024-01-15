class Program
{
    static void Main(string[] args)
    {   
        //Take input for low number
        Console.WriteLine("Please enter a positive low number: ");
        string low = Console.ReadLine();
        double lowNum = double.Parse(low);

        //Verify positive number
        while (lowNum > 0)
        {
            Console.WriteLine("Not positive. Please enter a positive low number: ");
            low = Console.ReadLine();
            lowNum = double.Parse(low);
        }

        //Take input for high number
        Console.WriteLine("Please enter a high number: ");
        string high = Console.ReadLine();
        double highNum = double.Parse(high);

        //Verify valid number
        while (lowNum > highNum)
        {
            Console.WriteLine("That number is not higher. Please enter a high number: ");
            high = Console.ReadLine();
            highNum = double.Parse(high);
        }

        //Find the difference
        double difference = highNum - lowNum;
        Console.WriteLine("The difference is " + difference);

        //Create array
        List<double> between = new List<double>();
        double iteration = lowNum;
        double total = 0;
        while (iteration < highNum)
        {
            iteration += 1;
            between.Add(iteration);
            total += iteration;
        }

        //Sorting the array
        //Array.Reverse(between);

        //Writing to file
        using(StreamWriter document = new StreamWriter("numbers.txt"))
        {
            foreach (double num in between) 
            {
                document.WriteLine(num);
            }
        }

    }
}
//Not quite done yet, but getting there
