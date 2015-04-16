using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace ColorsDemo.Models
{
	public class ColorInfo
	{
		private static List<ColorInfo> Colors;

		public ColorInfo(string name, Color color)
		{
			Color = color;
			Name = name;
		}

		public string Name { get; set; }
		public Color Color { get; set; }
		public SolidColorBrush Brush { get { return new SolidColorBrush(this.Color); } }
	}
}
