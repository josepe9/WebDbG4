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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Parcial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Calcular(object sender, RoutedEventArgs e)
        {
            try
            {
                double limo = double.Parse(limosnas.Text);
                double matri = double.Parse(matrimonio.Text);
                double exe = double.Parse(exequias.Text);
                double otro = double.Parse(otros.Text);

                double TotalRecaudos = limo + matri + exe + otro;

                string cadenaTotal = "    Limosnas:    " + limo;
                cadenaTotal = cadenaTotal + "\n     Matrimonios:     " + matri;
                cadenaTotal = cadenaTotal + "\n     Exequias:        " + exe;
                cadenaTotal = cadenaTotal + "\n     Otros Conceptos: " + otro;
                cadenaTotal = cadenaTotal + "\n";
                cadenaTotal = cadenaTotal + "\n     Total Recaudos   " + TotalRecaudos;

                Total.Text = cadenaTotal;

                double promedio = (limo + matri + exe + otro) / 4;

                string cadenaPromedio = "Promedio: " + promedio;

                Promedio.Text = cadenaPromedio;

                if (limo > matri && limo > exe && limo > otro)
                {
                    Concepto.Text = "El Mayor recaudo es: Limosnas " + limo;
                }
                else if (matri > exe && matri > otro)
                {
                    Concepto.Text = "El Mayor recaudo es: Matrimonios " + matri;
                }
                else if (exe > otro)
                {
                    Concepto.Text = "El Mayor recaudo es: Exequias " + exe;
                }
                else
                {
                    Concepto.Text = "El Mayor recaudo es: Otros " + otro;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }


        }

        
    }
}
