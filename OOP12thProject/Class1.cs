using System;
using System.Runtime.CompilerServices;

public class CLient
{
    public string ClientID { get; set; }
    public string ClientName { get; set; }
    public string ClientMail { get; set; }
    public string ClientPassword { get; set; }
    public string OldFlights { get; set; }
    public string getflights { get; set; }
    private decimal visacard;
    public decimal Visacard
    {
        get
        {
            return visacard;
        }
        set
        {
            if (value > 0)
            {
                visacard = value;
            }
        }
    }
    public CLient()
    {
    }
    public bool IsValid()
    {
        return !string.IsNullOrWhiteSpace(ClientName) &&
               IsValidEmail(ClientMail) &&
               IsValidNationalId(ClientID);
        // You can add more validation checks for ClientPassword, etc. as needed
    }
    

    private static bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }

    private static bool IsValidNationalId(string nationalId)
    {
        return nationalId.Length == 14 && nationalId.All(char.IsDigit);
    }
    public bool isValidSign()
    {
        return !string.IsNullOrWhiteSpace(ClientName) &&
              IsValidEmail(ClientMail);
    }

public void login()
    {
        Console.WriteLine("Enter Your Name");
        string n = Console.ReadLine();
        ClientName = n;
        Console.WriteLine("enter your mail");
        string email = Console.ReadLine();
        ClientMail = email;
        Console.WriteLine("enter your password");
        string password = Console.ReadLine();
        ClientPassword = password;
        Console.WriteLine($"welcome back to tayarni {ClientName}");
    }
    public void signin()
    {
        Console.WriteLine("Enter Your Name");
        string n = Console.ReadLine();
        ClientName = n;
        Console.WriteLine("enter your mail");
        string email = Console.ReadLine();
        ClientMail = email;
        Console.WriteLine("enter your password\n password must contains letters and numbers");
        string password = Console.ReadLine();
        ClientPassword = password;
        Console.WriteLine("enter your national id \n it must contain 14 numbers");
        string NationalId = Console.ReadLine();
        ClientID = NationalId;
        Console.WriteLine($"welcome to tayarni {ClientName}");
    }
    public void ChangePassword()
    {
        Console.WriteLine("Write the new Password");
        string b = Console.ReadLine();
        CLient a = new CLient();
        a.ClientPassword = b;
    }
    public void PaymentMethod()
    {
        Console.WriteLine("choose your preferred Payment Method\n 1-Visa\n 2-Pay in the Nearest Branch");
        int x = int.Parse(Console.ReadLine());
        if (x == 1)
        {
            Console.WriteLine("enter your visa number");
            string a = Console.ReadLine();
            Console.WriteLine("enter your visa password");
            string b = Console.ReadLine();
            Console.WriteLine("just wait a few seconds");
            CLient m = new CLient();
            Random random = new Random();
            int delayInSeconds = random.Next(5, 8);
            Thread.Sleep(delayInSeconds * 1000);
            if (m.Visacard > 4000)
            {
                Console.WriteLine("Payment Confirmed ");
            }
            else
            {
                Console.WriteLine("payment cannot be confirmed");
            }

        }
    }
    public void searchflights()
    {
        Console.WriteLine("enter your needed flights");
        string h = Console.ReadLine();
    }
}


