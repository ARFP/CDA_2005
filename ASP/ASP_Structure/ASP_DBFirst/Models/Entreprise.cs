using System;
using System.Collections.Generic;

#nullable disable

namespace ASP_DBFirst.Models
{
    public partial class Entreprise
    {
        public Entreprise()
        {
            Clients = new HashSet<Client>();
        }

        public int EtsId { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
