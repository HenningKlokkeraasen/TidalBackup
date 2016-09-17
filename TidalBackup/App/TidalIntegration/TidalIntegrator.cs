using System;
using System.Threading.Tasks;
using OpenTidl;
using OpenTidl.Methods;

namespace TidalBackup.App.TidalIntegration
{
    public static class TidalIntegrator
    {
        public static async Task<OpenTidlSession> LoginUserAsync(string username, string password)
        {
            var client = new OpenTidlClient(ClientConfiguration.Default);
            OpenTidlSession session;
            try
            {
                session = await client.LoginWithUsername(username, password);
            }
            catch (Exception)
            {
                return null;
            }
            return session;
        }
    }
}