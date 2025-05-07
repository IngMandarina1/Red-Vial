using Microsoft.AspNetCore.Components;

namespace Red_Vial.Server
{
	public partial class TrafficNetworkGridBase : ComponentBase
	{
		protected MapaVial Mapa { get; private set; } = new();

		protected string GetCellClasses(NodoRedVial nodo)
		{
			var classes = new List<string>();
			if (nodo.Semaforo != EstadoSemaforo.NoAplica) classes.Add("has-semaphore");
			return string.Join(" ", classes);
		}

		protected string GetDirectionSymbol(Direccion dir)
		{
			return dir switch
			{
				Direccion.Norte => "↑",
				Direccion.Sur => "↓",
				Direccion.Este => "→",
				Direccion.Oeste => "←",
				_ => ""
			};
		}

		protected void OnCellClick(NodoRedVial nodo)
		{
			// Lógica al hacer clic (ej: seleccionar nodo)
			Console.WriteLine($"Nodo ({nodo.X}, {nodo.Y}): {nodo.VehiculosEnEspera} vehículos");
		}

		protected void GenerateNewMap()
		{
			Mapa = new MapaVial();
			StateHasChanged();
		}
	}
}
