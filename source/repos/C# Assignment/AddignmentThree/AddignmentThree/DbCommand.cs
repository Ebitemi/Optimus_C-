using AddignmentThree.Connections;

namespace AddignmentThree
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        public string Instruction { get; }

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            _dbConnection = dbConnection ?? throw new InvalidOperationException("DbConnection cannot be null.");
            Instruction = string.IsNullOrWhiteSpace(instruction) ? throw new InvalidOperationException("Instruction cannot be null or empty.") : instruction;
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine($"Executing command: {Instruction}");
            _dbConnection.Close();
        }
    }
}
