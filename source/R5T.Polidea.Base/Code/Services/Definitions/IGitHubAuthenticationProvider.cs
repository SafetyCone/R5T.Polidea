using System;
using System.Threading.Tasks;


namespace R5T.Polidea
{
    public interface IGitHubAuthenticationProvider
    {
        Task<GitHubAuthentication> GetGitHubAuthentication();
    }
}
