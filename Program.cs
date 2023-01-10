internal class Program
{
    private static void Main(string[] args)
    {

        var max = 4000000;
        var sum = 0;
        var num1 = 1;
        var num2 = 2;

        while (1 == 1)
        {
            sum = num1 + num2;
            num1 = sum;
            Console.WriteLine(sum);
            Console.ReadLine();
            sum = num1 + num2;
            num2 = sum;
            Console.WriteLine(sum);
            Console.ReadLine();
            if (sum !> 4000000)
            {
                break;
            }
        }


    }
}
    
