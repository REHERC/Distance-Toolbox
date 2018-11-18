using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Photon.Serialization.Data
{
    [DataContract, Serializable]
    public class AppSettings
    {
        [DataMember, XmlElement(IsNullable = false)]
        public string GameDir = "Not set.";

        [DataMember, XmlElement(IsNullable = false)]
        public string AppColor = Color.FromArgb(255, 36, 109, 145).Serialize();
    }
}
