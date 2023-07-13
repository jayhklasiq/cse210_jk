public class Shoes : Product
{
  private List<Product> _shoesAvailable = new List<Product>();
  private string filepath = "shoes.txt";
  private float _size;
  public float GetShoeSize()
  {
    return _size;
  }
  public void SetShoeSize(float shoeSize)
  {
    _size = shoeSize;
  }

  public override void LoadDataFromFile()
  {
    string[] lines = File.ReadAllLines(filepath);
    for (int i = 1; i < lines.Length; i++)
    {
      string line = lines[i];
      string[] parts = line.Split("|");
      string shoeBrand = parts[0].Trim();
      string shoeName = parts[1].Trim();
      string shoeColor = parts[2].Trim();
      string sSize = parts[3].Trim();
      float shoeSize = float.Parse(sSize);
      string sPrice = parts[4].Trim().Replace("$", "");
      int shoePrice = int.Parse(sPrice);
      string sQuantity = parts[5].Trim();
      int shoeQuantity = int.Parse(sQuantity);

      Shoes shoe = new Shoes();

      shoe.SetBrand(shoeBrand);
      shoe.SetColor(shoeColor);
      shoe.SetName(shoeName);
      shoe.SetShoeSize(shoeSize);
      shoe.SetPrice(shoePrice);
      shoe.SetQuantity(shoeQuantity);

      _shoesAvailable.Add(shoe);
    }
  }

  public override void DisplayProducts()
  {
    LoadDataFromFile();
    base.DisplayProducts();
    Console.WriteLine("----------SHOE CATALOG----------");
    Console.WriteLine();
    Console.WriteLine("BRAND - TYPE - COLOR - SIZE - PRICE - QUANTITY");
    for (int i = 0; i < _shoesAvailable.Count; i++)
    {
      Shoes shoe = (Shoes)_shoesAvailable[i];
      Console.WriteLine($"{i + 1}. [{shoe.GetBrand()}] - {shoe.GetName()} - {shoe.GetColor()} - {shoe.GetShoeSize()} - {shoe.GetPrice()} - {shoe.GetQuantity()}pcs left");
    }

    ShoppingCart addProduct = new ShoppingCart();
    Console.WriteLine();
    Console.Write("Select a product: ");
    if (int.TryParse(Console.ReadLine(), out int selectedOption))
    {
      if (selectedOption >= 1 && selectedOption <= _shoesAvailable.Count)
      {
        Shoes selectedShoe = (Shoes)_shoesAvailable[selectedOption - 1];
        if (selectedShoe.GetQuantity() > 0)
        {
          // Add selected shoe details to the shopping cart
          Product productToAdd = new Product();
          productToAdd.SetBrand(selectedShoe.GetBrand());
          productToAdd.SetName(selectedShoe.GetName());
          productToAdd.SetPrice(selectedShoe.GetPrice());
          addProduct._productsInCart.Add(productToAdd);

          string cartFile = "cartItem.txt";
          using (StreamWriter outputFile = File.AppendText(cartFile))
          {
            foreach (Product product in addProduct._productsInCart)
            {
              outputFile.WriteLine($"{product.GetBrand()}|{product.GetName()}|{product.GetPrice()}");
            }
          }

          // addProduct.IncrementNumOfItemsInCart();
          Console.WriteLine("Product added to the cart successfully.");
          Console.WriteLine();

          // Subtract 1 from the quantity of the selected shoe
          selectedShoe.SetQuantity(selectedShoe.GetQuantity() - 1);

          // Update the text file with the new quantity value
          UpdateQuantityInFile(selectedShoe);
        }
        else
        {
          Console.WriteLine("Selected shoe is out of stock.");
        }
      }
      else
      {
        Console.WriteLine("Invalid option selected.");
      }
    }
    else
    {
      Console.WriteLine("Invalid input. Please enter a valid option.");
    }
  }

  private void UpdateQuantityInFile(Shoes shoe)
  {
    string[] lines = File.ReadAllLines(filepath);
    for (int i = 1; i < lines.Length; i++)
    {
      string line = lines[i];
      string[] parts = line.Split("|");
      string shoeBrand = parts[0].Trim();
      string shoeName = parts[1].Trim();

      if (shoe.GetBrand() == shoeBrand && shoe.GetName() == shoeName)
      {
        int updatedQuantity = shoe.GetQuantity();
        parts[5] = updatedQuantity.ToString();

        lines[i] = string.Join("|", parts);
        File.WriteAllLines(filepath, lines);
        break;
      }
    }
  }

}
