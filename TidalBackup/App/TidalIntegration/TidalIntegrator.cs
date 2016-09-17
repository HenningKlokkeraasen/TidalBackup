using System.Threading.Tasks;
using OpenTidl;
using OpenTidl.Methods;

namespace TidalBackup.App.TidalIntegration
{
    public class TidalIntegrator
    {
        private readonly OpenTidlClient _client;

        /// <summary>
        /// Creates an OpenTidlClient using ClientConfiguration.Default
        /// </summary>
        public TidalIntegrator()
        {
            _client = new OpenTidlClient(ClientConfiguration.Default);
        }

        public TidalIntegrator(OpenTidlClient client)
        {
            _client = client;
        }

        public async Task<OpenTidlSession> LoginUserAsync(string username, string password)
        {
            var openTidlSession = await _client.LoginWithUsername(username, password);
            return openTidlSession;
        }
    }
}