using System;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            GetOrder();
        }

        static void GetOrder()
        {
          var l = new Location();
          var u = new User();
          l.OrderConsole(u);
        }
    }
}
