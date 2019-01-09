using FileHelpers;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Photon.Serialization.Data
{
    [DataContract, Serializable, DelimitedRecord(",")]
    public class PluginManifest
    {
        [DataMember, XmlElement(IsNullable = false)]
        public string FriendlyName { get; set; } = "Plugin";

        [DataMember, XmlElement(IsNullable = false)]
        public string Author { get; set; } = "Author";

        [DataMember, XmlElement(IsNullable = false)]
        public string AuthorContact { get; set; } = "Author Contact";

        [DataMember, XmlElement(IsNullable = false)]
        public int CompatibleAPILevel { get; set; } = 6;

        [DataMember, XmlElement(IsNullable = false)]
        public string IPCIdentifier { get; set; } = "Plugin";

        [DataMember, XmlElement(IsNullable = false)]
        public string ModuleFileName { get; set; } = "Plugin.dll";

        [DataMember, XmlElement(IsNullable = false)]
        public string EntryClassName { get; set; } = "Entry";

        [DataMember, XmlElement(IsNullable = false)]
        public int Priority { get; set; } = 10;

        [DataMember, XmlElement(IsNullable = false)]
        public string[] Dependencies { get; set; } = {
            ""
        };

        [DataMember, XmlElement(IsNullable = false)]
        public bool SkipLoad { get; set; } = false;
    }
}
