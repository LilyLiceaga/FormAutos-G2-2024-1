using System;
using System.Windows.Forms;

namespace FormAutos_Ejercicio9_G2_2024_1
{
    public partial class Form1 : Form 
    {
        int[] arregloPrecios = new int[50];
        string automoviles;
        byte mayoresPrecios;
        float promedioPrecios;
        float totalPrecios;


        public Form1()
        {
            InitializeComponent();
        }

        #region Clase

        public void Asignar()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            int iteracion = 1;

            for (int i = 0; i
                            < arregloPrecios.Length; i++)
            {

                var value = random.Next(250000, 500000);
                arregloPrecios[i] = value;
                totalPrecios += arregloPrecios[i];

                if (i%2 == 0) {
                    if (i < 9)
                    {
                        automoviles = automoviles + "\n  " + iteracion + ".    $ " + arregloPrecios[i].ToString();
                    }
                    else
                    {
                        automoviles = automoviles + "\n" + iteracion + ".    $ " + arregloPrecios[i].ToString();
                    }

                }
                else
                {
                    if (i < 9)
                    {
                        automoviles = automoviles + "      " + iteracion + ".    $ " + arregloPrecios[i].ToString();
                    }
                    else
                    {
                        automoviles = automoviles + "    " + iteracion + ".    $ " + arregloPrecios[i].ToString();
                    }
                }
                iteracion++;
            }

        }

        public void Promedio()
        {
            promedioPrecios = totalPrecios / 50;
        }

        public void Mayores()
        {
            for (int i = 0; i < arregloPrecios.Length; i++)
            {
                if (arregloPrecios[i] > promedioPrecios)
                {
                    mayoresPrecios++;
                }
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            //Automoviles a = new Automoviles();
            Asignar();
            lbPrecioAutos.Text = automoviles;
            Promedio();
            lbPromedio.Text = "$ " + promedioPrecios.ToString();
            Mayores();
            lbMayores.Text = mayoresPrecios.ToString() + " automóviles ";

        }
    }
}
