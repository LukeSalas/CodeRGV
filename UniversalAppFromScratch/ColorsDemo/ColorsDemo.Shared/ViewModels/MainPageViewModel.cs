using ColorsDemo.Common;
using ColorsDemo.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Windows.UI;
using System.Reflection;

namespace ColorsDemo.ViewModels
{
	public class MainPageViewModel : BindableBase
	{
		public MainPageViewModel()
		{
			ColorGroups = new ObservableCollection<ColorGroup>();

			for (var i = 1; i <= 8; i++)
				ColorGroups.Add(new ColorGroup("Group " + i, ColorsHelper.Colors.OrderBy(x => Guid.NewGuid()).Take(6)));

		}

		public ObservableCollection<ColorGroup> ColorGroups { get; set; }


	}
}
