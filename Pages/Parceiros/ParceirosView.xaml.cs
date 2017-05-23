using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CameloBeer.Pages.Parceiros
{
	public partial class ParceirosView 
	{
		public ParceirosView ()
		{
			InitializeComponent();

			this.Title = "Parceiros Camelo Beer";
		
		}

		void OnButtonClicked_imgOLEC(object sender, EventArgs args)
		{
			if (Device.OS != TargetPlatform.WinPhone){
				Device.OpenUri(new Uri("http://casaolec.com.br"));
			} else {
				DisplayAlert("To Do","Not implemented yet","OK");
			}
		}
			
		void OnButtonClicked_imgFMER(object sender, EventArgs args)
		{
			if (Device.OS != TargetPlatform.WinPhone){
				Device.OpenUri(new Uri("http://fmer.com.br"));
			} else {
				DisplayAlert("To Do","Not implemented yet","OK");
			}
		}

		void OnButtonClicked_imgExB(object sender, EventArgs args)
		{
			if (Device.OS != TargetPlatform.WinPhone){
				Device.OpenUri(new Uri("http://experimentobeer.com"));
			} else {
				DisplayAlert("To Do","Not implemented yet","OK");
			}
		}

		void OnButtonClicked_btnAlex(object sender, EventArgs args)
		{
			if (Device.OS != TargetPlatform.WinPhone){
				Device.OpenUri(new Uri("http://alexvitoriano.com"));
			} else {
				DisplayAlert("To Do","Not implemented yet","OK");
			}
		}
	}
}
