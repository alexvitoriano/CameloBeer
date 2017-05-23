using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CameloBeer.Models;

namespace CameloBeer.ViewModels.Copos
{
	public class CoposViewModel:BaseViewModel
	{
		private CoposItem coposItem;

		public CoposViewModel (string copoItem)
		{
			this.Title="Copos";
			this.Icon="copos.png";

			this.coposItem = CoposItem.CreateCopoItem(copoItem);
		}

		public CoposItem Copo
		{
			get
			{
				return coposItem;
			}
			set
			{
				coposItem = value;
			}
		}

	}
}