using System;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.IO;
//using Xamarin.CommunityToolkit.UI.Views;

using SkiaSharp;

using System.Threading.Tasks;

namespace testingcam.Views
{
    public partial class AboutPage : ContentPage
    {

	

		public AboutPage()
        {
			InitializeComponent();
           // zoomLabel.Text = string.Format("Zoom: {0}", zoomSlider.Value);
        }

		/* void ZoomSlider_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			cameraView.Zoom = (float)zoomSlider.Value;
			zoomLabel.Text = string.Format("Zoom: {0}", Math.Round(zoomSlider.Value));
		}

		void VideoSwitch_Toggled(object sender, ToggledEventArgs e)
		{
			var captureVideo = e.Value;

			if (captureVideo)
				cameraView.CaptureMode = CameraCaptureMode.Video;
			else
				cameraView.CaptureMode = CameraCaptureMode.Photo;

			previewPicture.IsVisible = !captureVideo;

			doCameraThings.Text = e.Value ? "Start Recording"
				: "Snap Picture";
		}

		// You can also set it to Default and External
		void FrontCameraSwitch_Toggled(object sender, ToggledEventArgs e)
			=> cameraView.CameraOptions = e.Value ? CameraOptions.Front : CameraOptions.Back;

		// You can also set it to Torch (always on) and Auto
		void FlashSwitch_Toggled(object sender, ToggledEventArgs e)
			=> cameraView.FlashMode = e.Value ? CameraFlashMode.On : CameraFlashMode.Off;

		void DoCameraThings_Clicked(object sender, EventArgs e)
		{
			cameraView.Shutter();
			doCameraThings.Text = cameraView.CaptureMode == CameraCaptureMode.Video
				? "Stop Recording"
				: "Snap Picture";
		}

		void CameraView_OnAvailable(object sender, bool e)
		{
			if (e)
			{
				zoomSlider.Value = cameraView.Zoom;
				var max = cameraView.MaxZoom;
				if (max > zoomSlider.Minimum && max > zoomSlider.Value)
					zoomSlider.Maximum = max;
				else
					zoomSlider.Maximum = zoomSlider.Minimum + 1; // if max == min throws exception
			}

			doCameraThings.IsEnabled = e;
			zoomSlider.IsEnabled = e;
		}

	 void CameraView_MediaCaptured(object sender, MediaCapturedEventArgs e)
		{
			switch (cameraView.CaptureMode)
			{
				default:
				case CameraCaptureMode.Default:
				case CameraCaptureMode.Photo:
					previewVideo.IsVisible = false;
					previewPicture.IsVisible = true;
					//SKBitmap photo = BitmapExtensions.Rotate90(SKBitmap.Decode(e.ImageData));
					//previewPicture.Source = ImageSource.FromStream(() => SKImage.FromBitmap(photo).Encode().AsStream());
					previewPicture.Source = e.Image;

					doCameraThings.Text = "Snap Picture";
					break;
				case CameraCaptureMode.Video:
					previewPicture.IsVisible = false;
					previewVideo.IsVisible = true;
					previewVideo.Source = e.Video;
					doCameraThings.Text = "Start Recording";
					break;
			}

			

		}

		static class BitmapExtensions
		{
			public static SKBitmap Rotate90(SKBitmap original)
			{
				SKBitmap rotated = new SKBitmap(original.Height, original.Width);

				using (var surface = new SKCanvas(rotated))
				{
					surface.Translate(rotated.Width, 0);
					surface.RotateDegrees(90);
					surface.DrawBitmap(original, 00, 0);
				}

				return rotated;

			}

		}
		*/
		
	}

	
}
