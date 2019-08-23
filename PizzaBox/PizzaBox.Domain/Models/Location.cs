using System.Collections.Generic;
using PizzaBox.Data.Entities;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Location
  {
    private readonly billings_project_0Context _db = new billings_project_0Context();
    public Address Address { get; set; }
    public Dictionary<string, int> Inventory { get; set; }
    public List<Order> Orders { get; set; }

    public Location()
    {
      Orders = new List<Order>();
      Inventory = new Dictionary<string, int>(); 
    }

    public void AddToInventory(string item)
    {
      if (Inventory.ContainsKey(item))
      {
        var count = Inventory[item];
        Inventory[item] = count + 1; 
      } 
    }

    public void OrderConsole(User u)
    {
      string confimred = "N";
      u.LogIn();
      var o = MakeOrder(u);
      while (confimred.Equals("N") || confimred.Equals("n"))
      {
        string finished = "N"; 
        while (finished.Equals("N") || finished.Equals("n"))
        {
          System.Console.WriteLine("What size would you like? (Small, Medium, Large, Extra Large");
          string size = System.Console.ReadLine();
          System.Console.WriteLine("What crust would you like? (Thin, Pan, Deep Dish, Traditional)");
          string crust = System.Console.ReadLine();
          TakeOrder(o, new CustomPizza(crust, size));
          System.Console.WriteLine("Would you like to finish your order? (Y/N)");
          finished = System.Console.ReadLine();
        }
        System.Console.WriteLine("Preview: ");
        ViewOrders();
        System.Console.WriteLine("Is this correct? (Y/N)");
        confimred = System.Console.ReadLine();
      }
      System.Console.WriteLine("Thank you for ordering!");
      ViewOrders();
    }

    public Order MakeOrder(User u)
    {
      return new Order()
      {
        Pizzas = new List<ATruePizza>(),
        Orderer = u
      };
    }

    public void TakeOrder(Order o, CustomPizza p)
    {
      p.CalculatePrice();
      _db.Pizza.Add(new Data.Entities.Pizza
      {
        Crust = new PizzaBox.Data.Entities.Crust
        {
          Name = p.Crust.Name
        },
        Size = new PizzaBox.Data.Entities.Size
        {
          Name = p.Size.Name
        },
        Price = p.Price
      });

      _db.SaveChanges();

      o.Pizzas.Add(p);
      Orders.Add(o);
    }

    public void AddToOrder(Order o, CustomPizza p)
    {
      p.CalculatePrice();
      _db.Pizza.Add(new Data.Entities.Pizza
      {
        Crust = new PizzaBox.Data.Entities.Crust
        {
          Name = p.Crust.Name
        },
        Size = new PizzaBox.Data.Entities.Size
        {
          Name = p.Size.Name
        },
        Price = p.Price
      });

      _db.SaveChanges();

      o.Pizzas.Add(p);
    }


    public void ViewOrders()
    {
      var OrderNum = 1; 
      foreach (var o in Orders)
      {
        System.Console.ForegroundColor = System.ConsoleColor.Yellow;
        System.Console.WriteLine(o.Orderer.Name.First + "'s Order:");
        System.Console.ResetColor();
        o.ViewOrder();
        OrderNum = OrderNum + 1; 
      }
    }

    public void ViewInventory()
    {
      foreach (var item in Inventory)
      {
          System.Console.WriteLine(item);
      }
    }

  }
}
