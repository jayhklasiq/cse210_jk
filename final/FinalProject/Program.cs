using System;

class Program
{
    static void Main(string[] args)
    {
        bool quitGame = false;
        while (!quitGame)
        {
            Console.WriteLine("Welcome to JK Shopping Mart!");
            Console.WriteLine();
            Console.WriteLine("1. Shop");
            Console.WriteLine("2. Cart");
            Console.WriteLine("3. Checkout");
            Console.WriteLine("4. Account");
            Console.WriteLine("5. Quit");
            int response = int.Parse(Console.ReadLine());

            switch (response)
            {
                case 1:
                    Product product1 = new Product();
                    product1.ChooseCategory();
                    break;
                case 2:
                    // Code for response 2
                    break;
                case 3:
                    // Code for response 3
                    break;
                case 4:
                    UserData user = new UserData();
                    user.AccountToDo();
                    break;
                default:
                    // Code for other responses
                    quitGame = true;
                    Console.WriteLine("Thank you for choosing JK Mart");
                    break;
            }
        }
    }




}
