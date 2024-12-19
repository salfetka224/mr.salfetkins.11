using System;

public class User
{
    public string Username { get; set; }
    public Profile UserProfile { get; set; }

    public class Profile
    {
        public string Address { get; set; }
        public string Phone { get; set; }

        public void DisplayProfile()
        {
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Phone: {Phone}");
        }
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine($"Username: {Username}");
        UserProfile.DisplayProfile();
    }
}