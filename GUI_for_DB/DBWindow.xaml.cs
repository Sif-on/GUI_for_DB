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
            List<Table> tablesList = new List<Table>
            {
                new Table { FirstName="Timofey", LastName="Lastivka", JobPosition="1", Salary="5000"},
                new Table { FirstName="Evgeniy", LastName="Simonovskiy", JobPosition="2", Salary="10000"}
            };

            switch (Mode)
            {
                case 0:
               
                    TableGrid.IsReadOnly = true;
                    TableGrid.ItemsSource = tablesList;
                    // add.Visibility = Visibility.Collapsed;
                    break;
                case 1:
                    TableGrid.IsReadOnly = true;
                    TableGrid.ItemsSource = tablesList;
                    // add.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    TableGrid.IsReadOnly = false;
                    TableGrid.ItemsSource = tablesList;
                    // add.Visibility = Visibility.Collapsed;
                    break;
                case 3:
                    // TableGrid.IsReadOnly = true;
                    TableGrid.CanUserDeleteRows = true;
                    TableGrid.ItemsSource = tablesList;
                    break;
            }
            // switch (TableName) {
            //     case "Clients":
            //         TableGrid.
            // }
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
    public class Table
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobPosition { get; set; }
        public string Salary { get; set; }
    }
}