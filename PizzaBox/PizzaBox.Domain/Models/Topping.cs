using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Topping : AComponent
  {
    public Topping(string name) : base(name) {}
  }
}