public class Product
{
  private string _productType;
  private string _brand;
  private int _price;
  private string _description;
  private int _stockQuantity;
  private int _totalPrice;

  public virtual void CalculateTotalPrice()
  {
    // Calculate total price based on specific logic in derived classes
  }
  public void SetBrand(string brand)
  {
    _brand = brand;
  }
  public string GetBrand()
  {
    return _brand;
  }
  public void SetStockQuantity(int quantity)
  {
    _stockQuantity = quantity;
  }
  public int GetStockQuantity()
  {
    return _stockQuantity;
  }
  public virtual void DisplayProductDetails()
  {
    string x = "none";
  }

  public void ChooseCategory()
  {
    Console.WriteLine("1. Shoes");
    Console.WriteLine("2. Rings");
    Console.WriteLine("3. Phones");
    Console.WriteLine("4. Watches");
    int categoryChoice = int.Parse(Console.ReadLine());

    switch (categoryChoice)
    {
      case 1:
        Shoes shoe = new Shoes();
        shoe.DisplayProductDetails();
        break;
      case 2:
        Rings rings = new Rings();
        rings.DisplayProductDetails();
        break;
      case 3:
        Phones phones = new Phones();
        phones.DisplayProductDetails();
        break;
      case 4:
        Watches watches = new Watches();
        watches.DisplayProductDetails();
        break;
    }
  }

}