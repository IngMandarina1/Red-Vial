using Microsoft.AspNetCore.Components;

namespace Red_Vial.Server
{
    public class LED
    {
        public NodoRedVial? NodoPrincipal { get; private set; }

        public LED()
        {
            InicializarRedVialDinamica(10, 10);
        }

        private void InicializarRedVialDinamica(int filas, int columnas)
        {
            NodoRedVial? filaAnteriorInicio = null;

            for (int i = 0; i < filas; i++)
            {
                NodoRedVial? nodoAnterior = null;
                NodoRedVial? nodoActual = null;
                NodoRedVial? nodoFilaInicio = null;

                for (int j = 0; j < columnas; j++)
                {
                    nodoActual = new NodoRedVial(new Informacion
                    {
                        Nombre = $"Intersección ({i},{j})",
                        VehiculoEnEspera = 0,
                        TiempoPromedioTransito = 1.5
                    });

                    if (NodoPrincipal == null)
                        NodoPrincipal = nodoActual;

                    if (nodoAnterior != null)
                    {
                        nodoAnterior.Este = nodoActual;
                        nodoActual.Oeste = nodoAnterior;
                    }

                    if (filaAnteriorInicio != null)
                    {
                        // Buscar el nodo correspondiente en la fila anterior
                        NodoRedVial? nodoSuperior = filaAnteriorInicio;
                        for (int k = 0; k < j; k++)
                        {
                            nodoSuperior = nodoSuperior?.Este;
                        }

                        if (nodoSuperior != null)
                        {
                            nodoSuperior.Sur = nodoActual;
                            nodoActual.Norte = nodoSuperior;
                        }
                    }

                    if (j == 0)
                        nodoFilaInicio = nodoActual;

                    nodoAnterior = nodoActual;
                }

                filaAnteriorInicio = nodoFilaInicio;
            }
        }

        public void MostrarRedVial()
        {
            NodoRedVial? fila = NodoPrincipal;

            while (fila != null)
            {
                NodoRedVial? actual = fila;
                while (actual != null)
                {
                    Console.Write($"[{actual.informacion.Nombre}] ");
                    actual = actual.Este;
                }
                Console.WriteLine();
                fila = fila.Sur;
            }
        }
    }
}