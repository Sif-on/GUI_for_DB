using System;
using System.Collections.Generic;

namespace GUI_for_DB
{
    public partial class Pharmacy
    {
        public Pharmacy()
        {
            Discounts = new HashSet<Discount>();
            Phones = new HashSet<Phone>();
            Receipts = new HashSet<Receipt>();
            Wishes = new HashSet<Wish>();
        }

        public int Id { get; set; }
        public int IdDirector { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Hours { get; set; }

        public virtual Employee IdDirectorNavigation { get; set; }
        public virtual ICollection<Discount> Discounts { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }
        public virtual ICollection<Wish> Wishes { get; set; }
    }
}
