using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;

namespace HW_2_5
{
    public abstract class Loger
    {
        public abstract void Log(LoggerConfig log);

        public SerealizeType Type { get; set; } = SerealizeType.xml;

        public enum SerealizeType
        {
            xml,
            json
        }

        public string Serialize(LoggerConfig log)
        {
            string config;
            if (Type == SerealizeType.json)
                config = JsonConvert.SerializeObject(log);
            else
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(LoggerConfig));
                using (StringWriter writer = new StringWriter())
                {
                    xmlSerializer.Serialize(writer, log);
                    config = writer.ToString();
                }
            }
            return config;
        }

    }
}
