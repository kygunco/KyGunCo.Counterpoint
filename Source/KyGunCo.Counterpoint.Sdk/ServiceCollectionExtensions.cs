namespace Microsoft.Extensions.DependencyInjection
{
    using System;
    using KyGunCo.Counterpoint.Sdk;
    using ServiceStack.Data;
    using ServiceStack.OrmLite;

    /// <summary>
    /// Service collection extensions.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add Counterpoint services to service collection.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <param name="connectionString">Database connection string.</param>
        /// <param name="configure">The configuration for <see cref="IDbConnectionFactory"/>.</param>
        /// <returns>The modified service collection.</returns>
        public static IServiceCollection AddCounterpointServices(this IServiceCollection services, string connectionString, Action<OrmLiteConnectionFactory>? configure = null)
        {
            var factory = new OrmLiteConnectionFactory(connectionString, SqlServer2017Dialect.Provider);

            configure?.Invoke(factory);

            return services.AddSingleton(new CounterpointOrmLite(factory));
        }
    }
}
