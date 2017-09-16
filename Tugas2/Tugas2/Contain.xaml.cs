using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas2.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tugas2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Contain : ContentPage
	{
		public Contain (string param)
        {
			InitializeComponent ();
            lblParam.Text = param;
            if (lblParam.Text.Equals("BR-V"))
            {
                picture.Source = "brv.png";
                lblParam3.Text = "CUV 1500 cc Bensin 7 Penumpang";
            }
            else if(lblParam.Text.Equals("Calya"))
            {
                picture.Source = "calya.png";
                lblParam3.Text = "CUV 1000 cc Bensin 7 Penumpang";
            }
            else if (lblParam.Text.Equals("Karimun Wagon R"))
            {
                picture.Source = "karimun.png";
                lblParam3.Text = "Hatchback 1000 cc Bensin 5 Penumpang";
            }
            else if (lblParam.Text.Equals("Sigra"))
            {
                picture.Source = "sigra.png";
                lblParam3.Text = "Sigra 1000 cc Bensin 5 Penumpang";
            }
            else if (lblParam.Text.Equals("GO+"))
            {
                picture.Source = "goplus.png";
                lblParam3.Text = "Goplus 1000 cc Bensin 5 Penumpang";
            }else
            {
                picture.Source = "mirage.png";
                lblParam3.Text = "Mirage 1000 cc Bensin 5 Penumpang";
            }
            btnBack.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync(true);
            };
        }
    }
}
