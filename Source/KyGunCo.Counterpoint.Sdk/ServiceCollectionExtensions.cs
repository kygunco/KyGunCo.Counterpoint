namespace Microsoft.Extensions.DependencyInjection
{
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
        /// <returns>The modified service collection.</returns>
        public static IServiceCollection AddCounterpointServices(this IServiceCollection services, string connectionString)
        {
            var factory = new OrmLiteConnectionFactory(connectionString, SqlServer2017Dialect.Provider);

            _ = services.AddSingleton<IDbConnectionFactory>(factory);

            return services;
        }

        /// <summary>
        /// Add Counterpoint services to service collection.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <param name="connectionString">Database connection string.</param>
        /// <param name="dialectProvider">Dialect provider for the Counterpoint instance.</param>
        /// <returns>The modified service collection.</returns>
        public static IServiceCollection AddCounterpointServices(this IServiceCollection services, string connectionString, IOrmLiteDialectProvider? dialectProvider = null)
        {
            var factory = new OrmLiteConnectionFactory(connectionString, dialectProvider ?? SqlServer2017Dialect.Provider);

            _ = services.AddSingleton<IDbConnectionFactory>(factory);

            return services;
        }

        /// <summary>
        /// Add Counterpoint services to service collection.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <returns>The modified service collection.</returns>
        public static IServiceCollection AddCounterpointServices(this IServiceCollection services) =>
            services.AddSingleton<IDbConnectionFactory>(new OrmLiteConnectionFactory());
    }
}
