using System;

public class OrderTests
{
    public static void RunTest()
    {
        Console.WriteLine("\nRunning Unit Test...");

        Order test = new Order("Test", 2, 6);

        double result = test.PayBill();

        if (result == 12)
            Console.WriteLine("Test Passed ");
        else
            Console.WriteLine("Test Failed ");
    }
}
