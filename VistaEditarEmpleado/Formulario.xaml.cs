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

namespace Empleados
{
    /// <summary>
    /// Lógica de interacción para Formulario.xaml
    /// </summary>
    public partial class Formulario : Window
    {
        private Employee employee;
        private Boolean aux;
        public Formulario(Employee employee)
        {
            this.employee = employee;
            aux = false;
            InitializeComponent();
            if (employee.Name != null)
            {
                textoNombre.Text = employee.Name;
                textoTitulo.Text = employee.Title;
                CheckReelected.IsChecked = employee.WasReElected;
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!textoNombre.Text.Equals("")&&!textoTitulo.Text.Equals(""))
            {
                employee.Title = textoTitulo.Text;
                employee.Name = textoNombre.Text;
                employee.WasReElected = CheckReelected.IsChecked.Value;
                aux = true;
            }

            this.Close();
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!aux)
            {
                MessageBox.Show("No se guardaran los cambios");
            }
            
        }
    }
}
