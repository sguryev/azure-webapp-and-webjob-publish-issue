namespace WebJobDeployment.Services
{
    using SendGrid;

    public class TestService
    {
        private readonly Client _client;

        public TestService()
        {
            _client = new Client("test");
        }
    }
}
