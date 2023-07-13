// namespace OnlineStore;
public class Product
{
  private string _brand;
  private string _name;
  private string _color;
  private int _price;
  private int _quantity;
  private int _numOfItemsInCart = 0;
  private int _totalPrice = 0;

  public int GetTotalPrice()
  {
    return _totalPrice;
  }
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

  public virtual void DisplayProducts()
  {
    Console.WriteLine("Using the number selection, add your preferred product to yoru cart.");
    Console.WriteLine();
  }

  public virtual void LoadDataFromFile()
  {
    // Implement the generic load data logic here
  }

  public virtual void DisplayCart()
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
