using System;
using System.Collections.Generic;

namespace GUI_for_DB
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int IdPosition { get; set; }

        public virtual Position IdPositionNavigation { get; set; }
        public virtual Pharmacy Pharmacy { get; set; }
    }
}
