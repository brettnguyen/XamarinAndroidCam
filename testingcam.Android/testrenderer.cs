using System;
using System.ComponentModel;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Media;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace testingcam.Droid
{
    public class testrenderer : FrameLayout, IVisualElementRenderer, IViewRenderer, MediaPlayer.IOnCompletionListener, MediaPlayer.IOnInfoListener, MediaPlayer.IOnPreparedListener, MediaPlayer.IOnErrorListener, TextureView.ISurfaceTextureListener
    {
        private TextureView texture1;
        public testrenderer(Context context) : base(context)
        {
            var view = ((Activity)context).LayoutInflater.Inflate(Resource.Layout.testtexturing, null);
            AddView(view);
            texture1 = view.FindViewById<TextureView>(Resource.Id.test777);
            texture1.SurfaceTextureListener = this;
        }

        public testrenderer(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public testrenderer(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public testrenderer(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
        }

        protected testrenderer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public VisualElement Element => throw new NotImplementedException();

        public VisualElementTracker Tracker => throw new NotImplementedException();

        public ViewGroup ViewGroup => throw new NotImplementedException();

        public Android.Views.View View => throw new NotImplementedException();

        public event EventHandler<VisualElementChangedEventArgs> ElementChanged;
        public event EventHandler<PropertyChangedEventArgs> ElementPropertyChanged;

        public SizeRequest GetDesiredSize(int widthConstraint, int heightConstraint)
        {
            throw new NotImplementedException();
        }

        public void MeasureExactly()
        {
            throw new NotImplementedException();
        }

        public void OnCompletion(MediaPlayer mp)
        {
            throw new NotImplementedException();
        }

        public bool OnError(MediaPlayer mp, [GeneratedEnum] MediaError what, int extra)
        {
            throw new NotImplementedException();
        }

        public bool OnInfo(MediaPlayer mp, [GeneratedEnum] MediaInfo what, int extra)
        {
            throw new NotImplementedException();
        }

        public void OnPrepared(MediaPlayer mp)
        {
            throw new NotImplementedException();
        }

        public void OnSurfaceTextureAvailable(SurfaceTexture surface, int width, int height)
        {
            MediaPlayer mediaPlayer = new MediaPlayer();
            mediaPlayer.SetSurface(new Surface(surface));
            try
            {
                mediaPlayer.SetDataSource("my_video_file.mp4");
                mediaPlayer.Prepare();
                mediaPlayer.Start();
            }
            catch (Exception e)
            {
               // e.printStackTrace();
            }
        }

        public bool OnSurfaceTextureDestroyed(SurfaceTexture surface)
        {
            throw new NotImplementedException();
        }

        public void OnSurfaceTextureSizeChanged(SurfaceTexture surface, int width, int height)
        {
            throw new NotImplementedException();
        }

        public void OnSurfaceTextureUpdated(SurfaceTexture surface)
        {
            throw new NotImplementedException();
        }

        public void SetElement(VisualElement element)
        {
            throw new NotImplementedException();
        }

        public void SetLabelFor(int? id)
        {
            throw new NotImplementedException();
        }

        public void UpdateLayout()
        {
            throw new NotImplementedException();
        }
    }
}

