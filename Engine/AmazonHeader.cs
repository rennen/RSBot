using System.ServiceModel.Channels;
using System.Xml;

namespace Engine
{
    public class AmazonHeader : MessageHeader
    {
        private readonly string value;

        public AmazonHeader(string name, string value)
        {
            this.Name = name;
            this.value = value;
        }

        public override string Name { get; }

        public override string Namespace { get; } = "http://security.amazonaws.com/doc/2007-01-01/";

        protected override void OnWriteHeaderContents(XmlDictionaryWriter writer, MessageVersion messageVersion)
        {
            writer.WriteString(value);
        }
    }
}