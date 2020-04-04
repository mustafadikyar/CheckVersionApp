using Android.Content.PM;
using CheckVersionApp.Dependencies;
using CheckVersionApp.Droid.Dependencies;
using Xamarin.Forms;

[assembly: Dependency(typeof(VersioningDependency))]
namespace CheckVersionApp.Droid.Dependencies
{
    class VersioningDependency : IAppVersioning
    {
        PackageInfo _appInfo;
        public VersioningDependency()
        {
            var context = Android.App.Application.Context;
            _appInfo = context.PackageManager.GetPackageInfo(context.PackageName, 0);
        }
        public string GetVersionNumber() => _appInfo.VersionName;
        public string GetBuildNumber() => _appInfo.VersionCode.ToString();
    }
}