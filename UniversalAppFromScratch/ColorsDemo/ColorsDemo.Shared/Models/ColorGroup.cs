using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace ColorsDemo.Models
{
	public class ColorGroup
	{
		public ColorGroup()
		{
			this.Colors = new ObservableCollection<ColorInfo>();
		}

		public ColorGroup(string name, IEnumerable<ColorInfo> colors) : this()
		{
			this.Name = name;
			foreach (var color in colors)
				Colors.Add(color);

		}

		public string Name { get; set; }

		public SolidColorBrush GroupColor { get { return new SolidColorBrush(this.Colors.First().Color); } }

		public ObservableCollection<ColorInfo> Colors { get; set; }
	}
}
