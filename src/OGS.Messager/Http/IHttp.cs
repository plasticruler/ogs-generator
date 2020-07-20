using System.Threading.Tasks;

namespace OGS.Messager.Http
{
 public interface IMessager
    {
        Task<TResult> Post<TPayload, TResult>(string url, TPayload payload, string jwtToken = null);
        Task<TResult> Put<TPayload, TResult>(string url, TPayload payload, string jwtToken = null);
        Task<TResult> Get<TResult>(string url, string jwtToken = null);
        Task<TResult> Delete<TResult>(string url, string jwtToken=null);
    }
}
