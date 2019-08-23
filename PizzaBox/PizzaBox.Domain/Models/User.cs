using System.Collections.Generic;
using PizzaBox.Data.Entities;

namespace PizzaBox.Domain.Models
{
  public class User
  {
    private readonly billings_project_0Context _db = new billings_project_0Context();

    public Name Name { get; set; }

    public string Username { get; set; }
    
    public string Password { get; set; }
    public List<Order> Orders { get; set; }
    public Location Recent { get; set; }

    public User() {}

    public User(string fname, string lname, string uname, string password) 
    {
      Name = new Name()
      {
        First = fname,
        Last = fname
      };
      Username = uname;
      Password = password; 
    }

    public void LogIn()
    {
      System.Console.WriteLine("Welcome to our Pizza Shop!");
      System.Console.WriteLine("Are you a registered user? (Y/N)");
      string registered = System.Console.ReadLine();
      if (registered.Equals("Y") || registered.Equals("y"))
      {
        System.Console.WriteLine("Please enter your username: ");
        string uname = System.Console.ReadLine();
        System.Console.WriteLine("Please enter your password: ");
        string pword = System.Console.ReadLine();
      } else 
      {
        System.Console.WriteLine("Please enter your first name: ");
        string fname = System.Console.ReadLine();
        System.Console.WriteLine("Please enter your last name: ");
        string lname = System.Console.ReadLine();
        Name = new Name()
        {
          First = fname,
          Last = lname
        };
        System.Console.WriteLine("Please enter your desired username: ");
        Username = System.Console.ReadLine();
        string uname = Username;
        System.Console.WriteLine("Please enter your desired password: ");
        Password = System.Console.ReadLine();
        string pword = Password;
        _db.User.Add(new PizzaBox.Data.Entities.User
        {
          Username = uname,
          Passcode = pword,
          Name = new PizzaBox.Data.Entities.Name()
          {
            FirstName = fname,
            LastName = lname
          }
        });
      _db.SaveChanges();
      }
    }
  }
}