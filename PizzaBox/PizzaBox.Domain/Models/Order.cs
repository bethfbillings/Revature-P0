using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Order
  {
    public List<ATruePizza> Pizzas { get; set; }
    public decimal Price { get; set; }

    public User Orderer { get; set; }

    public int COUNTLIMIT = 100;
    public decimal PRICELIMIT = 500;

    public void ComputePrice()
    {
      decimal TempPrice = 0;
      foreach (var item in Pizzas)
      {
        TempPrice = TempPrice + item.Price;
      }
      Price = TempPrice; 
    }

    public void ViewOrder()
    {
       if (CheckCount() && CheckPrice())
       {
        System.Console.WriteLine("  Pizzas: ");
        foreach (var p in Pizzas)
        {
            System.Console.WriteLine("    " + p.ToString());
        }
        ComputePrice();
        System.Console.ForegroundColor = System.ConsoleColor.Cyan;
        System.Console.WriteLine("Total: $" + Price);
        System.Console.ResetColor();
       } else if (CheckCount())
       {
         System.Console.WriteLine("This order exceeds limit of cost, please try again!");
       } else if (CheckPrice())
       {
         System.Console.WriteLine("This order exceeds limit of pizzas, please try again!");
       } else
       {
         System.Console.WriteLine("This order exceeds limit of cost and pizzas, please try again!");
       }
    }

    public bool CheckPrice()
    {
      bool check = true;
      if (Price > PRICELIMIT)
      {
        check = false; 
      }
      return check;
    }

    public bool CheckCount()
    {
      bool check = true;
      if (Pizzas.Count > COUNTLIMIT)
      {
        check = false;
      }
      return check;
    }
  }
}
