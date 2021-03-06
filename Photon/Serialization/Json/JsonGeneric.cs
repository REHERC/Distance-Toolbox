﻿using System.IO;
using Newtonsoft.Json;

namespace Photon.Serialization
{
    public sealed class JsonGenericSerializer<SERIALIZER_TYPE> : ISerializer<SERIALIZER_TYPE> where SERIALIZER_TYPE : class, new()
    {
        public void Serialize(SERIALIZER_TYPE DATA, string FilePath)
        {
            if (File.Exists(FilePath))
                File.Delete(FilePath);
            JsonSerializer SERIALIZER = new JsonSerializer();
            using (StreamWriter FILE_STREAM = new StreamWriter(FilePath))
            {
                using (JsonWriter JSON_WRITER = new JsonTextWriter(FILE_STREAM))
                {
                    JSON_WRITER.Formatting = Formatting.Indented;
                    SERIALIZER.Serialize(JSON_WRITER, DATA);
                }
            }
        }

        public SERIALIZER_TYPE Deserialize(string FilePath, bool ShowError = true)
        {
            if (!(File.Exists(FilePath)))
                if (ShowError)
                    throw new FileNotFoundException();
                else
                    return new SERIALIZER_TYPE();
            SERIALIZER_TYPE DESERIALIZED_OBJECT = new SERIALIZER_TYPE();
            string SERIALIZED_TEXT = "";
            using (StreamReader READER = new StreamReader(FilePath))
            {
                SERIALIZED_TEXT = READER.ReadToEnd();
            }
            DESERIALIZED_OBJECT = JsonConvert.DeserializeObject<SERIALIZER_TYPE>(SERIALIZED_TEXT);
            return DESERIALIZED_OBJECT;
        }
    }
}
