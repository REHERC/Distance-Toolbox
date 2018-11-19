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
            General.Save();
            Globals.Colors.PRIMARY_Main = ColorExtensions.Deserialize(General.Data.AppColor);
        }
        public static Serializer<AppSettings> General;
    }
}
