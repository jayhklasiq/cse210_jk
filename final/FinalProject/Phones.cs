using System;
using System.Collections.Generic;
public class Phones : Product
{
  private string filepath = "phones.txt";
  private List<Product> _phonesAvailable = new List<Product>();
  private int numList = 0;
  public override void DisplayProducts()
  {
    LoadDataFromFile();
    base.DisplayProducts();

    Console.WriteLine("----------PHONE CATALOG----------");
    Console.WriteLine();
    Console.WriteLine("BRAND - PHONE - COLOR - PRICE - QUANTITY");
    foreach (Product product in _phonesAvailable)
    {
      Console.WriteLine($"{numList = numList + 1}. [{product.GetBrand()}] - {product.GetName()} - {product.GetColor()} - {product.GetPrice()} - {product.GetQuantity()}pcs left");
    }
  }

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
    }
  }
}