using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace BIBLIOTEKA2
{
    internal class XmlHelper
    {
        public static void SpremiXml<T>(List<T> lista, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, lista);
            }
        }

        public static List<T> UcitajXml<T>(string path)
        {
            if (!File.Exists(path)) return new List<T>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (TextReader reader = new StreamReader(path))
            {
                return (List<T>)serializer.Deserialize(reader);
            }
        }
    }
}
