using System;
using System.Collections.Generic;
using System.Text;

namespace CameloBeer.Models
{
	public enum MenuType
	{
		Historia,
		Copos,
		Contato,
		Cervejas,
		Parceiros
	}

	public class MenuItem
	{
		public MenuItem()
		{
			MenuType = MenuType.Historia;
		}
		public int Id { get; set; }
		public string Title { get; set; }
		public string Icon { get; set; }
		public MenuType MenuType { get; set; }
	}
}