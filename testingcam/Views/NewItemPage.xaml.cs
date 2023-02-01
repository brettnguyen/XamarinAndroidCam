using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using testingcam.Models;
using testingcam.ViewModels;
using testingcam.CameraView2;

namespace testingcam.Views
{
    public partial class NewItemPage : ContentPage
    {
  

        public NewItemPage()
        {
            InitializeComponent();
            

        }

		 void ZoomSlider_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			
			
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
			

			doCameraThings.IsEnabled = e;
			
		}

	 void CameraView_MediaCaptured(object sender, MediaCapturedEventArgs e)
		{
			switch (cameraView.CaptureMode)
			{
				default:
				case CameraCaptureMode.Default:
				case CameraCaptureMode.Photo:
					
					previewPicture.IsVisible = true;
					previewVideo.IsVisible = false;
					//SKBitmap photo = BitmapExtensions.Rotate90(SKBitmap.Decode(e.ImageData));
					//previewPicture.Source = ImageSource.FromStream(() => SKImage.FromBitmap(photo).Encode().AsStream());
					previewPicture.Source = e.Image;
					//previewPicture.Rotation = e.Rotation;
					doCameraThings.Text = "Snap Picture";
					break;
				case CameraCaptureMode.Video:
					previewPicture.IsVisible = false;
					/*
					if (cameraView.CameraOptions == CameraOptions.Back)
					{
						previewVideo.IsVisible = true;
						previewVideo.Source = e.Video;
					}
					else
					{

					}
					*/
					doCameraThings.Text = "Start Recording";
					break;
			}

			

		}

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
			cameraView.Reset();
        }


    }
}
