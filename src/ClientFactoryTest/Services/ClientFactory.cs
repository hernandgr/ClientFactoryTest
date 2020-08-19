using System.Collections.Generic;

namespace ClientFactoryTest.Services
{
    public class ClientFactory : IClientFactory
    {
        private readonly Dictionary<string, NotAmazonClient> _clients;

        public ClientFactory()
        {
            _clients = new Dictionary<string, NotAmazonClient>();
        }

        public NotAmazonClient GetClient(string secret)
        {
            if (!_clients.ContainsKey(secret))
            {
                _clients.Add(secret, new NotAmazonClient(secret));
            }

            return _clients[secret];
        }
    }
}
