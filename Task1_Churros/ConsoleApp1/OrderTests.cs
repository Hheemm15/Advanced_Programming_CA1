using System;

class OrderTests
{
    public static void TestPayBill()
    {
        Order test = new Order(1, "Test", 2, 6);

        double result = test.PayBill();

        if (result == 12)
            Console.WriteLine("Test Passed");
        else
            Console.WriteLine("Test Failed");
    }
}
