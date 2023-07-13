public class UserData : Product
{
  private string filePath = "userdata.txt";
  Dictionary<string, string> _loginDetails = new Dictionary<string, string>();

  public void CreateUser()
  {
    Console.Write("Create Username: ");
    string username = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine("Password must have at least 6 characters with at least one number.");
    Console.Write("Create your password: ");
    string password = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(username))
    {
      Console.WriteLine("Username cannot be empty.");
      return; // Exit the method if validation fails
    }

    // Validate password
    if (password.Length < 6 || !password.Any(char.IsDigit))
    {
      Console.WriteLine("Password must have at least 6 characters with at least one number.");
      return; // Exit the method if validation fails
    }

    _loginDetails.Add(username, password);
    Console.WriteLine("User account created successfully.");
    Console.WriteLine();
    SaveDataToFile();
    User menu = new User();
    menu.Menu();
    Console.WriteLine();
  }

  public void LoginUser()
  {
    LoadDataFromFile();
    Console.Write("Enter your Username: ");
    string username = Console.ReadLine();
    if (_loginDetails.ContainsKey(username))
    {
      Console.Write("Enter your password: ");
      string password = Console.ReadLine();
      if (_loginDetails[username] == password)
      {
        Console.WriteLine("Login successful!");
        Console.Clear();
        User menu = new User();
        menu.Menu();
      }
      else
      {
        Console.WriteLine("Invalid password!");
        return;
      }
    }
    else
    {
      Console.WriteLine("Please enter a correct username.");
      return;
    }
  }

  public void UpdateDataInfo()
  {
    Console.WriteLine("1. Delete User Account");
    Console.WriteLine("2. Change Password");
    int dataOption = int.Parse(Console.ReadLine());
    LoadDataFromFile();
    switch (dataOption)
    {
      case 1:
        Console.Write("What is your username: ");
        string username = Console.ReadLine();
        if (_loginDetails.ContainsKey(username))
        {
          _loginDetails.Remove(username);
          Console.WriteLine("User account deleted successfully.");

          // Update the text file by rewriting all the data except for the deleted user account
          using (StreamWriter writer = new StreamWriter(filePath))
          {
            foreach (var kvp in _loginDetails)
            {
              writer.WriteLine($"{kvp.Key},{kvp.Value}");
            }
          }
        }
        else
        {
          Console.WriteLine("Username does not exist. Please enter the correct username.");
          return;
        }
        break;
      case 2:
        Console.Write("What is your username: ");
        username = Console.ReadLine();
        if (_loginDetails.ContainsKey(username))
        {
          Console.WriteLine("Enter old password: ");
          string oldPassword = Console.ReadLine();
          string storedPassword = _loginDetails[username];
          if (storedPassword == oldPassword)
          {
            Console.Write("Enter a new password: ");
            string newPassword = Console.ReadLine();
            _loginDetails[username] = newPassword;
            Console.WriteLine("Password updated successfully.");

            // Update the text file by rewriting all the data with the updated password
            using (StreamWriter writer = new StreamWriter(filePath))
            {
              foreach (var kvp in _loginDetails)
              {
                writer.WriteLine($"{kvp.Key},{kvp.Value}");
              }
            }
          }
          else
          {
            Console.WriteLine("Wrong passowrd. Please enter your old password.");
            return;
          }
        }
        break;
    }
  }
  private void SaveDataToFile()
  {
    using (StreamWriter writer = new StreamWriter(filePath, true))
    {
      foreach (var kvp in _loginDetails)
      {
        writer.WriteLine($"{kvp.Key},{kvp.Value}");
      }
    }
  }
  public override void LoadDataFromFile()
  {
    if (File.Exists(filePath))
    {
      _loginDetails.Clear();
      string[] lines = File.ReadAllLines(filePath);
      foreach (string line in lines)
      {
        string[] parts = line.Split(',');
        if (parts.Length == 2)
        {
          _loginDetails.Add(parts[0], parts[1]);
        }
      }
    }
  }


}