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


        [Option("setwindow", Required = false, HelpText = "Enables window positioning and sizing by comand line arguments.")]
        public bool Setwindow { get; set; }
        [Option("window-x", Required = false, HelpText = "Main window x position.")]
        public int Position_x { get; set; }
        [Option("window-y", Required = false, HelpText = "Main window y position.")]
        public int Position_y { get; set; }
        [Option("window-w", Required = false, HelpText = "Main window width.")]
        public int Size_w { get; set; }
        [Option("window-h", Required = false, HelpText = "Main window height.")]
        public int Size_h { get; set; }
        [Option("window-s", Required = false, HelpText = "Main window state.")]
        public int Window_s { get; set; }
    }
}
