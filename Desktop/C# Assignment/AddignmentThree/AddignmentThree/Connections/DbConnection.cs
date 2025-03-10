//Base class representing a database connection

namespace AddignmentThree.Connections
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; }
        public TimeSpan Timeout { get; set; }

        protected DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("Connection string cannot be null or empty.");

            ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }

}
