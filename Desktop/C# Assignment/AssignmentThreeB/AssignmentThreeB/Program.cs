﻿using System;

// Base class representing a database connection
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

// Derived class for SQL Server connection
public class SqlConnection : DbConnection
{
    public SqlConnection(string connectionString) : base(connectionString) { }

    public override void Open()
    {
        Console.WriteLine("Opening SQL Server connection...");
    }

    public override void Close()
    {
        Console.WriteLine("Closing SQL Server connection...");
    }
}

// Derived class for Oracle connection
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

// DbCommand class for executing commands on the database
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

// Example usage
class Program
{
    static void Main()
    {
        var sqlConnection = new SqlConnection("Server=myServer;Database=myDB;");
        var sqlCommand = new DbCommand(sqlConnection, "SELECT * FROM Users");
        sqlCommand.Execute();

        Console.WriteLine();

        var oracleConnection = new OracleConnection("Server=myOracleServer;Database=myOracleDB;");
        var oracleCommand = new DbCommand(oracleConnection, "SELECT * FROM Employees");
        oracleCommand.Execute();
    }
}
