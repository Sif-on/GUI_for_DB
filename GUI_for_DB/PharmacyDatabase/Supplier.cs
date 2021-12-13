using System;
using System.Collections.Generic;

namespace GUI_for_DB
{
    public partial class Supplier
    {
        public Supplier()
        {
            Drugs = new HashSet<Drug>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Drug> Drugs { get; set; }
    }
}
