using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormAndroidContextDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		    var version = DependencyService.Get<IAppVersionHelper>().GetVersion();
            Console.WriteLine($"version={version}");
		}
	}
}
