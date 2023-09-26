using System;


namespace FormAutos_Ejercicio9_G2_2024_1
{
    public class Automoviles
    {
        private int precio;
        int[] arregloPrecios = new int[49];
        string automoviles;
        byte mayoresPrecios;
        float promedioPrecios;
        float totalPrecios;

        public Automoviles()
        {
        }

        public Automoviles(int precio, string automoviles, byte mayoresPrecios, float promedioPrecios, float totalPrecios, int[] arregloPrecios )
        {
            this.precio = precio;
            this.automoviles = automoviles;
            this.mayoresPrecios = mayoresPrecios;
            this.promedioPrecios = promedioPrecios;
            this.totalPrecios = totalPrecios;
        }
        public void Asignar()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);

            for (int i = 0; i
                            < arregloPrecios.Length; i++)
            {
                //arregloPrecios[i] = 100000 + i * 7000;
                var value = random.Next(250000, 500000);
                arregloPrecios[i] = value;
                totalPrecios += arregloPrecios[i];

                //Print precios
                automoviles = automoviles + "\n" + i+1 + ".    $ " + arregloPrecios[i].ToString();
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

    }
}
