using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Options;using R5T.T0064;


namespace R5T.Polidea.Default
{[ServiceImplementationMarker]
    public class GitHubAuthenticationProvider : IGitHubAuthenticationProvider,IServiceImplementation
    {
        private IOptions<GitHubAuthentication> GitHubAuthenticationOptions { get; }


        public GitHubAuthenticationProvider(
            IOptions<GitHubAuthentication> gitHubAuthenticationOptions)
        {
            this.GitHubAuthenticationOptions = gitHubAuthenticationOptions;
        }

        public Task<GitHubAuthentication> GetGitHubAuthentication()
        {
            var gitHubAuthentication = this.GitHubAuthenticationOptions.Value;

            return Task.FromResult(gitHubAuthentication);
        }
    }
}
