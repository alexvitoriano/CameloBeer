using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Diagnostics;
using CameloBeer.Models;
using CameloBeer.Pages.Catalog;
using CameloBeer.Pages.Base;
using CameloBeer.ViewModels.Catalog;

namespace CameloBeer.Pages.Home
{
	public class InfoPage : ContentPage
	{
		public InfoPage ()
		{

			BackgroundColor = Helpers.AppColors.CONTENTLIGHTBKG;
			this.Title = "Historia";
			var layout = new StackLayout { };

			var image = new Image { 
				Aspect = Aspect.AspectFit,
				VerticalOptions = LayoutOptions.StartAndExpand,
				HorizontalOptions = LayoutOptions.Center
			};

			image.Source = ImageSource.FromFile("icon.png");
			layout.Children.Add(image);

			var label = new Label {
				Text = "Camelo Beer, levando o melhor das cervejarias para os melhores locais. \n"+ 
					"Cervejas artesanais e especiais.",
				TextColor = Helpers.AppColors.LABELBLACK,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand

			};

			layout.Children.Add(label);

			Content = layout;
		}
	}
}
