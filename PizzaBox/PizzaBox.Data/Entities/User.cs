using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Entities
{
    public partial class User
    {
        public User()
        {
            Pizza = new HashSet<Pizza>();
        }

        public int UserId { get; set; }
        public int NameId { get; set; }
        public string Username { get; set; }
        public string Passcode { get; set; }

        public virtual Name Name { get; set; }
        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}
