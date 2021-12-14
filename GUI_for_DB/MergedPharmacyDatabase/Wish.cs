using System;
using System.Collections.Generic;

namespace GUI_for_DB
{
    public partial class Wish
    {
        public int Id { get; set; }
        public int IdPharmacy { get; set; }
        public int IdClients { get; set; }
        public string Wish1 { get; set; }

        public virtual Client IdClientsNavigation { get; set; }
        public virtual Pharmacy IdPharmacyNavigation { get; set; }
    }
}
