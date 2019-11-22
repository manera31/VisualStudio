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

namespace Empleados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Employee.GetEmployees();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = new Employee();
            Formulario formulario = new Formulario(employee);
            formulario.evento += (o) => { Employee.GetEmployees().Add(o); };
            formulario.Show();
            //Employee.GetEmployees().Add(employee);


        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = (Employee)dataGrid.CurrentItem;
            Formulario f = new Formulario(employee);
            f.evento += (o) => { Employee.GetEmployees().Add(o); };
            f.Show();
            
        }

        
    }
}
