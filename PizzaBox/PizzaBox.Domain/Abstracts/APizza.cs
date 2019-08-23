using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class APizza
  {
    private List<AComponent> _components = new List<AComponent>();

    public List<AComponent> Components
    {
      get
      {
        return _components;
      }
    }

    protected abstract void Make();

    public APizza()
    {
      this.Make();
    }
  }
}
