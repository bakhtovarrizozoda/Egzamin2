
var us = new User();
us.Firstname = "Bakhtovar";
us.Lastname = "Rizozoda";
us.Username = "Bakhtovar";
us.Password = 123456;

Console.WriteLine(us.Login);




public class User
{
    public string?  Firstname;
    public string?  Lastname;

    public string?  Username;
    public int  Password;
    
    public void Login()
    {
        if(Username == "Bakhtovar" && Password == 123456)
        {
            Console.WriteLine("Welcome mr " + Firstname, Lastname);
        }
        else
        {
            Console.WriteLine("Login Failed");
        }
    }

}