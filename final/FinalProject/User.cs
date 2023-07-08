public class User
{
    private string _username;
    private string _password;

    public User(string username, string password)
    {
        _username = username;
        _password = password;
    }
    public string GetUsername()
    {
        return _username;
    }

    public string GetPassword()
    {
        return _password;
    }
    public void SetPassword(string password)
    {
        _password = password;
    }
}
