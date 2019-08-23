using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
  public abstract class ATruePizza
  {
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public decimal Price { get; set; }
    public List<Topping> Toppings { get; set; }

    public ATruePizza(string c, string s)
    {
      Crust = new Crust(c);
      Size = new Size(s);
    }

    public decimal SMALLPRICE = 5.99M;

    public decimal MEDIUMPRICE = 8.99M;

    public decimal LARGEPRICE = 11.99M;

    public decimal XLARGEPRICE = 14.99M;


    public override string ToString()
    {
      CalculatePrice();
      return $"{Crust.Name} {Size.Name} ${Price}";
    }

    public void CalculatePrice()
    {
      if (Size.Name.Equals("Small"))
      {
        Price = SMALLPRICE;
      } else if (Size.Name.Equals("Medium"))
      {
        Price = MEDIUMPRICE;
      } else if (Size.Name.Equals("Large"))
      {
        Price = LARGEPRICE;
      } else if (Size.Name.Equals("Extra Large"))
      {
        Price = XLARGEPRICE;
      }
    }
  }
}
