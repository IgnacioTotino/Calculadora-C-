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
    class OperadorDivision  
    { 
        public double EstaDividiendo(double N1, double N2)
        {
            double DIV = N1 / N2;

            if (N2 == 0)
            {                        
                return (double)MessageBox.Show("como vas a dividir por 0 la concha de tu madre");     
                         
            }

            else return DIV;
            
        }   
    }
}
/*double DIV = N1 / N2;

            return DIV;
            
           
            /* if (N2 == 0)
             {
                       return error();
                         
                       Consola.Clear();
             }
            
            else return DIV;
                    
        }

        public static void error()
        {
            Console.WriteLine("como vas a dividir por 0 la concha de tu madre");
        } */ //excepcio al usar