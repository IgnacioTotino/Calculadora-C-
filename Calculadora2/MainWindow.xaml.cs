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

namespace Calculadora2
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

        OperadorDivision objDivision = new OperadorDivision();
        OperadorMultiplicar objMultiplicar = new OperadorMultiplicar();
        OperadorResta objResta = new OperadorResta();
        OperadoSumacs objSuma = new OperadoSumacs();

        private void boton1_Click(object sender, RoutedEventArgs e) => Consola.Text = Consola.Text + "1";

        private void boton2_Click(object sender, RoutedEventArgs e) => Consola.Text = Consola.Text + "2";

        private void boton3_Click(object sender, RoutedEventArgs e) => Consola.Text = Consola.Text + "3";

        private void boton4_Click(object sender, RoutedEventArgs e) => Consola.Text = Consola.Text + "4";

        private void Boton5_Click(object sender, RoutedEventArgs e) => Consola.Text = Consola.Text + "5";

        private void boton6_Click(object sender, RoutedEventArgs e) => Consola.Text = Consola.Text + "6";

        private void Boton7_Click(object sender, RoutedEventArgs e) => Consola.Text = Consola.Text + "7";

        private void boton8_Click(object sender, RoutedEventArgs e) => Consola.Text = Consola.Text + "8";
        
        private void boton9_Click(object sender, RoutedEventArgs e) => Consola.Text = Consola.Text + "9";
       
        private void boton0_Click(object sender, RoutedEventArgs e) => Consola.Text = Consola.Text + "0";

        
        private void Multiplicacion_Click(object sender, RoutedEventArgs e)
        {
            operador = "*";
            valor1 = double.Parse(Consola.Text);
            Consola.Clear();
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            operador = "/";
            valor1 = double.Parse(Consola.Text);
            Consola.Clear();
        }
     
        private void Sumar_Click(object sender, RoutedEventArgs e)
        {
            operador = "+";
            valor1 = double.Parse(Consola.Text);
            Consola.Clear();
        }

        private void Restar_Click(object sender, RoutedEventArgs e)
        {
            operador = "-";          
            valor1 = double.Parse(Consola.Text) ;
            Consola.Clear();
            
        }

        private void botonBorrar_Click(object sender, RoutedEventArgs e) => Consola.Clear();
        

        private void Resultado_Click(object sender, RoutedEventArgs e)
        {
            valor2 = double.Parse(Consola.Text);

            double suma;
            double resta;
            double divis;
            double multi;

             if (operador == "+")
             {
                  suma = objSuma.EstaSumando((valor1),(valor2));

                 Consola.Text = suma.ToString();
             }
             else if(operador == "-")
             {
                resta = objResta.EstaRestando((valor1), (valor2));
                
                Consola.Text = resta.ToString();
             }
             else if (operador == "*")
             {
                multi = objMultiplicar.EstaMultiplicando((valor1), (valor2));

                 Consola.Text = multi.ToString();
             }
             else if (operador == "/")
             {
                divis = objDivision.EstaDividiendo((valor1), (valor2));

                Consola.Text = divis.ToString();
             }


             
             /*switch (operador)
            {
                case "+":
                    suma = objSuma.EstaSumando((valor1), (valor2));
                        break;
            }*/

        }

        string operador;
        double valor1;
        double valor2;
    }
}
