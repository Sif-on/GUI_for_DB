using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_for_DB.ViewModels
{
    public class ClientsTalbeModel : TableModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Receipts { get; set; }
        public string Wishes { get; set; }
        public ClientsTalbeModel(Clients clients)
        {
            ID = clients.ID.ToString();
            Name = clients.Name;
            Surname = clients.Surname;
            Receipts = clients.Receipts.RelationshipName;
            Wishes = clients.Wishes.RelationshipName;
        }
    }
}
