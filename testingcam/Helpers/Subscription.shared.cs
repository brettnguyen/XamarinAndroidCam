using System;
using System.Reflection;

namespace testingcam.Helpers
{
	struct Subscription
	{
		public WeakReference Subscriber { get; }

		public MethodInfo Handler { get; }

		public Subscription(WeakReference subscriber, MethodInfo handler)
		{
			Subscriber = subscriber;
			Handler = handler ?? throw new ArgumentNullException(nameof(handler));
		}
	}
}
