// namespace OnlineStore;

public class ShoppingCart : Product
{
  public List<Product> _productsInCart = new List<Product>();

  public override void DisplayCart()
  {
    base.DisplayCart();
    Console.Clear();
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