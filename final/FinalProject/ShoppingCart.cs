// namespace OnlineStore;

public class ShoppingCart : Product
{
  public List<Product> _productsInCart = new List<Product>();
  private int _numOfItemsInCart = 0;
  private int _totalPrice = 0;

  public void DisplayCart()
  {
    string cartFile = "cartItem.txt";

    if (File.Exists(cartFile))
    {
      Console.WriteLine("----------SHOPPING CART----------");
      Console.WriteLine("BRAND - ITEM - PRICE");

      string[] lines = File.ReadAllLines(cartFile);
      foreach (string line in lines)
      {
        string[] parts = line.Split("|");
        string brand = parts[0];
        string itemName = parts[1];
        string p = parts[2];
        int price = int.Parse(p);

        Console.WriteLine($"[{brand}] - {itemName} - ${price}");
        _numOfItemsInCart++;
        _totalPrice += price;
      }
        Console.WriteLine($"Total:      ${_totalPrice}");
        Console.WriteLine();
        Console.WriteLine($"You have {_numOfItemsInCart} items in your cart.");
    }
    else
    {
      Console.WriteLine("Your shopping cart is empty.");
    }
  }

  public void SaveItemsToCartFile()
  {
    string filename = "cartItem.txt";
    List<string> lines = new List<string>();

    foreach (Product product in _productsInCart)
    {
      string brand = product.GetBrand();
      string name = product.GetName();
      string price = product.GetPrice().ToString();

      string itemDetails = $"{brand} - {name} - {price}";
      lines.Add(itemDetails);
    }

    File.WriteAllLines(filename, lines);
    Console.WriteLine("Items saved to cartItem.txt.");
  }

}