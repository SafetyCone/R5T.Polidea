using System;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.Polidea
{[ServiceDefinitionMarker]
    public interface IGitHubAuthenticationProvider:IServiceDefinition
    {
        Task<GitHubAuthentication> GetGitHubAuthentication();
    }
}
