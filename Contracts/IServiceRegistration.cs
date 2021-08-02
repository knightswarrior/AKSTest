using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TMLS.APIFramework.Contracts
{
    public interface IServiceRegistration
    {
        void RegisterAppServices(IServiceCollection services, IConfiguration configuration);
    }
}
