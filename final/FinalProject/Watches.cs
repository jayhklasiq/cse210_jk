public class Watch : Product
{
  private List<Product> _watchesAvailable = new List<Product>();
  private string filepath = "watches.txt";
  public override void LoadDataFromFile()
  {
    // filepath = "watches.txt";
    string[] lines = File.ReadAllLines(filepath);
    for (int i = 1; i < lines.Length; i++)
    {
      string line = lines[i];
      string[] parts = line.Split("|");
      string watchBrand = parts[0].Trim();
      string watchName = parts[1].Trim();
      string watchColor = parts[2].Trim();
      string wQuantity = parts[4].Trim();
      int watchQuantity = int.Parse(wQuantity);
      string wPrice = parts[3].Trim().Replace("$", "");
      int watchPrice = int.Parse(wPrice);
      Product product = new Product();

      product.SetBrand(watchBrand);
      product.SetName(watchName);
      product.SetColor(watchColor);
      product.SetPrice(watchPrice);
      product.SetQuantity(watchQuantity);

      _watchesAvailable.Add(product);
    }
  }
  public override void DisplayProducts()
  {
    LoadDataFromFile();
    base.DisplayProducts();
    Console.WriteLine("----------WATCH CATALOG----------");
    Console.WriteLine();
    Console.WriteLine("BRAND - DESIGN NAME - COLOR - PRICE - QUANTITY");
    for (int i = 0; i < _watchesAvailable.Count; i++)
    {
      Product watchProduct = _watchesAvailable[i];
      Console.WriteLine($"{i + 1}. [{watchProduct.GetBrand()}] - {watchProduct.GetName()} - {watchProduct.GetColor()} - {watchProduct.GetPrice()} - {watchProduct.GetQuantity()}pcs left");
    }

    ShoppingCart addProduct = new ShoppingCart();
    Console.WriteLine();
    Console.Write("Select a product: ");
    if (int.TryParse(Console.ReadLine(), out int selectedOption))
    {
      if (selectedOption >= 1 && selectedOption <= _watchesAvailable.Count)
      {
        Product selectedWatch = _watchesAvailable[selectedOption - 1];
        if (selectedWatch.GetQuantity() > 0)
        {
          // Add selected watch details to the shopping cart
          Product productToAdd = new Product();
          productToAdd.SetBrand(selectedWatch.GetBrand());
          productToAdd.SetName(selectedWatch.GetName());
          productToAdd.SetPrice(selectedWatch.GetPrice());
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

          // Subtract 1 from the quantity of the selected watch
          selectedWatch.SetQuantity(selectedWatch.GetQuantity() - 1);

          // Update the text file with the new quantity value
          UpdateQuantityInFile(selectedWatch);
        }
        else
        {
          Console.WriteLine("Selected watch is out of stock.");
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

  private void UpdateQuantityInFile(Product watch)
  {
    string[] lines = File.ReadAllLines(filepath);
    for (int i = 1; i < lines.Length; i++)
    {
      string line = lines[i];
      string[] parts = line.Split("|");
      string watchBrand = parts[0].Trim();
      string watchName = parts[1].Trim();

      if (watch.GetBrand() == watchBrand && watch.GetName() == watchName)
      {
        int updatedQuantity = watch.GetQuantity();
        parts[4] = updatedQuantity.ToString();

        lines[i] = string.Join("|", parts);
        File.WriteAllLines(filepath, lines);
        break;
      }
    }
  }
}