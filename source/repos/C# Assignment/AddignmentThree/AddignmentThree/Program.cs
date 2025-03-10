using AddignmentThree.Connections;
using System;
using System.Text;


namespace AddignmentThree
{
    public class Polymorphism
    {
            public static void Main()
            {
                var sqlConnection = new Connections.SqlConnection("Server=myServer;Database=myDB;");
                var sqlCommand = new DbCommand(sqlConnection, "SELECT * FROM Users");
                sqlCommand.Execute();

                Console.WriteLine();

                var oracleConnection = new OracleConnection("Server=myOracleServer;Database=myOracleDB;");
                var oracleCommand = new DbCommand(oracleConnection, "SELECT * FROM Employees");
                oracleCommand.Execute();
        }
        

    }
}
