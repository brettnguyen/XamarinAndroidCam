using System;
using Android.Content;
using Android.Runtime;
using Android.Util;

using Android.Views;

namespace testingcam.Droid.Camera
{
    public class Surfacetest : SurfaceView
    {
        public Surfacetest(Context context) : base(context)
        {
            ScaleX = -1;
            
        }

        public Surfacetest(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public Surfacetest(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public Surfacetest(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
        }

        protected Surfacetest(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
    }
}

