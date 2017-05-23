using CameloBeer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CameloBeer.ViewModels
{
	public class HomeViewModel: BaseViewModel
	{
		public ObservableCollection<MenuItem> _menuItems{ get; set; }
		public HomeViewModel()
		{
			Title = "Camelo Beer";

			_menuItems = new ObservableCollection<MenuItem>();

			_menuItems.Add(new MenuItem
				{
					Id = 0,
					Title = "Historia",
					MenuType = MenuType.Historia,
					Icon = "historia.png"
				}); 

//			_menuItems.Add(new MenuItem
//				{
//					Id = 1,
//					Title = "Facebook",
//					MenuType = MenuType.Agenda,
//					Icon = "agenda.png"
//				});
			_menuItems.Add(new MenuItem
				{
					Id = 2,
					Title = "Cervejas",
					MenuType = MenuType.Cervejas,
					Icon = "hops.png"
				});
			_menuItems.Add(new MenuItem
				{
					Id = 3,
					Title = "Copos",
					MenuType = MenuType.Copos,
					Icon = "copos.png"
				});

			_menuItems.Add(new MenuItem
				{
					Id = 4,
					Title = "Contato",
					MenuType = MenuType.Contato,
					Icon = "sobre.png"
				});

			_menuItems.Add(new MenuItem
				{
					Id = 5,
					Title = "Parceiros",
					MenuType = MenuType.Parceiros,
					Icon = "parceiros.png"
				});

		}

	}
}
