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
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;

namespace GUI_for_DB
{
    public partial class MainWindow : Window
    {
        //private int selectedMode = 0;
        public MainWindow()
        {
            InitializeComponent();
            InitGUI();
            using (PharmacyContext db = new PharmacyContext())
            {

            }

        }

        private static void InitGUI()
        {
            /*TextEditBox.IsEnabled = false;*/
            /*TableCombo.Items.Add("Clients");
            TableCombo.Items.Add("Instructions");*/
        }

        private void TableCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*using (PharmacyContext db = new PharmacyContext())
            {
                
                switch (TableCombo.Items.CurrentItem.ToString())
                {
                    case "Clients":
                        FieldCombo.Items.Add("Name");
                        FieldCombo.Items.Add("Surname");
                        return;
                }
            }*/
        }

        private void FieldCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*using (PharmacyContext db = new PharmacyContext())
            {
                
                switch (FieldCombo.Items.CurrentItem)
                {
                    case "Name":
                        TextEditBox.IsEnabled = true;
                        var Names = db.Clients.ToList();

                        foreach (var el in Names)
                        {
                            ValueCombo.Items.Add(el);
                        }
                        break;
                }
            }*/
        }

        private void ValueCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Apply_clicked(object sender, RoutedEventArgs e)
        {
            /*using (PharmacyContext db = new PharmacyContext())
            {
                Client Client1 = new Client { Name = "Timofey", Surname = "Lastochka" };

                db.Clients.Add(Client1);
                db.SaveChanges();
            }*/
        }

        private void Cancel_clicked(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource == Cancel_btn) TextEditBox.Document.Blocks.Clear();
        }

        private void Delete_clicked(object sender, RoutedEventArgs e)
        {
            
            /*if (e.OriginalSource == Cancel_btn)
            {
                *//*TextEditBox.Document.Blocks.Clear();*//*
                TextEditBox.AppendText("Hellp!");
            }*/
            
        }
    }
}

