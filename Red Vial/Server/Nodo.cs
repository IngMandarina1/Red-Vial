namespace Red_Vial.Server
{
	public enum TipoVia { Autopista, Avenida, Calle, Peatonal }
	public enum EstadoSemaforo { Verde, Amarillo, Rojo, NoAplica }

	public class NodoRedVial
	{
		public int X { get; }
		public int Y { get; }
		public int VehiculosEnEspera { get; set; }
		public Dictionary<Direccion, TipoVia> TipoPorDireccion { get; } = new();
		public EstadoSemaforo Semaforo { get; set; }
		public double TiempoPromedioTransito { get; set; }

		// Conexiones
		public NodoRedVial? Norte { get; set; }
		public NodoRedVial? Sur { get; set; }
		public NodoRedVial? Este { get; set; }
		public NodoRedVial? Oeste { get; set; }

		public NodoRedVial(int x, int y)
		{
			X = x;
			Y = y;
			Semaforo = EstadoSemaforo.NoAplica;
		}
	}

	public enum Direccion { Norte, Sur, Este, Oeste }
}
