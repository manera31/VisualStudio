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
        private Boolean haveData;
        public delegate void EventHandler(Employee e);
        public event EventHandler evento;
        public Formulario(Employee employee)
        {
            this.employee = employee;
            aux = false;
            haveData = false;
            InitializeComponent();
            if (employee.Name != null)
            {
                textoNombre.Text = employee.Name;
                textoTitulo.Text = employee.Title;
                CheckReelected.IsChecked = employee.WasReElected;
                haveData = true;
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!textoNombre.Text.Equals("")&&!textoTitulo.Text.Equals(""))
            {
                employee.Title = textoTitulo.Text;
                employee.Name = textoNombre.Text;
                employee.WasReElected = CheckReelected.IsChecked.Value;
                if (!haveData)
                {
                    evento(employee);
                }
                
                aux = true;
            }

            
            
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!aux && !textoNombre.Text.Equals("") && !textoTitulo.Text.Equals(""))
            {
                MessageBoxButton bb = MessageBoxButton.YesNoCancel;
                MessageBoxResult br = MessageBox.Show("Guardar los cambios?", "Error", bb);
                switch (br)
                {
                    case MessageBoxResult.Yes:
                        employee.Title = textoTitulo.Text;
                        employee.Name = textoNombre.Text;
                        employee.WasReElected = CheckReelected.IsChecked.Value;
                        if (!haveData)
                        {
                            evento(employee);
                        }
                        break;
                    case MessageBoxResult.No:
                        break;
                    case MessageBoxResult.Cancel:
                        e.Cancel = true;
                        break;
                }
                
            } else if (!aux)
            {
                MessageBox.Show("No hay cambios que guardar");
            }
            
        }

        
    }
}
