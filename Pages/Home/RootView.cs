using CameloBeer.Models;
using CameloBeer.Pages.Catalog;
using CameloBeer.Pages.Base;
using CameloBeer.ViewModels.Catalog;

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace CameloBeer.Pages.Home
{
	public class RootView:MasterDetailPage
	{
		MenuType previousItem;
		public RootView ()
		{
			this.Title = "Camelo Beer";

			var optionsPage = new MenuView ();

			optionsPage.BackgroundImage = "menubkg.png";
			optionsPage.BackgroundColor = Color.FromHex ("f3722e");
			optionsPage.Menu.ItemSelected += (sender, e) =>
			{

				var item = e.SelectedItem as CameloBeer.Models.MenuItem;
				if (item == null)
					return;

				NavigateTo(item.MenuType);
				optionsPage.Menu.SelectedItem = null;
			};

			Master = optionsPage;

			previousItem = MenuType.Parceiros;//set first time to force
			NavigateTo(MenuType.Historia);

		}

		void NavigateTo(MenuType option)
		{
			if (previousItem == option)
				return;

			previousItem = option;

			var displayPage = PageForOption(option);


			displayPage.BarBackgroundColor = Helpers.AppColors.CONTENTLIGHTBKG;
			displayPage.BarTextColor = Color.Black;


			Detail = displayPage;

			IsPresented = false;
		}

		NavigationPage infopage, agenda, contato, copos, cervejas, parceiros;

		NavigationPage PageForOption (MenuType option)
		{

			switch (option)
			{
			case MenuType.Historia:
				{
					if (infopage != null)
						return infopage;
					
					infopage = new NavigationPage(new InfoPage());
					return infopage;
				}
//			case MenuType.Agenda:
//				{
//					if (agenda != null)
//						return agenda;
//
//					agenda= new NavigationPage(new InfoPage());
//					return agenda; 
//				}
			case MenuType.Contato:
				{
					if (contato != null)
						return contato;

					contato= new NavigationPage(new Contato());
					
					return contato;
				}
			case MenuType.Copos:
				{
					if (copos != null)
						return copos;

					copos = new NavigationPage (new Copos.Copos ());
					return copos;
				} 
			case MenuType.Cervejas:
				{
					if (cervejas != null)
						return cervejas;

					cervejas = new NavigationPage(new Catalog.CatalogCarouselView());
					return cervejas;
				}

			case MenuType.Parceiros:
				{
					if (parceiros != null)
						return parceiros;

					parceiros = new NavigationPage(new Parceiros.ParceirosView());
					return parceiros;
				}

			}

			throw new NotImplementedException("Opção desconhecida de Menu: " + option.ToString());
		}


		protected override void OnAppearing()
		{
			base.OnAppearing();

		}

	}
}
