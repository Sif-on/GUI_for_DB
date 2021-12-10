using System;
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

namespace FinalProject
{
    public partial class MainWindow : Window
    {
        private int selectedIndex = 0;
        public MainWindow() {
            InitializeComponent();
        }

        private void clicked_btn_EventHandler(object sender, RoutedEventArgs e) {
            Button b = (Button)sender;
            switch (b.Name) {
                case "ViewBtn":
                    ViewBtn.Background = Brushes.White;
                    InsertBtn.Background = Brushes.Gray;
                    EditBtn.Background = Brushes.Gray;
                    DeleteBtn.Background = Brushes.Gray;
                    selectedIndex = 0;
                    break;
                case "InsertBtn":
                    ViewBtn.Background = Brushes.Gray;
                    InsertBtn.Background = Brushes.White;
                    EditBtn.Background = Brushes.Gray;
                    DeleteBtn.Background = Brushes.Gray;
                    selectedIndex = 1;
                    break;
                case "EditBtn":
                    ViewBtn.Background = Brushes.Gray;
                    InsertBtn.Background = Brushes.Gray;
                    EditBtn.Background = Brushes.White;
                    DeleteBtn.Background = Brushes.Gray;
                    selectedIndex = 2;
                    break;
                default:
                    ViewBtn.Background = Brushes.Gray;
                    InsertBtn.Background = Brushes.Gray;
                    EditBtn.Background = Brushes.Gray;
                    DeleteBtn.Background = Brushes.White;
                    selectedIndex = 3;
                    break;
                
            }
        }
        
        private void click_Table_EventHandler( object sender, RoutedEventArgs e){
            Button b = (Button)sender;
            DBVisualizer w = new DBVisualizer();
            w.Show();
        }
    }
}
