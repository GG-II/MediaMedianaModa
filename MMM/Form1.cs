using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMM
{
    public partial class Form1 : Form
    {
        Estadistica estad = new Estadistica();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            double num = 0;
            if (validacion())
            {
                iconError.Clear();
                for (int i=0; i < estad.Cantidad; i++)
                {
                    while(!double.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese los numeros", "Ingresar"), out num))
                    {
                        MessageBox.Show("Debe ser un numero", "Error");
                    }
                    while (num <=0)
                    {
                        MessageBox.Show("Debe ser un numero mayor a cero", "Error");
                        while (!double.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese los numeros", "Ingresar"), out num))
                        {
                            MessageBox.Show("Debe ser un numero", "Error");
                        }
                    }

                    listaNumero.Items.Add(num);
                    estad.Numero = num;
                }
            }
        }

        //Metodo de validación TryCatch
        public bool validacion()
        {
            bool noError = true;

            //Validacion si inputbox vacio
            if(cantfor.Text == String.Empty)
            {
                //Si esta vacío entra al if y manda un mensaje de error
                //con el icono de advertencia
                iconError.SetError(cantfor, "No dejar en blanco el inputbox");
                MessageBox.Show("Por favor, dijite una cantidad de numeros", "Cantidad de numeros en blanco");
                //retorna un falso
                noError = false;

            }
            else
            {
                try
                {
                    //Se convierte el numero que se digito en la caja de texto (que es string) a un entero
                    estad.Cantidad = Convert.ToInt32(cantfor.Text);
                }
                catch
                {
                    iconError.Clear();
                    iconError.SetError(cantfor, "Ingrese un numero valido");
                    MessageBox.Show("Tiene que ingresar un numero", "Error");
                    noError = false;
                }
            }
            return noError;
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            mediaTxt.Text = estad.Media(estad.Numero, estad.Cantidad).ToString();

            double mediana = 0;
            //Sin uso de vectores
            //Mediana
            listaNumero.Sorted = true;
            int pos = estad.Cantidad / 2;
            if (estad.Cantidad % 2 == 0)
            {
                mediana = (((double)listaNumero.Items[pos - 1] + (double)listaNumero.Items[pos]) / 2.0);
            }
            else
            {
                mediana = (double)listaNumero.Items[pos];
            }
            medianaTxt.Text = mediana.ToString();
            //Sin vectores
            //Moda

            int conAnte = 0;
            int conDesp = 0;

            for (int i=0; i< estad.Cantidad; i++)
            {
                double mPrimero = (double)listaNumero.Items[i];
                conDesp = 0;
                for(int j =0; j< estad.Cantidad; j++)
                {
                    double mSegundo = (double)listaNumero.Items[j];
                    if(mPrimero == mSegundo)
                    {
                        conDesp++;
                    }
                }
                if(conDesp != 1)
                {
                    if(conAnte < conDesp)
                    {
                        conAnte = conDesp;
                        modaTxt.Text = mPrimero.ToString();
                    }
                }
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            cantfor.Clear();
            listaNumero.Items.Clear();
            modaTxt.Clear();
            medianaTxt.Clear();
            mediaTxt.Clear();
            mediaV.Clear();
            medianaV.Clear();
            modaV.Clear();
            iconError.Clear();
        }

        //Para uso de vector
        private void agregarv_Click(object sender, EventArgs e)
        {
            double[] vector = new double[estad.Cantidad];
            double[] vecOrdenado = new double[estad.Cantidad];
            for (int i=0; i<estad.Cantidad; i++)
            {
                vector[i] = (double)listaNumero.Items[i];
            }
            vecOrdenado = estad.orden(vector);
            mediaV.Text = estad.MediaV(vecOrdenado).ToString();
            medianaV.Text = estad.Mediana(vecOrdenado).ToString();
            modaV.Text = estad.Moda(vecOrdenado).ToString();
        }

    }
}
