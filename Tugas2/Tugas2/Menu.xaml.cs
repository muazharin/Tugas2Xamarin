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
	public partial class Menu : ContentPage
	{
		public Menu ()
		{
			InitializeComponent ();
            BindingContext = new ListView();
        }
        private async void listview_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListItems item = (ListItems)e.Item;
            await Navigation.PushAsync(new Contain(item.Title));
        }
        public class ListView : BindableObject
        {
            private List<ListItems> listItems;
            public INavigation Navigation { get; }
            public List<ListItems> ListItems
            {
                get { return listItems; }
                set
                {
                    listItems = value;
                    OnPropertyChanged("ListItems");
                }
            }
            public ListView()
            {
                listItems = new List<ListItems>
                {
                    new ListItems{Source="calya.png",Title="Calya", Description="Angsuran Mulai Rp. 2.405.000" },
                    new ListItems {Source="karimun.png",Title="Karimun Wagon R", Description="Angsuran Mulai Rp. 2.800.000" },
                    new ListItems {Source="sigra.png",Title="Sigra", Description="Angsuran Mulai Rp. 2.533.000" },
                    new ListItems {Source="brv.png",Title="BR-V", Description="Angsuran Mulai Rp. 5.435.000" },
                    new ListItems {Source="goplus.png",Title="GO+", Description=" " },
                    new ListItems {Source="mirage.png",Title="Mirage", Description="Angsuran Mulai Rp. 4.471.616" }
                };
            }
        }
	}
}
