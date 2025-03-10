// Derived class for Oracle Server connection

namespace AddignmentThree.Connections
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString) { }

        public override void Open()
        {
            Console.WriteLine("Opening Oracle database connection...");
        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle database connection...");
        }
    }
}
