// namespace OnlineStore;

public class ShoppingCart : Product
{
  public List<Product> _productsInCart = new List<Product>();
  private int _numOfItemsInCart;
  public void IncrementNumOfItemsInCart()
  {
    _numOfItemsInCart++;
  }
  public float GetNumOfItemsInCart()
  {
    return _numOfItemsInCart;
  }
}