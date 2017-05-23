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
	public class Contato : ContentPage
	{
		public Contato ()
		{

			BackgroundColor = Helpers.AppColors.CONTENTLIGHTBKG;

			this.Title="Contato";

			var layout = new StackLayout { };

			var image = new Image { 
				Aspect = Aspect.AspectFit,
				VerticalOptions = LayoutOptions.StartAndExpand,
				HorizontalOptions = LayoutOptions.Center
			};

			image.Source = ImageSource.FromFile("icon.png");
			layout.Children.Add(image);

//			var label = new Label {
//				Text = "Camelo Beer (+55) 31 992 675 123",
//				TextColor = Helpers.AppColors.LABELBLACK,
//				VerticalOptions = LayoutOptions.FillAndExpand,
//				HorizontalOptions = LayoutOptions.Center,
//			};

			var makeCall = new Button {
				Text = "Camelo Beer (+55) 31 992 675 123",
				TextColor = Helpers.AppColors.LABELBLACK,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.Center,
			};
			makeCall.Clicked += (sender, e) => {

				if (Device.OS != TargetPlatform.WinPhone){
					Device.OpenUri(new Uri("tel:31992675123"));
				} else {
					DisplayAlert("To Do","Not implemented yet","OK");
				}
			};

			layout.Children.Add(makeCall);

			var openUrl = new Button {
				Text = "Acesse nossa FanPage: facebook.com/camelobeer",
				TextColor = Helpers.AppColors.LABELBLACK,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.Center,
			};
			openUrl.Clicked += (sender, e) => {
				if (Device.OS != TargetPlatform.WinPhone){
					Device.OpenUri(new Uri("http://facebook.com/camelobeer"));
				} else {
					DisplayAlert("To Do","Not implemented yet","OK");
				}
			};
			layout.Children.Add(openUrl);

			Content = layout;
		}
	}
}
