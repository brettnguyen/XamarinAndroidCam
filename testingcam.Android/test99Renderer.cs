using AndroidX.Core.Content;
using testingcam;
using System.IO;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using testingcam.Droid;
using Android.Content;
using Android.App;
using AndroidX.AppCompat.App;
using Android.Views;
using testingcam.Droid.Camera;

[assembly: ExportRenderer(typeof(Test99View), typeof(test99Renderer))]
namespace testingcam.Droid
{
	public class test99Renderer : ButtonRenderer
    {
   

        private readonly Context _context;

        AutoFitTextureView autoTexture;
        public test99Renderer(Context context) : base(context)
        {
            _context = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var layoutInflater = LayoutInflater.From(Context);
                var view = layoutInflater.Inflate(Resource.Layout.mirror, null);
               
                Control.SetBackground(view.Background);

                Control.Click += Control_Click;

            }
        }

        private void Control_Click(object sender, System.EventArgs e)
        {
           
           
        }
    }
}

