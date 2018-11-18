using CommandLine;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photon
{
    class CommandLineArguments
    {
        [Option("source", Default = "pages:home", Required = false, HelpText = "The page the application will show on startup.")]
        public string Source { get; set; }

        [Option("nosplash", Required = false, HelpText = "Hide the splash screen on startup.")]
        public bool Splash { get; set; }
    }
}
