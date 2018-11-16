using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Photon.Serialization.Data
{
    [DataContract, Serializable]
    public class PluginManifest
    {
        [DataMember, XmlElement(IsNullable = false)]
        public string FriendlyName = "Plugin";

        [DataMember, XmlElement(IsNullable = false)]
        public string Author = "Author";

        [DataMember, XmlElement(IsNullable = false)]
        public int CompatibleAPILevel = 6;

        [DataMember, XmlElement(IsNullable = false)]
        public string IPCIdentifier = "Plugin";

        [DataMember, XmlElement(IsNullable = false)]
        public string ModuleFileName = "Plugin.dll";

        [DataMember, XmlElement(IsNullable = false)]
        public string EntryClassName = "Entry";

        [DataMember, XmlElement(IsNullable = false)]
        public int Priority = 10;

        [DataMember, XmlElement(IsNullable = false)]
        public string[] Dependencies = {
            ""
        };

        [DataMember, XmlElement(IsNullable = false)]
        public bool SkipLoad = false;
    }
}
