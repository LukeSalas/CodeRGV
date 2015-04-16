using ColorsDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Windows.UI;
using System.Linq;

namespace ColorsDemo.Common
{
    public static class ColorsHelper
    {
		private static List<ColorInfo> colors;
		public static List<ColorInfo> Colors
		{
			get
			{
				if (colors == null)
				{
						colors = typeof(Colors)
							.GetRuntimeProperties()
							.Select(x => new ColorInfo(x.Name, (Color)x.GetValue(null))).ToList();
				}

				return colors;
			}
		}
    }
}
