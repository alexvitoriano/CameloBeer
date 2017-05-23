using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CameloBeer.Models;

namespace CameloBeer.ViewModels.Catalog
{
	public class CatalogViewModel:BaseViewModel
	{
		private CatalogItem catalogItem;

		public CatalogViewModel(string catalogItem)
		{
			this.Title = "Cervejas";
			this.Icon = "hops.png";

			this.catalogItem = CatalogItem.CreateCatalogItem(catalogItem);
		} //end ctor


		public CatalogItem Product
		{
			get
			{
				return catalogItem;
			}
			set
			{
				catalogItem = value;
			}
		}

	}
}
