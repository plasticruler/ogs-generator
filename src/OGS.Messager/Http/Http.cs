using System.Threading.Tasks;

namespace OGS.Messager.Http
{
    public class Messager : IMessager
    {
        public Task<TResult> Delete<TResult>(string url, string jwtToken = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<TResult> Get<TResult>(string url, string jwtToken = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<TResult> Post<TPayload, TResult>(string url, TPayload payload, string jwtToken = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<TResult> Put<TPayload, TResult>(string url, TPayload payload, string jwtToken = null)
        {
            throw new System.NotImplementedException();
        }
    }
}
