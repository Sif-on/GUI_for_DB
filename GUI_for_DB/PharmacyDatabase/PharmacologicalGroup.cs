using System;
using System.Collections.Generic;

namespace GUI_for_DB
{
    public partial class PharmacologicalGroup
    {
        public PharmacologicalGroup()
        {
            Drugs = new HashSet<Drug>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Drug> Drugs { get; set; }
    }
}
