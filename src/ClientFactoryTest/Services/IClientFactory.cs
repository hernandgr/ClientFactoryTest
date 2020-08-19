namespace ClientFactoryTest.Services
{
    public interface IClientFactory
    {
        NotAmazonClient GetClient(string secret);
    }
}