using System;
using System.Collections.Generic;
using System.Text;

namespace CheckVersionApp.Dependencies
{
    public interface IAppVersioning
    {
        string GetVersionNumber();
        string GetBuildNumber();
    }
}
