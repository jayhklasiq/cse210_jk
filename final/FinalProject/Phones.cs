using System;
using System.Collections.Generic;
public class Phones : Product
{
  private string filepath = "phones.txt";
  private List<Product> _phonesAvailable = new List<Product>();

  public override void LoadDataFromFile()
  {
    string[] lines = File.ReadAllLines(filepath);
    for (int i = 1; i < lines.Length; i++)
    {
      string line = lines[i];
      string[] parts = line.Split("|");
      string phoneBrand = parts[0].Trim();
      string phoneName = parts[1].Trim();
      string phoneColor = parts[2].Trim();
      string pPrice = parts[3].Trim().Replace("$", "");
      int phonePrice = int.Parse(pPrice);
      string pQuantity = parts[4].Trim();
      int phoneQuantity = int.Parse(pQuantity);

      Product product = new Product();

      product.SetBrand(phoneBrand);
      product.SetName(phoneName);
      product.SetColor(phoneColor);
      product.SetPrice(phonePrice);
      product.SetQuantity(phoneQuantity);

      _phonesAvailable.Add(product);
    }
  }

  public override void DisplayProducts()
  {
    LoadDataFromFile();
    base.DisplayProducts();
    Console.WriteLine("----------PHONE CATALOG----------");
    Console.WriteLine();
    Console.WriteLine("BRAND - PHONE - COLOR - PRICE - QUANTITY");
    for (int i = 0; i < _phonesAvailable.Count; i++)
    {
      Product phoneProduct = _phonesAvailable[i];
      Console.WriteLine($"{i + 1}. [{phoneProduct.GetBrand()}] - {phoneProduct.GetName()} - {phoneProduct.GetColor()} - {phoneProduct.GetPrice()} - {phoneProduct.GetQuantity()}pcs left");
    }

    ShoppingCart addProduct = new ShoppingCart();
    Console.WriteLine();
    Console.Write("Select a product: ");
    if (int.TryParse(Console.ReadLine(), out int selectedOption))
    {
      if (selectedOption >= 1 && selectedOption <= _phonesAvailable.Count)
      {
        Product selectedPhone = _phonesAvailable[selectedOption - 1];
        if (selectedPhone.GetQuantity() > 0)
        {
          // Add selected watch details to the shopping cart
          Product productToAdd = new Product();
          productToAdd.SetBrand(selectedPhone.GetBrand());
          productToAdd.SetName(selectedPhone.GetName());
          productToAdd.SetPrice(selectedPhone.GetPrice());
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

          // Subtract 1 from the quantity of the selected phone
          selectedPhone.SetQuantity(selectedPhone.GetQuantity() - 1);

          // Update the text file with the new quantity value
          UpdateQuantityInFile(selectedPhone);
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

  private void UpdateQuantityInFile(Product phone)
  {
    string[] lines = File.ReadAllLines(filepath);
    for (int i = 1; i < lines.Length; i++)
    {
      string line = lines[i];
      string[] parts = line.Split("|");
      string phoneBrand = parts[0].Trim();
      string phoneName = parts[1].Trim();

      if (phone.GetBrand() == phoneBrand && phone.GetName() == phoneName)
      {
        int updatedQuantity = phone.GetQuantity();
        parts[4] = updatedQuantity.ToString();

        lines[i] = string.Join("|", parts);
        File.WriteAllLines(filepath, lines);
        break;
      }
    }
  }

}