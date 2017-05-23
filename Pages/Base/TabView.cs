using CameloBeer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CameloBeer.Pages.Base
{
	public class TabView: TabbedPage
	{
		public TabView(string title, IEnumerable<Page> pages, BaseViewModel viewModel = null)
		{
			Title = title;
			this.BindingContext = viewModel;
			viewModel.Navigation = Navigation;
			foreach (var page in pages)
			{
				this.Children.Add(page);
			}
		}
	}
}
