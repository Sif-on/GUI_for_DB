using System;
using System.Collections.Generic;

namespace GUI_for_DB
{
    public partial class Instruction
    {
        public Instruction()
        {
            Drugs = new HashSet<Drug>();
        }

        public int Id { get; set; }
        public int Age { get; set; }
        public int OnceDay { get; set; }
        public string Restrictions { get; set; }

        public virtual ICollection<Drug> Drugs { get; set; }
    }
}
