using System.Collections.Generic;

namespace ClientFactoryTest.Services
{
    public class ClientFactory : IClientFactory
    {
        private readonly Dictionary<string, NotAmazonClient> clients;

        public ClientFactory()
        {
            clients = new Dictionary<string, NotAmazonClient>();
        }

        public NotAmazonClient GetClient(string secret)
        {
            if (!clients.ContainsKey(secret))
            {
                clients.Add(secret, new NotAmazonClient(secret));
            }

            return clients[secret];
        }
    }
}