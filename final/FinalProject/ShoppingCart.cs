// namespace OnlineStore;

public class ShoppingCart : Product
{
  public List<Product> _productsInCart = new List<Product>();
  private int _numOfItemsInCart = 0;
  public int IncrementNumOfItemsInCart()
  {
    _numOfItemsInCart = 0; // Reset the count to 0

    foreach (Product product in _productsInCart)
    {
      _numOfItemsInCart++; // Increment by 1 for each item in the cart
    }
    return _numOfItemsInCart;
  }
  public float GetNumOfItemsInCart()
  {
    return _numOfItemsInCart;
  }

  public void DisplayCart()
  {
    Console.WriteLine("Items in Cart:");
    foreach (Product items in _productsInCart)
    {
      if (items != null)
      {
        string brand = items.GetBrand();
        string name = items.GetName();
        string price = items.GetPrice().ToString();

        string itemDetails = $"{brand} - {name} - {price}";

        Console.WriteLine(itemDetails);
      else
        {
          Console.WriteLine("You have no item in cart.");
        }
      }
    }
  }