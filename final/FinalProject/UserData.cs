// UserData.cs
public class UserData
{
    Dictionary<string, string> _loginDetails = new Dictionary<string, string>()
    {
        { "john_doe", "c@llm3j0hn" },
        {"carryGift", "@untyG!ft" },
        { "Kilofeso", "k1l0f3so" },
        {"Doe123", "password123" },
        { "AfriCoco", "@fr!ca" }
    };

    public void AccountToDo()
    {
        Console.WriteLine("Select an option");
        Console.WriteLine();
        Console.WriteLine("1. Create User");
        Console.WriteLine("2. Login User");
        Console.WriteLine("3. Update User Data");
        int userOption = int.Parse(Console.ReadLine());
        switch (userOption)
        {
            case 1:
                CreateUser();
                break;
            case 2:
                LoginUser();
                break;
            case 3:
                UpdateDataInfo();
                break;
            default:
                Console.WriteLine("Incorrect choice, try again.");
                return;
                // break;
        }
    }

    private void CreateUser()
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
    }

    private void LoginUser()
    {
        Console.Write("Enter your Username: ");
        string username = Console.ReadLine();
        if (_loginDetails.ContainsKey(username))
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            if (_loginDetails[username] == password)
            {
                Console.WriteLine("Login successful!");
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
        Console.WriteLine();
    }

    public void UpdateDataInfo()
    {
        Console.WriteLine("1. Delete User Account");
        Console.WriteLine("2. Change Password");
        int dataOption = int.Parse(Console.ReadLine());
        switch (dataOption)
        {
            case 1:
                Console.Write("What is your username: ");
                string username = Console.ReadLine();
                if (_loginDetails.ContainsKey(username))
                {
                    _loginDetails.Remove(username);
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
                        Console.Write("Enter a new passowrd: ");
                        string nPassword = Console.ReadLine();
                        _loginDetails[username] = nPassword;
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

}