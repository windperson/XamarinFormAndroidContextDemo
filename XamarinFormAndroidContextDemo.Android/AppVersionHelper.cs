using XamarinFormAndroidContextDemo.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(AppVersionHelper))]
namespace XamarinFormAndroidContextDemo.Droid
{
    public class AppVersionHelper : IAppVersionHelper
    {
        public string GetVersion()
        {
            var ret = string.Empty;
            if (MainApplication.CurrentContext != null)
            {
                ret = MainApplication.CurrentContext.PackageManager
                    .GetPackageInfo(MainApplication.CurrentContext.PackageName, 0).VersionName;
            }

            return ret;
        }
    }
}