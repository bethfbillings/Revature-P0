using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class CustomPizza : ATruePizza
  {
    public CustomPizza(string c, string s) : base(c, s)
    {
    }
  }
}