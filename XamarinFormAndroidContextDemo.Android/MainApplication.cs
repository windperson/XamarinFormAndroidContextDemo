using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;

namespace XamarinFormAndroidContextDemo.Droid
{
    [Application]
    public class MainApplication : Application, Application.IActivityLifecycleCallbacks
    {
        internal static Context CurrentContext { get; private set; }

        //NOTE: must have this empty constructor, or System.MissingMethodException will occured during runtime.
        public MainApplication(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
        {
            //left for empty
        }

        public override void OnCreate()
        {
            base.OnCreate();
            RegisterActivityLifecycleCallbacks(this);
        }

        public override void OnTerminate()
        {
            base.OnTerminate();
            UnregisterActivityLifecycleCallbacks(this);
        }

        public void OnActivityCreated(Activity activity, Bundle savedInstanceState)
        {
            CurrentContext = activity;
        }

        public void OnActivityDestroyed(Activity activity)
        {
            CurrentContext = null;
        }

        public void OnActivityPaused(Activity activity)
        {
            //do nothing
        }

        public void OnActivityResumed(Activity activity)
        {
            //do nothing
        }

        public void OnActivitySaveInstanceState(Activity activity, Bundle outState)
        {
            //do nothing
        }

        public void OnActivityStarted(Activity activity)
        {
            CurrentContext = activity;
        }

        public void OnActivityStopped(Activity activity)
        {
            //do nothing
        }
    }
}