using System.Threading.Tasks;

namespace TMLS.APIFramework.Contracts
{
    public interface IAuthServerConnect
    {
        Task<string> RequestClientCredentialsTokenAsync();
    }
}
