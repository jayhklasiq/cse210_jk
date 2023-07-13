using System;
class Program
{
  static void Main(string[] args)
  {
    bool quit = false;
    while (!quit)
    {
      UserData login = new UserData();
      User menu = new User();
      Console.WriteLine("Welcome to JK Shopping Mart!");
      Console.WriteLine();
      Console.WriteLine("1. Login");
      Console.WriteLine("2. Create an account");
      Console.WriteLine("3. Quit");
      int response = int.Parse(Console.ReadLine());
      Console.WriteLine();
      switch (response)
      {
        case 1:
          login.LoginUser();
          break;
        case 2:
          login.CreateUser();
          break;
        default:
          quit = true;
          Console.WriteLine("Thank you for choosing JK Mart");
          break;
      }

    }
  }
}
