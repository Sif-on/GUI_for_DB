using System;
using System.Collections.Generic;

namespace GUI_for_DB
{
    public partial class Client
    {
        public Client()
        {
            Receipts = new HashSet<Receipt>();
            Wishes = new HashSet<Wish>();
        }

        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Receipt> Receipts { get; set; }
        public virtual ICollection<Wish> Wishes { get; set; }
    }
}
