using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CheckVersionApp.Dependencies;
using CheckVersionApp.iOS.Dependencies;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(VersioningDependency))]
namespace CheckVersionApp.iOS.Dependencies
{
    class VersioningDependency : IAppVersioning
    {
        public string GetVersionNumber() => NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleShortVersionString").ToString();
        public string GetBuildNumber() => NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleVersion").ToString();
    }
}