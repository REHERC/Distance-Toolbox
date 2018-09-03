﻿using System;
using Photon.Globals;

namespace Photon.Serialization
{
    public class Serializer<DATA_TYPE> : ICloneable where DATA_TYPE : class, new()
    {
        private string FilePath;
        public DATA_TYPE Data;
        private ISerializer<DATA_TYPE> DataSerializer;
        
        public Serializer(SerializerType Type, string FileName, bool LoadOnCtor = true)
        {
            switch (Type)
            {
                case SerializerType.Xml:
                    DataSerializer = new XmlGenericSerializer<DATA_TYPE>();
                    break;
                case SerializerType.Json:
                    DataSerializer = new JsonGenericSerializer<DATA_TYPE>();
                    break;
            }

            FilePath = $@"{Variables.AppPath}\{FileName}.{Type.ToString().ToLowerInvariant()}";

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