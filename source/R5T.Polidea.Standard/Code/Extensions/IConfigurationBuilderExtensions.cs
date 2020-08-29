using System;

using Microsoft.Extensions.Configuration;

using ImplementationConfigurationBuilderExtensions = R5T.Polidea.Suebia.IConfigurationBuilderExtensions;


namespace R5T.Polidea.Standard
{
    public static class IConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddGitHubAuthenticationConfiguration(this IConfigurationBuilder configurationBuilder, IServiceProvider configurationServiceProvider)
        {
            ImplementationConfigurationBuilderExtensions.AddGitHubAuthenticationConfiguration(configurationBuilder, configurationServiceProvider);

            return configurationBuilder;
        }
    }
}
