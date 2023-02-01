using System;
using Android.Content;
using Android.Graphics;
using Android.Media;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Java.Interop;

namespace testingcam.Droid
{
    public class Texturetest :TextureView, TextureView.ISurfaceTextureListener
    {
        public Texturetest(Context context) : base(context)
        {
            
        }

        public Texturetest(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public Texturetest(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public Texturetest(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
        }

        protected Texturetest(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public IntPtr Handle => throw new NotImplementedException();

        public int JniIdentityHashCode => throw new NotImplementedException();

        public JniObjectReference PeerReference => throw new NotImplementedException();

        public JniPeerMembers JniPeerMembers => throw new NotImplementedException();

        public JniManagedPeerStates JniManagedPeerState => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Disposed()
        {
            throw new NotImplementedException();
        }

        public void DisposeUnlessReferenced()
        {
            throw new NotImplementedException();
        }

        public void Finalized()
        {
            throw new NotImplementedException();
        }

        public void OnSurfaceTextureAvailable(SurfaceTexture surface, int width, int height)
        {
            throw new NotImplementedException();
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

        public void SetJniIdentityHashCode(int value)
        {
            throw new NotImplementedException();
        }

        public void SetJniManagedPeerState(JniManagedPeerStates value)
        {
            throw new NotImplementedException();
        }

        public void SetPeerReference(JniObjectReference reference)
        {
            throw new NotImplementedException();
        }

        public void UnregisterFromRuntime()
        {
            throw new NotImplementedException();
        }
    }
}

