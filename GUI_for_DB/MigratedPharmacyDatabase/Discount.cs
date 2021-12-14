using System;
using System.Collections.Generic;

namespace GUI_for_DB
{
    public partial class Discount
    {
        public int Id { get; set; }
        public int IdPharmacy { get; set; }
        public int IdProduct { get; set; }
        public int DiscountPercentage { get; set; }
        public DateOnly DateStart { get; set; }
        public DateOnly DateFinish { get; set; }

        public virtual Pharmacy IdPharmacyNavigation { get; set; }
        public virtual Drug IdProductNavigation { get; set; }
    }
}
