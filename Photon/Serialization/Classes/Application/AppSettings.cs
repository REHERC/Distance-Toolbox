using FileHelpers;
using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Photon.Serialization.Data
{
    [DataContract, Serializable, DelimitedRecord(",")]
    public class AppSettings
    {
        [DataMember, XmlElement(IsNullable = false)]
        public string GameDir { get; set; } = "Not set.";

        [DataMember, XmlElement(IsNullable = false)]
        public string AppColor { get; set; } = Color.FromArgb(255, 36, 109, 145).Serialize();

        [DataMember, XmlElement(IsNullable = false)]
        public bool DarkTheme { get; set; } = false;
    }
}
