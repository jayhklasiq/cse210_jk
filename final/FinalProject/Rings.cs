using System;
using System.Collections.Generic;
public class Rings : Product
{
  private List<Product> _ringsAvailable = new List<Product>();
  private string _ringType;
  private string filepath = "rings.txt";

  public string GetRingType()
  {
    return _ringType;
  }
  public void SetRingType(string ringType)
  {
    _ringType = ringType;
  }
  public override void LoadDataFromFile()
  {
    string[] lines = File.ReadAllLines(filepath);
    for (int i = 1; i < lines.Length; i++)
    {
      string line = lines[i];
      string[] parts = line.Split("|");
      string ringBrand = parts[0].Trim();
      string ringName = parts[1].Trim();
      string ringType = parts[2].Trim();
      string rPrice = parts[3].Trim().Replace("$", "");
      int ringPrice = int.Parse(rPrice);
      string rQuantity = parts[4].Trim();
      int ringQuantity = int.Parse(rQuantity);

      Rings ring = new Rings();

      ring.SetBrand(ringBrand);
      ring.SetName(ringName);
      ring.SetPrice(ringPrice);
      ring.SetQuantity(ringQuantity);
      ring.SetRingType(ringType);

      _ringsAvailable.Add(ring);
    }
  }
  public override void DisplayProducts()
  {
    LoadDataFromFile();
    base.DisplayProducts();
    Console.WriteLine("----------RINGS CATALOG----------");
    Console.WriteLine();
    Console.WriteLine("BRAND - NAME - TYPE - PRICE - QUANTITY");
    for (int i = 0; i < _ringsAvailable.Count; i++)
    {
      // since ring type is not inherited from product, when I put in ring.GetRingType() or GetRingType(), I get an error.
      // so what I did was cast the Product object to Rings so that it is now stored in the ring variable.
      Rings ring = (Rings)_ringsAvailable[i];
      Console.WriteLine($"{i + 1}. [{ring.GetBrand()}] - {ring.GetName()} - {ring.GetRingType()} - {ring.GetPrice()} - {ring.GetQuantity()}pcs left");
    }

    ShoppingCart addProduct = new ShoppingCart();
    Console.WriteLine();
    Console.Write("Select a product: ");
    if (int.TryParse(Console.ReadLine(), out int selectedOption))
    {
      if (selectedOption >= 1 && selectedOption <= _ringsAvailable.Count)
      {
        Rings selectedRing = (Rings)_ringsAvailable[selectedOption - 1];
        if (selectedRing.GetQuantity() > 0)
        {
          // Add selected ring details to  the shoppign cart
          Product productToAdd = new Product();
          productToAdd.SetBrand(selectedRing.GetBrand());
          productToAdd.SetName(selectedRing.GetName());
          productToAdd.SetPrice(selectedRing.GetPrice());
          addProduct._productsInCart.Add(productToAdd);

          addProduct.IncrementNumOfItemsInCart();
          Console.WriteLine("Product added to the cart successfully.");
          Console.WriteLine($"{addProduct.GetNumOfItemsInCart()} products is in your cart.");

          // Subtract 1 from the quantity of the selected shoe
          selectedRing.SetQuantity(selectedRing.GetQuantity() - 1);

          // Update the text file with the new quantity value
          UpdateQuantityInFile(selectedRing);
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
  private void UpdateQuantityInFile(Rings ring)
  {
    string[] lines = File.ReadAllLines(filepath);
    for (int i = 1; i < lines.Length; i++)
    {
      string line = lines[i];
      string[] parts = line.Split("|");
      string ringBrand = parts[0].Trim();
      string ringName = parts[1].Trim();

      if (ring.GetBrand() == ringBrand && ring.GetName() == ringName)
      {
        int updatedQuantity = ring.GetQuantity();
        parts[4] = updatedQuantity.ToString();

        lines[i] = string.Join("|", parts);
        File.WriteAllLines(filepath, lines);
        break;
      }
    }
  }

}