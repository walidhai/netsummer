using System.Reflection;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ShopWebApp.Tests.IntegrationTests;

[Trait("Category", "Integration")]
public abstract class Integration(IConfiguration? configuration = null)
{
    protected IServiceProvider ServiceProvider { get; } = CreateServices(configuration).BuildServiceProvider();
    private static ServiceCollection CreateServices(IConfiguration? configuration = null)
    {
        var config = configuration ?? new ConfigurationBuilder()
            .AddUserSecrets(Assembly.GetExecutingAssembly())
            .AddEnvironmentVariables()
            .Build();
        
        var services = new ServiceCollection();
        services.AddSingleton(config);
        return services;
    }
    
}