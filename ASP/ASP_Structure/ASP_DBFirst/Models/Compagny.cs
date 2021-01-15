using System;
using System.Collections.Generic;

#nullable disable

namespace ASP_DBFirst.Models
{
    public partial class Compagny
    {
        public Compagny()
        {
            Clients = new HashSet<Client>();
        }

        public int CompagnieId { get; set; }
        public string CompagnieName { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
