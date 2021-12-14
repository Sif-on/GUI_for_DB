using System;
using System.Collections.Generic;

namespace GUI_for_DB
{
    public partial class Phone
    {
        public int Id { get; set; }
        public string Phone1 { get; set; }

        public virtual Pharmacy Phone1Navigation { get; set; }
    }
}
