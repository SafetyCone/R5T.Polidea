using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Options;


namespace R5T.Polidea.Default
{
    public class GitHubAuthenticationProvider : IGitHubAuthenticationProvider
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
