using System;

namespace ClientFactoryTest.Services
{
    public class NotAmazonClient
    {
        public string Secret { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public NotAmazonClient(string secret)
        {
            Secret = secret;
            CreatedAt = DateTime.Now;
        }
    }
}