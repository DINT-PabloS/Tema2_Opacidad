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

namespace Tema2_Opacidad
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PasaRaton(object sender, DependencyPropertyChangedEventArgs e)
        {
            Image imagen = (Image)sender;
            
            if(imagen.IsMouseDirectlyOver) 
            {
                imagen.Opacity = 1;
            }
            else 
            {
                imagen.Opacity = 0.25;
            }
        }
    }
}
