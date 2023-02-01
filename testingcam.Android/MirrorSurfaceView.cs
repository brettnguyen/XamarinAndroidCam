using System;
using Android.Content;
using Android.Graphics;
using Android.Util;
using Android.Views;

namespace testingcam.Droid
{
    public class MirrorSurfaceView : TextureView
    {
        int mRatioWidth = 0;
        int mRatioHeight = 0;
        public MirrorSurfaceView(Context context) : base(context)
        {
        }

        public MirrorSurfaceView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public MirrorSurfaceView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public void SetAspectRatio(int width, int height)
        {

            if (width == 0 || height == 0)
                throw new ArgumentException("Size cannot be negative.");
            mRatioWidth = width;
            mRatioHeight = height;
            RequestLayout();
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
            var width = MeasureSpec.GetSize(widthMeasureSpec);
            var height = MeasureSpec.GetSize(heightMeasureSpec);

            if (mRatioWidth == 0 || mRatioHeight == 0)
                SetMeasuredDimension(width, height);
            else
            {
                if (width < (float)height * mRatioWidth / mRatioHeight)
                    SetMeasuredDimension(height * mRatioWidth / mRatioHeight, height);
                else
                    SetMeasuredDimension(width, width * mRatioHeight / mRatioWidth);
            }
        }

    }
}

