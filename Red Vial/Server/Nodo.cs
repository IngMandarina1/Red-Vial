namespace Red_Vial.Server
{
	public class Nodo
	{
		public string Informacion { get; set; }
		public Nodo?  Norte { get; set; }
		public Nodo?  Este { get; set; }
		public Nodo?  Oeste { get; set; }
		public Nodo?  Sur { get; set; }

		public Nodo()
		{
			Informacion = string.Empty;
			Norte = null;
			Este  = null;
			Oeste = null;
			Sur   = null;
		}

		public Nodo(string informacion)
		{
			Informacion = informacion;
			Norte = null;
			Este  = null;
			Oeste = null;
			Sur   = null;
		}

		public override string ToString()
		{
			return $"{Informacion}";
		}

	}
}
