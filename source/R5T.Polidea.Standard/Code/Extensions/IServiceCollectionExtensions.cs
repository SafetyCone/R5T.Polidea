using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Polidea.Sardinia;

using DefaultIServiceCollectionExtensions = R5T.Polidea.Default.IServiceCollectionExtensions;


namespace R5T.Polidea.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddGitHubAuthenticationProvider(this IServiceCollection services)
        {
            var gitHubAuthenticationProviderAction = services.AddGitHubAuthenticationProviderAction();

            services.Run(gitHubAuthenticationProviderAction);

            return services;
        }

        public static IServiceAction<IGitHubAuthenticationProvider> AddGitHubAuthenticationProviderAction(this IServiceCollection services)
        {
            var gitHubAuthenticationOptionsAction = services.AddGitHubAuthenticationOptionsAction();

            var gitHubAuthenticationProviderAction = DefaultIServiceCollectionExtensions.AddGitHubAuthenticationProviderAction(services, gitHubAuthenticationOptionsAction);
            return gitHubAuthenticationProviderAction;
        }
    }
}
