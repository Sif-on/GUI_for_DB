using System;
using System.Collections.Generic;

namespace GUI_for_DB
{
    public partial class Receipt
    {
        public int Id { get; set; }
        public int IdPharmacy { get; set; }
        public int IdClient { get; set; }
        public int IdProduct { get; set; }
        public DateOnly Date { get; set; }
        public int Sum { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual Pharmacy IdPharmacyNavigation { get; set; }
        public virtual Drug IdProductNavigation { get; set; }
    }
}
