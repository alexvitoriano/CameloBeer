using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CameloBeer.ViewModels.Copos;

namespace CameloBeer.Pages.Copos
{
	public partial class CoposView 
	{
		public CoposView (CoposViewModel vm)
		{
			InitializeComponent();

			this.BindingContext = vm;
		}
	}
}

