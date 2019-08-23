using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Entities
{
    public partial class Pizza
    {
        public int PizzaId { get; set; }
        public int CrustId { get; set; }
        public int SizeId { get; set; }
        public decimal Price { get; set; }
        public string Username { get; set; }
        public int? UserId { get; set; }

        public virtual Crust Crust { get; set; }
        public virtual Size Size { get; set; }
        public virtual User User { get; set; }
    }
}
