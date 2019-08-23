using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Crust : AComponent
  {
    public Crust(string Name) : base(Name) {}
    //public Crust() : base("") {}
  }
}
