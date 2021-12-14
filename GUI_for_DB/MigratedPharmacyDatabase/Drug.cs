using System;
using System.Collections.Generic;
using System.Collections;

namespace GUI_for_DB
{
    public partial class Drug
    {
        public Drug()
        {
            Discounts = new HashSet<Discount>();
            Receipts = new HashSet<Receipt>();
        }

        public int Id { get; set; }
        public int IdSupplier { get; set; }
        public int IdFarmGroup { get; set; }
        public int IdInstructions { get; set; }
        public string Name { get; set; }
        public BitArray Recipe { get; set; }
        public int? Price { get; set; }

        public virtual PharmacologicalGroup IdFarmGroupNavigation { get; set; }
        public virtual Instruction IdInstructionsNavigation { get; set; }
        public virtual Supplier IdSupplierNavigation { get; set; }
        public virtual ICollection<Discount> Discounts { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }
    }
}
