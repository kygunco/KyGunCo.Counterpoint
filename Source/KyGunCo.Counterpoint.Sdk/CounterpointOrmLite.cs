namespace KyGunCo.Counterpoint.Sdk
{
    using ServiceStack.OrmLite;

    /// <summary>
    /// Counterpoint ORM Lite wrapper.
    /// </summary>
    public class CounterpointOrmLite
    {
        private readonly OrmLiteConnectionFactory connectionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="CounterpointOrmLite"/> class.
        /// </summary>
        /// <param name="connectionFactory">Instance of IDbConnectionFactory used to create database connections.</param>
        public CounterpointOrmLite(OrmLiteConnectionFactory connectionFactory) => this.connectionFactory = connectionFactory;

        /// <summary>
        /// Gets instance of OrmLiteConnectionFactory used to create database connections.
        /// </summary>
        /// <returns>Instance of IDbConnectionFactory.</returns>
        public OrmLiteConnectionFactory GetConnectionFactory() => this.connectionFactory;
    }
}
