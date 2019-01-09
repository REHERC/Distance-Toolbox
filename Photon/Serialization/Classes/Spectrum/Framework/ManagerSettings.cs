using FileHelpers;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Photon.Serialization.Data
{
    [DataContract, Serializable, DelimitedRecord(",")]
    public class ManagerSettings
    {
        [DataMember, XmlElement(IsNullable = false)]
        public bool LogToConsole { get; set; } = true;

        [DataMember, XmlElement(IsNullable = false)]
        public bool ShowWatermark { get; set; } = true;

        [DataMember, XmlElement(IsNullable = false)]
        public bool Enabled { get; set; } = true;
    }
}
