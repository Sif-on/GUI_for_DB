using System;
using System.Collections.Generic;

namespace GUI_for_DB
{
    public partial class Position
    {
        public Position()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string NamePosition { get; set; }
        public int Salary { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
