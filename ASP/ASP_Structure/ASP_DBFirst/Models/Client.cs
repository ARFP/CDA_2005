using System;
using System.Collections.Generic;

#nullable disable

namespace ASP_DBFirst.Models
{
    public partial class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int? EtsId { get; set; }
        public int? FoyerId { get; set; }
        public int CompagnieId { get; set; }

        public virtual Compagny Compagnie { get; set; }
        public virtual Entreprise Ets { get; set; }
        public virtual Foyer Foyer { get; set; }
    }
}
