using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using CameloBeer.ViewModels.Catalog;
using CameloBeer.Models;

namespace CameloBeer.Pages.Catalog
{
	public class CatalogCarouselView:CarouselPage
	{
		public CatalogCarouselView ():base()
		{
			this.Title = "Cervejas";

			this.Children.Add(new CatalogView(new CatalogViewModel(CatalogItem.ITEM_Cerveja1)));
//			this.Children.Add(new CatalogView(new CatalogViewModel(CatalogItem.ITEM_Cerveja2)));
//			this.Children.Add(new CatalogView(new CatalogViewModel(CatalogItem.ITEM_Cerveja3)));
			this.Children.Add(new CatalogView(new CatalogViewModel(CatalogItem.ITEM_Cerveja4)));
			this.Children.Add(new CatalogView(new CatalogViewModel(CatalogItem.ITEM_Cerveja5)));
			this.Children.Add(new CatalogView(new CatalogViewModel(CatalogItem.ITEM_Cerveja6)));
//			this.Children.Add(new CatalogView(new CatalogViewModel(CatalogItem.ITEM_Cerveja7)));
			this.Children.Add(new CatalogView(new CatalogViewModel(CatalogItem.ITEM_Cerveja8)));
			this.Children.Add(new CatalogView(new CatalogViewModel(CatalogItem.ITEM_Cerveja9)));
			this.Children.Add(new CatalogView(new CatalogViewModel(CatalogItem.ITEM_Cerveja10)));
			this.Children.Add(new CatalogView(new CatalogViewModel(CatalogItem.ITEM_Cerveja11)));
		}
	}
}

