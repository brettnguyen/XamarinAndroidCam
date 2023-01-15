using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testingcam.Core
{
	[TypeConversion(typeof(FileMediaSource))]
	public sealed class FileMediaSourceConverter : TypeConverter
	{
		public override object ConvertFromInvariantString(string value)
		{
			return value != null
				? (FileMediaSource)MediaSource.FromFile(value)
				: throw new InvalidOperationException($"Cannot convert \"{value}\" into {typeof(FileMediaSource)}");
		}
	}
}
