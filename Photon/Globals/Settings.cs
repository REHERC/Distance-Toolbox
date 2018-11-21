using Photon.Serialization;
using Photon.Serialization.Data;
using System.Windows.Forms;

namespace Photon.Globals
{
    public static class Settings
    {
        public static void Initialize()
        {
            Globals.Variables.AppPath = Application.StartupPath;
            General = new Serializer<AppSettings>(SerializerType.Xml,"Settings",true);
            General.Save(); // Create the settings file if it doesn't exist (this doesn't overwrites the file if it already exists)
            Globals.Colors.PRIMARY_Main = ColorExtensions.Deserialize(General.Data.AppColor);
        }
        public static Serializer<AppSettings> General;
    }
}
