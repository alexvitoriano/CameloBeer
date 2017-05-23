using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CameloBeer.ViewModels.Catalog;

namespace CameloBeer.Pages.Catalog
{
	public partial class CatalogView 
	{
		public CatalogView (CatalogViewModel vm)
		{
			InitializeComponent ();
			this.BindingContext = vm;
		}
	}
}

