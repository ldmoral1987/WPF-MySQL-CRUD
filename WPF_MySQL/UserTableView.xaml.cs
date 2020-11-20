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
using System.Windows.Shapes;

namespace WPF_MySQL
{
    /// <summary>
    /// Lógica de interacción para UserTableView.xaml
    /// </summary>
    public partial class UserTableView : Window
    {
        public UserTableView()
        {
            InitializeComponent();
        }

        public void setData (List<UserEntity> users)
        {
            // Se generan las columnas de la tabla
            generateColumns();

            // Se cargan las filas de la tabla
            foreach (UserEntity user in users)
            {
                usersDataGrid.Items.Add(user);
            }
        }

        private void generateColumns()
        {
            // Genera las columnas del grid
            DataGridTextColumn c1 = new DataGridTextColumn();
            c1.Header = "Id";
            c1.Binding = new Binding("Id");
            c1.Width = 100;
            usersDataGrid.Columns.Add(c1);

            DataGridTextColumn c2 = new DataGridTextColumn();
            c2.Header = "Name";
            c2.Binding = new Binding("Name");
            c2.Width = 150;
            usersDataGrid.Columns.Add(c2);

            DataGridTextColumn c3 = new DataGridTextColumn();
            c3.Header = "Surname";
            c3.Binding = new Binding("Surname");
            c3.Width = 200;
            usersDataGrid.Columns.Add(c3);

            DataGridTextColumn c4 = new DataGridTextColumn();
            c4.Header = "Timestamp";
            c4.Binding = new Binding("Timestamp");
            c4.Width = 150;
            usersDataGrid.Columns.Add(c4);
        }
    }
}
