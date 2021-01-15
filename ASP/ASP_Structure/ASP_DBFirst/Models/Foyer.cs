using System;
using System.Collections.Generic;

#nullable disable

namespace ASP_DBFirst.Models
{
    public partial class Foyer
    {
        public Foyer()
        {
            Clients = new HashSet<Client>();
        }

        public int FoyerId { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
