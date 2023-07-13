// namespace OnlineStore;
public class Product
{
  private string _brand;
  private string _name;
  private string _color;
  private int _price;
  private int _quantity;

  public string GetBrand()
  {
    return _brand;
  }
  public void SetBrand(string brand)
  {
    _brand = brand;
  }
  public string GetName()
  {
    return _name;
  }
  public void SetName(string name)
  {
    _name = name;
  }
  public string GetColor()
  {
    return _color;
  }
  public void SetColor(string color)
  {
    _color = color;
  }
  public int GetQuantity()
  {
    return _quantity;
  }
  public void SetQuantity(int quantity)
  {
    _quantity = quantity;
  }
  public int GetPrice()
  {
    return _price;
  }
  public void SetPrice(int price)
  {
    _price = price;
  }
  public virtual void CalculateTotalPrice()
  {
    // Calculate total price based on specific logic in derived classes
  }

  public virtual void DisplayProducts()
  {
    Console.WriteLine("Using the number selection, add your preferred product to yoru cart.");
    Console.WriteLine();
  }

  public virtual void LoadDataFromFile()
  {
    // Implement the generic load data logic here
  }
  protected virtual void UpdateQuantityInFile(Watch selectedRing)
  {
    // Implementation to update the quantity in the file
  }

  public void ChooseCategory()
  {
    Console.WriteLine("1. Shoes");
    Console.WriteLine("2. Rings");
    Console.WriteLine("3. Phones");
    Console.WriteLine("4. Watches");
    int categoryChoice = int.Parse(Console.ReadLine());
    Console.WriteLine();
    switch (categoryChoice)
    {
      case 1:
        Shoes shoe = new Shoes();
        shoe.DisplayProducts();
        break;
      case 2:
        Rings rings = new Rings();
        rings.DisplayProducts();
        break;
      case 3:
        Phones phones = new Phones();
        phones.DisplayProducts();
        break;
      case 4:
        Watch watches = new Watch();
        watches.DisplayProducts();
        break;
    }
  }
}
