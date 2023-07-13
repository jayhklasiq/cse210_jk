public class User : Product
{
  public void Menu()
  {
    bool endProgram = false;
    while (!endProgram)
    {
      Console.WriteLine("1. Shop");
      Console.WriteLine("2. Cart");
      Console.WriteLine("3. Checkout");
      Console.WriteLine("4. Account");
      int menuResponse = int.Parse(Console.ReadLine());
      Console.Clear();
      switch (menuResponse)
      {
        case 1:
          Product shop = new Product();
          shop.ChooseCategory();
          break;
        case 2:
          ShoppingCart displayCart = new ShoppingCart();
          displayCart.DisplayCart();
          break;
        case 3:
          break;
        case 4:
          UserData dataInfo = new UserData();
          dataInfo.UpdateDataInfo();
          break;
        default:
          endProgram = true;
          Console.WriteLine("Thank you for choosing JK Mart");
          break;
      }
    }

  }
}
