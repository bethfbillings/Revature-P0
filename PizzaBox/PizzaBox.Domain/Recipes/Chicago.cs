using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Recipes
{
  public class Chicago : APizzaMaker
  {
    public override ATruePizza Make()
    {
      return new CustomPizza("Chicago", "Extra Large");
    }
  }
}
