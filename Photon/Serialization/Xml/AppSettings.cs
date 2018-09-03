using System.Xml.Serialization;

namespace Photon.Serialization.Xml
{
    public class AppSettings
    {
        [XmlElement(IsNullable = false)]
        public string GameDir = "Not set.";
    }
}
