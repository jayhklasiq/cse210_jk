public class Order
{
  private DateTime _orderDate = DateTime.Now;
  private string _shippingAddress;

  public void PlaceOrder()
  {
    Console.WriteLine();
    Console.WriteLine("What is your shipping address: ");
    _shippingAddress = Console.ReadLine();
    if (_shippingAddress != null)
    {
      Console.WriteLine("Thank you for shopping at JK Mall. Your order is being processed.");
      Console.WriteLine("Proceed to payment.");
    }
  }
}