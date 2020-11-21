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

namespace Calculadora
{
    public partial class MainWindow : Window {

        //CREACCION DE LISTA Y VARIABLES
        int cont = 0;
        List<String> lista = new List<String>();
        List<String> lista2 = new List<String>();


        public MainWindow()
        {
            InitializeComponent();
        }




        private void Boton_numerico(object sender, RoutedEventArgs e)
        {
            //FUNCION PARA AÑADIR NUMEROS
            Text_resultado.Text += ((Button)sender).Content;
        }





        private void Boton_Operacion(object sender, RoutedEventArgs e)
        {
            //FUNCION PARA AÑADIR LAS OPERACIONES

            if (Text_resultado.Text !=""  )
            //&& lista[1].Length<=0
            {
                lista.Add(Text_resultado.Text);
                lista.Add(((Button)sender).Content.ToString());
                Text_resultado.Text = ("");
            }
           

        }




        private void Boton_Igual(object sender, RoutedEventArgs e)
        {
            //FUNCION PARA MOSTRAR EL RESULTADO

            
               if (Text_resultado.Text != "" && lista.Count > 0)
            {   
                lista.Add(Text_resultado.Text);
                    Text_resultado.Text = "";


                    
                    

                    //PASAMOS LOS NUMERO DE LA LISTA A INT EN VARIABLE
                    float operador1 = float.Parse(lista[0]);
                    float operador2 = float.Parse(lista[2]);


                  //OPERACIONES
                  if (lista[1] == "+")
                  {
                    Text_resultado.Text = (operador1 + operador2).ToString();
                    Introducir_lista2();
                    lista2.Add(operador1 + " + " + operador2 + " = " + Text_resultado.Text + "; ");
                    Text_Historial.Text = string.Join("", lista2);
                    
                  }
                  else if (lista[1] == "-")
                  {
                    Text_resultado.Text = (operador1 - operador2).ToString();
                    Introducir_lista2();
                    lista2.Add(operador1 + " - " + operador2 + " = " + Text_resultado.Text + "; ");
                    Text_Historial.Text = string.Join("", lista2);
                }
                    
                  else if (lista[1] == "*")
                  {
                    Text_resultado.Text = (operador1 * operador2).ToString();
                    Introducir_lista2();
                    lista2.Add(operador1 + " * " + operador2 + " = " + Text_resultado.Text + "; ");
                    Text_Historial.Text = string.Join("", lista2);
                }
                    
                  else if (lista[1] == "/")
                  {
                    Text_resultado.Text = (operador1 / operador2).ToString();
                    Introducir_lista2();
                    lista2.Add(operador1 + " / " + operador2 + " = " + Text_resultado.Text + "; ");
                    Text_Historial.Text = string.Join("", lista2);
                }

                  else if (lista[1] == "%")
                  {
                    Text_resultado.Text = (operador1 % operador2).ToString();
                    Introducir_lista2();
                    lista2.Add(operador1 + " % " + operador2 + " = " + Text_resultado.Text + "; ");
                    Text_Historial.Text = string.Join("", lista2);
                    
                }

                  else { }

                     

                    lista.Clear();
                }        

        }

        private void Introducir_lista2()
        {
            if (cont >= 3)
            {
                lista2.Clear();
                cont = 0;
            }
                

            cont++;
            
        }


        private void Boton_Limpiar(object sender, RoutedEventArgs e)
        {
            lista.Clear();
            Text_resultado.Text = "";
        }

        private void Boton_Limpiar_Historial(object sender, RoutedEventArgs e)
        {
            lista2.Clear();
            Text_Historial.Text = "";
            cont = 0;
        }
    }
}
