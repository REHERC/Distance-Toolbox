using System;
using Photon.Globals;

namespace Photon.Serialization
{
    public class Serializer<DATA_TYPE> : ICloneable where DATA_TYPE : class, new()
    {
        private readonly string FilePath;
        public DATA_TYPE Data;
        private ISerializer<DATA_TYPE> DataSerializer;
        
        public Serializer(SerializerType Type, string FileName, bool LoadOnCtor = true, bool AbsolutePath = false)
        {
            switch (Type)
            {
                case SerializerType.Xml:
                    DataSerializer = new XmlGenericSerializer<DATA_TYPE>();
                    break;
                case SerializerType.Json:
                    DataSerializer = new JsonGenericSerializer<DATA_TYPE>();
                    break;
                case SerializerType.Bin:
                    DataSerializer = new BinGenericSerializer<DATA_TYPE>();
                    break;
                case SerializerType.Yaml:
                    DataSerializer = new YamlGenericSerializer<DATA_TYPE>();
                    break;
                case SerializerType.Csv:
                    DataSerializer = new CsvGenericSerializer<DATA_TYPE>();
                    break;
            }
            
            if (!AbsolutePath)
            {
                FilePath = $@"{Variables.AppPath}\{FileName}.{Type.ToString().ToLowerInvariant()}";
            }
            else
            {
                FilePath = FileName;
            }

            if (LoadOnCtor)
                Load();
            else
                Data = new DATA_TYPE();
        }
        
        public void Save()
        {
            DataSerializer.Serialize(Data, FilePath);
        }

        public void Load()
        {
            Data = DataSerializer.Deserialize(FilePath, false);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
