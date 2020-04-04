using CheckVersionApp.Dependencies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CheckVersionApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var versionNumber = DependencyService.Get<IAppVersioning>().GetVersionNumber();
            var buildNumber = DependencyService.Get<IAppVersioning>().GetBuildNumber();
        }

        public List<string> VersionAndBuildNumber => new List<string> { DependencyService.Get<IAppVersioning>().GetVersionNumber(), DependencyService.Get<IAppVersioning>().GetBuildNumber() };
    }
}
