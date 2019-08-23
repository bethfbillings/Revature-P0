using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Recipes
{
  public class NewYork : APizza
  {
    protected override void Make()
    {
      Components.Add(new Crust("NewYork"));
    }
  }
}
