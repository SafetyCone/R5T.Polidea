using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using R5T.Dacia;


namespace R5T.Polidea.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="GitHubAuthenticationProvider"/> implementation of <see cref="IGitHubAuthenticationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddGitHubAuthenticationProvider(this IServiceCollection services,
            IServiceAction<IOptions<GitHubAuthentication>> gitHubAuthenticationOptionsAction)
        {
            services
                .AddSingleton<IGitHubAuthenticationProvider, GitHubAuthenticationProvider>()
                .Run(gitHubAuthenticationOptionsAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="GitHubAuthenticationProvider"/> implementation of <see cref="IGitHubAuthenticationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IGitHubAuthenticationProvider> AddGitHubAuthenticationProviderAction(this IServiceCollection services,
            IServiceAction<IOptions<GitHubAuthentication>> gitHubAuthenticationOptionsAction)
        {
            var serviceAction = ServiceAction.New<IGitHubAuthenticationProvider>(() => services.AddGitHubAuthenticationProvider(
                gitHubAuthenticationOptionsAction));

            return serviceAction;
        }
    }
}
