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
            
            Serializer<ManagerSettings> JSON = new Serializer<ManagerSettings>(SerializerType.Json, "ManagerSettings", true);
            Serializer<ManagerSettings> XML = new Serializer<ManagerSettings>(SerializerType.Xml, "ManagerSettings", true);
            Serializer<ManagerSettings> BIN = new Serializer<ManagerSettings>(SerializerType.Bin, "ManagerSettings", true);
            Serializer<ManagerSettings> YAML = new Serializer<ManagerSettings>(SerializerType.Yaml, "ManagerSettings", true);
            Serializer<ManagerSettings> CSV = new Serializer<ManagerSettings>(SerializerType.Csv, "ManagerSettings", true);

            JSON.Save();
            XML.Save();
            BIN.Save();
            YAML.Save();
            CSV.Save();

            General = new Serializer<AppSettings>(SerializerType.Xml,"Settings",true);
            General.Save(); // Create the settings file if it doesn't exist (this doesn't overwrites the file if it already exists)
            Globals.Colors.PRIMARY_Main = ColorExtensions.Deserialize(General.Data.AppColor);
        }
        public static Serializer<AppSettings> General;
    }
}
