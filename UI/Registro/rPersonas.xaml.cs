using System.Windows;
using RegistroPrestamos.Entities;
using RegistroPrestamos.BLL;
using System.Linq;
using System.Drawing;
using System.Windows.Media;
using System.Windows.Controls;

namespace RegistroPrestamos.UI.Registro
{
    public partial class rPersonas : Window {
        Personas persona;

        public rPersonas(){
            InitializeComponent();
            persona = new Personas();
            this.DataContext = persona;
        }

        public void BuscarBoton_Click(object sender, RoutedEventArgs e){
            var persona = PersonaBLL.Buscar(Utilities.ToInt(PersonaIdTextBox.Text));

            if(persona != null)
                this.persona = persona;
            else{
                this.persona = new Personas();
                MessageBox.Show("No se encontró ningún registro", "Sin coincidencias", 
                                MessageBoxButton.OK, MessageBoxImage.Information);
            }

            this.DataContext = this.persona;
        }

        private void Limpiar(){
            this.persona = new Personas();
            this.DataContext = this.persona;
        }

        private bool Validar(){

            NombresTextBox.Text = NombresTextBox.Text.Trim();

            if (NombresTextBox.Text.Length == 0)
            {
                MessageBox.Show("Introduzca un nombre", "Datos incorrectos",
                                MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;

            }
            else if (NombresTextBox.Text.Any(char.IsPunctuation) ||
                      NombresTextBox.Text.Any(char.IsSymbol) ||
                      NombresTextBox.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Introduzca un nombre que no contenga ni símbolos ni números.", "Datos incorrectos",
                                MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            else
                return true;
        }
        public void NuevoBoton_Click(object sender, RoutedEventArgs e){
            Limpiar();
        }
        public void GuardarBoton_Click(object sender, RoutedEventArgs e){
            if(!Validar())
                return;

            var found = PersonaBLL.Guardar(persona);

            if(found){
                MessageBox.Show("Registro guardado", "Guardado exitoso", 
                                MessageBoxButton.OK, MessageBoxImage.Information);
                Limpiar();
            
            } else 
                MessageBox.Show("Error", "Hubo un error al guardar", 
                                MessageBoxButton.OK, MessageBoxImage.Error);
        }
        public void EliminarBoton_Click(object sender, RoutedEventArgs e){
            if(PersonaBLL.Eliminar(Utilities.ToInt(PersonaIdTextBox.Text))){
                Limpiar();
                MessageBox.Show("Registro borrado", "Borrado exitoso", 
                                MessageBoxButton.OK, MessageBoxImage.Information);
            
            } else 
                MessageBox.Show("Error", "Hubo un error al borrar", 
                                MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}