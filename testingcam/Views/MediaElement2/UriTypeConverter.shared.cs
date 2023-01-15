using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testingcam.MediaElement2.Views
{
	[TypeConversion(typeof(Uri))]
	public class UriTypeConverter : TypeConverter
	{
		public override object ConvertFromInvariantString(string value)
		{
			return string.IsNullOrWhiteSpace(value) ? null : new Uri(value, UriKind.RelativeOrAbsolute);
		}
	}
}
