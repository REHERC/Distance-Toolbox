using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Photon.Serialization.Data
{
    [DataContract, Serializable]
    public class ManagerSettings
    {
        [DataMember, XmlElement(IsNullable = false)]
        public bool LogToConsole = true;

        [DataMember, XmlElement(IsNullable = false)]
        public bool ShowWatermark = true;

        [DataMember, XmlElement(IsNullable = false)]
        public bool Enabled = true;
    }
}
