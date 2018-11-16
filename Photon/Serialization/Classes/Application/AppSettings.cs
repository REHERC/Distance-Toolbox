using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Photon.Serialization.Data
{
    [DataContract, Serializable]
    public class AppSettings
    {
        [DataMember, XmlElement(IsNullable = false)]
        public string GameDir = "Not set.";
    }
}
