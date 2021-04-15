namespace KyGunCo.Counterpoint.Sdk
{
    using ServiceStack.Data;

    /// <summary>
    /// Counterpoint ORM Lite wrapper.
    /// </summary>
    public class CounterpointOrmLite
    {
        private readonly IDbConnectionFactory connectionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="CounterpointOrmLite"/> class.
        /// </summary>
        /// <param name="connectionFactory">Instance of IDbConnectionFactory used to create database connections.</param>
        public CounterpointOrmLite(IDbConnectionFactory connectionFactory) => this.connectionFactory = connectionFactory;

        /// <summary>
        /// Gets instance of IDbConnectionFactory used to create database connections.
        /// </summary>
        /// <returns>Instance of IDbConnectionFactory.</returns>
        public IDbConnectionFactory GetConnectionFactory() => this.connectionFactory;
    }
}
