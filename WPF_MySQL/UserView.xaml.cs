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

namespace WPF_MySQL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Referencia al controlador de la aplicación
        private UserController controller;

        // Estos flags indican si el registro tiene cambios o es nuevo
        private bool isRegisterChanged = false;
        private bool isNewRegister = false;

        public MainWindow()
        {
            InitializeComponent();
            startAppComponents();
        }

        private void startAppComponents()
        {
            // Se inicializan los componentes de la aplicación
            // Se inicializa el controlador y este inicializa el modelo
            this.controller = new UserController(new UserModel());

            // Se carga el primer registro de la tabla en la vista
            getFirstUser();
        }


        private void getFirstUser()
        {
            // Se obtiene el primer registro de la tabla
            UserEntity user = this.controller.getFirstUser();

            // Se actualiza la vista con los datos del usuario recibidos
            updateView(user);

            // El registro se marca como sin cambios
            isRegisterChanged = false;

            // El registro se marca como un registro de la BBDD
            isNewRegister = false;
        }

        private void updateView(UserEntity user)
        {
            // Se actualiza la vista con los datos del usuario recibidos
            if (user != null)
            {
                txtId.Text = user.Id.ToString();
                txtName.Text = user.Name;
                txtSurname.Text = user.Surname;
                txtTimestamp.Text = user.Timestamp;
            }
        }

        private void clearView()
        {
            // Se limpian los controles de la interfaz
            txtId.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtTimestamp.Text = "";
        }

        private void btnTable_Click(object sender, RoutedEventArgs e)
        {
            // Se obtienen todos los registros de la tabla
            List<UserEntity> users = this.controller.getAllUsers();

            // Se cargan los registros en la vista en tabla
            UserTableView tableView = new UserTableView();
            tableView.setData(users);
            tableView.Show();
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            // Se obtiene el primer registro de la tabla
            UserEntity user = this.controller.getFirstUser();

            // Si el usuario recibido no es nulo, se actualiza la vista
            if (user != null)
            {
                // Se actualiza la vista
                updateView(user);

                // El registro se marca como sin cambios
                isRegisterChanged = false;

                // El registro se marca como un registro de la BBDD
                isNewRegister = false;
            }
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            // Se obtiene el registro anterior de la tabla (con respecto al actual)
            UserEntity user = this.controller.getPreviousUser(txtId.Text);

            // Si el usuario recibido no es nulo, se actualiza la vista
            if (user != null)
            {
                // Se actualiza la vista
                updateView(user);

                // El registro se marca como sin cambios
                isRegisterChanged = false;

                // El registro se marca como un registro de la BBDD
                isNewRegister = false;
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            // Se obtiene el registro siguiente de la tabla (con respecto al actual)
            UserEntity user = this.controller.getNextUser(txtId.Text);

            // Si el usuario recibido no es nulo, se actualiza la vista
            if (user != null)
            {
                updateView(user);

                // El registro se marca como sin cambios
                isRegisterChanged = false;

                // El registro se marca como un registro de la BBDD
                isNewRegister = false;
            }
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            // Se obtiene el último registro de la tabla
            UserEntity user = this.controller.getLastUser();

            // Si el usuario recibido no es nulo, se actualiza la vista
            if (user != null)
            {
                // Se actualiza la vista
                updateView(user);

                // El registro se marca como sin cambios
                isRegisterChanged = false;

                // El registro se marca como un registro de la BBDD
                isNewRegister = false;
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            // Se limpia la ventana para permitir al usuario insertar
            // un nuevo registro en la base de datos
            clearView();

            // El registro se marca como un registro nuevo
            isNewRegister = true;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (isNewRegister && txtName.Text != "" && txtSurname.Text != "")
            {
                // Se guarda el registro nuevo (si es un nuevo registro)

                // Se recuperan los datos del nuevo usuario
                // El ID es autoincremental
                // El timestamp se genera automáticamente en la BBDD
                UserEntity user = new UserEntity();
                user.Name = txtName.Text;
                user.Surname = txtSurname.Text;

                // Se guarda el usuario en la base de datos
                if (this.controller.addUser(user))
                {
                    // El registro se ha guardado
                    // Se limpia la vista
                    clearView();

                    // Ahora se busca el registro creado
                    user = this.controller.getLastUser();

                    // Si el usuario recibido no es nulo, se actualiza la vista
                    if (user != null)
                    {
                        // Se actualiza la vista
                        updateView(user);

                        // El registro se marca como sin cambios
                        isRegisterChanged = false;

                        // El registro se marca como un registro de la BBDD
                        isNewRegister = false;
                    }
                }
                else
                {
                    // Se ha producido un error
                    MessageBox.Show("ERROR: " + "No se ha podido guardar el registro", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (isRegisterChanged)
            {
                MessageBox.Show("aaa");
                // Se actualiza el registro (es un registro con cambios)
                // Se recuperan los datos del nuevo usuario
                // El ID es autoincremental
                // El timestamp se genera automáticamente en la BBDD
                UserEntity user = new UserEntity();
                user.Id = int.Parse(txtId.Text);
                user.Name = txtName.Text;
                user.Surname = txtSurname.Text;

                // Se actualiza el usuario en la base de datos
                if (this.controller.updateUser(user))
                {
                    // El registro se ha actualizado

                    // El registro se marca como sin cambios
                    isRegisterChanged = false;

                    // El registro se marca como un registro de la BBDD
                    isNewRegister = false;
                }
                else
                {
                    // Se ha producido un error
                    MessageBox.Show("ERROR: " + "No se ha podido actualizar el registro", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            // Si el registro no es nuevo, entonces se permite borrarlo
            if (!isNewRegister)
            {
                // Se pregunta al usuario para confirmar el borrado
                MessageBoxResult resultado = MessageBox.Show("¿Quieres borrar el registro (" + txtId.Text + ")?", "Información", MessageBoxButton.YesNo, MessageBoxImage.Information);

                // Si el usuario dice que quiere borrar el registro, se borra
                if (resultado == MessageBoxResult.Yes)
                {
                    // Se borra el registro actual
                    if (this.controller.deleteUser(txtId.Text))
                    {
                        // El registro se ha borrado
                        // Se obtiene el primer registro de la tabla
                        getFirstUser();
                    }
                }
            }
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            // El registro se marca con cambios
            isRegisterChanged = true;
        }

        private void txtSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            // El registro se marca con cambios
            isRegisterChanged = true;
        }
    }
}
