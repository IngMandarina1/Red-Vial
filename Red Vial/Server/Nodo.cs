namespace Red_Vial.Server
{
	public class NodoRedVial
	{
		public Informacion  informacion { get; set;  }
		public NodoRedVial? Norte { get; set; }
		public NodoRedVial? Sur { get; set; }
		public NodoRedVial? Este { get; set; }
		public NodoRedVial? Oeste { get; set; }

		public NodoRedVial(Informacion _informacion)
		{
			informacion = _informacion;
			Norte = null;
			Sur = null;
			Este = null;
			Oeste = null;
		}
	}

}
