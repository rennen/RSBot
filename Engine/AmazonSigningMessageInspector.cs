using System;
using System.Security.Cryptography;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Text.RegularExpressions;

namespace Engine
{
    public class AmazonSigningMessageInspector : IClientMessageInspector
    {
        private readonly string accessKeyId;
        private readonly string secretKey;

        public AmazonSigningMessageInspector(string accessKeyId, string secretKey)
        {
            this.accessKeyId = accessKeyId;
            this.secretKey = secretKey;
        }

        public Object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            var operation = Regex.Match(request.Headers.Action, "[^/]+$").ToString();
            var now = DateTime.UtcNow;
            var timestamp = now.ToString("yyyy-MM-ddTHH:mm:ssZ");
            var signMe = operation + timestamp;
            var bytesToSign = Encoding.UTF8.GetBytes(signMe);

            var secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);
            HMAC hmacSha256 = new HMACSHA256(secretKeyBytes);
            var hashBytes = hmacSha256.ComputeHash(bytesToSign);
            var signature = Convert.ToBase64String(hashBytes);

            request.Headers.Add(new AmazonHeader("AWSAccessKeyId", accessKeyId));
            request.Headers.Add(new AmazonHeader("Timestamp", timestamp));
            request.Headers.Add(new AmazonHeader("Signature", signature));
            return null;
        }

        void IClientMessageInspector.AfterReceiveReply(ref Message Message, Object correlationState)
        {
        }
    }
}