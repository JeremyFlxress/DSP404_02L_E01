﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parte_3.Models
{
	public class Producto
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Descripcion { get; set; }
		public decimal Precio { get; set; }
	}
}