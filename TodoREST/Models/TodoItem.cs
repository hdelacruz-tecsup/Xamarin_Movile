using System;

namespace TodoREST
{
	public class TodoItem
	{
		public string id { get; set; }

		public string nombreApp { get; set; }

		public string apellido { get; set; }
		public string sexo { get; set; }

		public string edad { get; set; }

		public string FullName => $"{nombreApp} {apellido}";
	}
}
