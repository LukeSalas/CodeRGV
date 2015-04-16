using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ColorsDemo
{
	public sealed partial class App : Application
	{
		void HardwareButtons_BackPressed(object sender, Windows.Phone.UI.Input.BackPressedEventArgs e)
		{
			var frame = Window.Current.Content as Frame;
			if (frame.CanGoBack)
			{
				frame.GoBack();
				e.Handled = true;
			}
		}
	}
}
