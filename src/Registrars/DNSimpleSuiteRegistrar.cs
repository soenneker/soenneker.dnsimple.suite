using Microsoft.Extensions.DependencyInjection;
using Soenneker.DNSimple.Contacts.Registrars;
using Soenneker.DNSimple.Delegation.Registrars;
using Soenneker.DNSimple.Domains.Registrars;
using Soenneker.DNSimple.Identity.Registrars;
using Soenneker.DNSimple.Registrar.Registrars;

namespace Soenneker.DNSimple.Suite.Registrars;

/// <summary>
/// A comprehensive suite of utility libraries for DNSimple's API
/// </summary>
public static class DNSimpleSuiteRegistrar
{
    /// <summary>
    /// Adds the DNSimple suite as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddDNSimpleSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddDNSimpleRegistrarUtilAsSingleton()
                .AddDNSimpleDelegationUtilAsSingleton()
                .AddDNSimpleDomainsUtilAsSingleton()
                .AddDNSimpleIdentityUtilAsSingleton()
                .AddDNSimpleContactsUtilAsSingleton();

        return services;
    }

    /// <summary>
    /// Adds  the DNSimple suite as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddDNSimpleSuiteAsScoped(this IServiceCollection services)
    {
        services.AddDNSimpleRegistrarUtilAsScoped()
                .AddDNSimpleDelegationUtilAsScoped()
                .AddDNSimpleDomainsUtilAsScoped()
                .AddDNSimpleIdentityUtilAsScoped()
                .AddDNSimpleContactsUtilAsScoped();

        return services;
    }
}