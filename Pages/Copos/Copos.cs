using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using CameloBeer.ViewModels.Copos;
using CameloBeer.Models;

namespace CameloBeer.Pages.Copos
{
	public class Copos : CarouselPage
	{
		public Copos ():base()
		{
			this.Title = "Copos";

			this.Children.Add (new CoposView (new CoposViewModel (CoposItem.PILSNER)));
			this.Children.Add (new CoposView (new CoposViewModel (CoposItem.LAGER)));
			this.Children.Add (new CoposView (new CoposViewModel (CoposItem.CALDERETA)));
			this.Children.Add (new CoposView (new CoposViewModel (CoposItem.PINT)));
			this.Children.Add (new CoposView (new CoposViewModel (CoposItem.WEIZEN)));
			this.Children.Add (new CoposView (new CoposViewModel (CoposItem.TULIPA)));
			this.Children.Add (new CoposView (new CoposViewModel (CoposItem.CALICE)));
			this.Children.Add (new CoposView (new CoposViewModel (CoposItem.FLAUTA)));
			this.Children.Add (new CoposView (new CoposViewModel (CoposItem.CANECA)));
			this.Children.Add (new CoposView (new CoposViewModel (CoposItem.MASS)));
			this.Children.Add (new CoposView (new CoposViewModel (CoposItem.YARD)));
			this.Children.Add (new CoposView (new CoposViewModel (CoposItem.TACA)));
			this.Children.Add (new CoposView (new CoposViewModel (CoposItem.TUMBLER)));
			this.Children.Add (new CoposView (new CoposViewModel (CoposItem.CILINDRICO)));
			this.Children.Add (new CoposView (new CoposViewModel (CoposItem.CONHAQUE)));

		}
	}
}
