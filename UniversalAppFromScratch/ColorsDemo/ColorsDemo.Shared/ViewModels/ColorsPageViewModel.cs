using ColorsDemo.Common;
using ColorsDemo.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Windows.UI;
using System.Reflection;
using Windows.UI.Xaml.Media;

namespace ColorsDemo.ViewModels
{
    public class ColorsPageViewModel : BindableBase
    {
		public ColorsPageViewModel()
		{
			GroupColors = new ObservableCollection<ColorInfo>();

			foreach (var color in ColorsHelper.Colors.OrderBy(x => Guid.NewGuid()).Take(24))
				GroupColors.Add(color);

			this.Name = "Selected Color";
		}

		public string Name { get; set; }

		public SolidColorBrush GroupColor { get { return new SolidColorBrush(GroupColors.First().Color); } }

		public ObservableCollection<ColorInfo> GroupColors { get; set; }

		private ColorInfo selectedColor;
		public ColorInfo SelectedColor
		{
			get { return selectedColor; }
			set { SetProperty(ref selectedColor, value); }
		}
    }
}
