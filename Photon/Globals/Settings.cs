using Photon.Serialization;
using Photon.Serialization.Xml;

namespace Photon.Globals
{
    public static class Settings
    {
        public static void Initialize()
        {
            General = new Serializer<AppSettings>(SerializerType.Xml,"Settings",true);
            General.Save();

        }


        public static Serializer<AppSettings> General;



    }
}
