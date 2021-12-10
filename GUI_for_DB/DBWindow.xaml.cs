using GUI_for_DB.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI_for_DB
{
    public partial class DBWindow : Window
    {
        public DBWindow(int Mode, string TableName)
        {
            //TableWindow init.
            InitializeComponent();

            // Test Data.
            List<ClientsTalbeModel> tablesList = new();
            
            using (PharmacyDBEntities entities = new())
            {
                List<Clients> ClientsList = entities.Clients.ToList();
                foreach (Clients client in ClientsList)
                {
                    tablesList.Add(new ClientsTalbeModel(client));
                }
                if(tablesList.Count > 0)
                    TableGrid.ItemsSource = tablesList.ToList();
                entities.Dispose();
            }

            // Mode of interacting with data
            switch (Mode)
            {
                case 0:
               
                    TableGrid.IsReadOnly = true;
                    // add.Visibility = Visibility.Collapsed;
                    break;
                case 1:
                    TableGrid.IsReadOnly = false;
                    // add.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    TableGrid.IsReadOnly = false;
                    // add.Visibility = Visibility.Collapsed;
                    break;
                case 3:
                    // TableGrid.IsReadOnly = true;
                    TableGrid.CanUserDeleteRows = true;
                    break;
            }
        }
        private void add_btn_cl(object sender, RoutedEventArgs e)
        {
            Button add = (Button)sender;
            MessageBox.Show("DELETED");
        }
        private void del_btn_cl(object sender, RoutedEventArgs e)
        {
            Button del = (Button)sender;
            MessageBox.Show("DELETED");
        }
    }
    
}