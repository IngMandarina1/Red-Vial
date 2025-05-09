using Microsoft.AspNetCore.Components;

namespace Red_Vial.Server
{
    public class LED
    {
        public NodoRedVial?[,] matriz = new NodoRedVial[10, 10];

        public LED()
        {
            InicializarRedVial();
        }

        private void InicializarRedVial()
        {
            // Crear intersecciones y ubicarlas en la matriz
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz[i, j] = new NodoRedVial(new Informacion
                    {
                        Nombre = $"Intersección ({i},{j})",
                        VehiculoEnEspera = 0,
                        TiempoPromedioTransito = 1.5
                    });
                }
            }

            // Conectar las intersecciones entre sí
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i > 0) matriz[i, j].Norte = matriz[i - 1, j]; // Conectar al norte
                    if (i < 9) matriz[i, j].Sur = matriz[i + 1, j]; // Conectar al sur
                    if (j > 0) matriz[i, j].Oeste = matriz[i, j - 1]; // Conectar al oeste
                    if (j < 9) matriz[i, j].Este = matriz[i, j + 1]; // Conectar al este
                }
            }
        }
    }
}