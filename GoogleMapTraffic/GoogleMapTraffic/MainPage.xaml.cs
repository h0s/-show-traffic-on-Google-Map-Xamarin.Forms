using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace GoogleMapTraffic
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		    mymap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(36.836059, 10.240196), Xamarin.Forms.Maps.Distance.FromKilometers(15)));

        }
    }
}
