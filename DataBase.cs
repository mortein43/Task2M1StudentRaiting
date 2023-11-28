// <copyright file="DataBase.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace Task2M1StudentRaiting;
using System.Data;
using Microsoft.Data.Sqlite;

internal class DataBase
{
    private readonly string connectionString = "Data Source= StudentRaiting.sqlite;";
    private bool access = false;

    public async Task CreateDataBase()
    {
        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();
        SqliteCommand command = new ()
        {
            CommandText = "CREATE DATABASE StudentRaiting",
            Connection = connection,
        };
        await command.ExecuteNonQueryAsync();
    }

    public async Task CreateTable()
    {
        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();

        SqliteCommand createTableCommand = new ()
        {
            CommandText = "CREATE TABLE AllStudentRaiting (Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE, LastName NVARCHAR(255)," +
                "FirstName NVARCHAR(255), SecondaryName NVARCHAR(255), GroupName NVARCHAR(255), " +
                "AverageScore int, NameSubjectAvgMin NVARCHAR(255), NameSubjectAvgMax NVARCHAR(255), UNIQUE (\"LastName\") ON CONFLICT ABORT)",
            Connection = connection,
        };
        await createTableCommand.ExecuteNonQueryAsync();
    }

    public async Task TableFilling()
    {
        string sqliteExpression = "INSERT INTO AllStudentRaiting (LastName, FirstName, SecondaryName, GroupName, " +
            "AverageScore, NameSubjectAvgMin, NameSubjectAvgMax) " +
            "VALUES " +
            "('Юзеренко1', 'Юзер1', 'Адмінович1', 'ПП255', 8, 'Математика', 'Біологія'), " +
            "('Юзеренко2', 'Юзер2', 'Адмінович2', 'ПП255', 9, 'Інформатика', 'Зарубіжна література'), " +
            "('Юзеренко3', 'Юзер3', 'Адмінович3', 'ПП255', 7, 'Біологія', 'Математика'), " +
            "('Юзеренко4', 'Юзер4', 'Адмінович4', 'ПП255', 11, 'Англійська мова', 'Всесвітня історія'), " +
            "('Юзеренко5', 'Юзер5', 'Адмінович5', 'ПП255', 12, 'Астрономія', 'Мистецтво'), " +
            "('Юзеренко6', 'Юзер6', 'Адмінович6', 'ПП256', 4, 'Математика', 'Біологія'), " +
            "('Юзеренко7', 'Юзер7', 'Адмінович7', 'ПП256', 3, 'Історія України', 'Зарубіжна література'), " +
            "('Юзеренко8', 'Юзер8', 'Адмінович8', 'ПП256', 10, 'Біологія', 'Математика'), " +
            "('Юзеренко9', 'Юзер9', 'Адмінович9', 'ПП256', 11, 'Англійська мова', 'Всесвітня історія'), " +
            "('Юзеренко10', 'Юзер10', 'Адмінович10', 'ПП256', 8, 'Астрономія', 'Українська мова')";

        using SqliteConnection connection = new (this.connectionString);
        await connection.OpenAsync();
        SqliteCommand command = new (sqliteExpression, connection);
        await command.ExecuteNonQueryAsync();
    }

    public async Task PrintDataBase(DataGridView field)
    {
        if (this.access)
        {
            field.DataSource = string.Empty;
            using SqliteConnection connection = new (this.connectionString);
            await connection.OpenAsync();

            SqliteCommand command = new ("SELECT Id AS №, LastName AS Прізвище, FirstName AS Ім’я, " +
                "SecondaryName AS 'По батькові', " +
                "GroupName AS Група, AverageScore AS 'Середня оцінка', " +
                "NameSubjectAvgMin AS Мін, NameSubjectAvgMax AS Макс  " +
                "FROM AllStudentRaiting", connection);

            using SqliteDataReader reader = await command.ExecuteReaderAsync();
            DataTable dataTable = new ();
            dataTable.Load(reader);

            field.DataSource = dataTable;
        }
    }

    public bool ToConnect()
    {
        using SqliteConnection connection = new (this.connectionString);

        try
        {
            connection.Open();
            MessageBox.Show("Успішне підключення!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.access = true;
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Підключення невдалося. Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.access = false;
            return false;
        }
    }

    public void Disconnect(DataGridView field)
    {
        field.DataSource = null;
        MessageBox.Show("Від’єдналися!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.access = false;
    }

    public async Task PrintNames(DataGridView field)
    {
        if (this.access)
        {
            field.DataSource = string.Empty;
            using SqliteConnection connection = new (this.connectionString);
            await connection.OpenAsync();

            SqliteCommand command = new ("SELECT Id AS №, LastName AS Прізвище, FirstName AS Ім’я, " +
                "SecondaryName AS 'По батькові' FROM AllStudentRaiting", connection);

            using SqliteDataReader reader = await command.ExecuteReaderAsync();
            DataTable dataTable = new ();
            dataTable.Load(reader);

            field.DataSource = dataTable;
        }
    }

    public async Task PrintAverageScores(DataGridView field)
    {
        if (this.access)
        {
            field.DataSource = string.Empty;
            using SqliteConnection connection = new (this.connectionString);
            await connection.OpenAsync();

            SqliteCommand command = new ("SELECT Id AS №, LastName AS Прізвище, FirstName AS Ім’я, " +
                "SecondaryName AS 'По батькові', AverageScore AS 'Середня оцінка' FROM AllStudentRaiting", connection);

            using SqliteDataReader reader = await command.ExecuteReaderAsync();
            DataTable dataTable = new ();
            dataTable.Load(reader);

            field.DataSource = dataTable;
        }
    }

    public async Task PrintNamesWithMinScore(DataGridView field, string numeric, RadioButton number)
    {
        if (this.access && number.Checked)
        {
            field.DataSource = string.Empty;
            using SqliteConnection connection = new (this.connectionString);
            await connection.OpenAsync();

            SqliteCommand command = new ("SELECT Id AS №, LastName AS Прізвище, FirstName AS Ім’я, " +
                "SecondaryName AS 'По батькові', AverageScore AS 'Середня оцінка' FROM AllStudentRaiting " +
                "WHERE AverageScore > @NumericValue", connection);
            command.Parameters.AddWithValue("@NumericValue", int.Parse(numeric));
            using SqliteDataReader reader = await command.ExecuteReaderAsync();
            DataTable dataTable = new ();
            dataTable.Load(reader);

            field.DataSource = dataTable;
        }
    }

    public async Task PrintSubjectsWithMinAverage(DataGridView field)
    {
        if (this.access)
        {
            field.DataSource = string.Empty;
            using SqliteConnection connection = new (this.connectionString);
            await connection.OpenAsync();

            SqliteCommand command = new ("SELECT Id AS №, LastName AS Прізвище, FirstName AS Ім’я, " +
                "SecondaryName AS 'По батькові', NameSubjectAvgMin AS Мін FROM AllStudentRaiting", connection);
            using SqliteDataReader reader = await command.ExecuteReaderAsync();
            DataTable dataTable = new ();
            dataTable.Load(reader);

            field.DataSource = dataTable;
        }
    }

    public async Task PrintStudentWithMinAverage(DataGridView field)
    {
        if (this.access)
        {
            field.DataSource = string.Empty;
            using SqliteConnection connection = new (this.connectionString);
            await connection.OpenAsync();

            SqliteCommand command = new ("SELECT Id AS №, LastName AS Прізвище, FirstName AS Ім’я, " +
                "SecondaryName AS 'По батькові', MIN(AverageScore) AS 'Середня оцінка' FROM AllStudentRaiting", connection);
            using SqliteDataReader reader = await command.ExecuteReaderAsync();
            DataTable dataTable = new ();
            dataTable.Load(reader);

            field.DataSource = dataTable;
        }
    }

    public async Task PrintStudentWithMaxAverage(DataGridView field)
    {
        if (this.access)
        {
            field.DataSource = string.Empty;
            using SqliteConnection connection = new (this.connectionString);
            await connection.OpenAsync();

            SqliteCommand command = new ("SELECT Id AS №, LastName AS Прізвище, FirstName AS Ім’я, " +
                "SecondaryName AS 'По батькові', MAX(AverageScore) AS 'Середня оцінка' FROM AllStudentRaiting", connection);
            using SqliteDataReader reader = await command.ExecuteReaderAsync();
            DataTable dataTable = new ();
            dataTable.Load(reader);

            field.DataSource = dataTable;
        }
    }

    public async Task PrintCountStudentWithMinAverage(DataGridView field)
    {
        if (this.access)
        {
            field.DataSource = string.Empty;
            using SqliteConnection connection = new (this.connectionString);
            await connection.OpenAsync();

            SqliteCommand command = new ("SELECT NameSubjectAvgMin AS 'Предмет з мінімальною середньою оцінкою', COUNT(*) AS 'Клькість студентів' FROM AllStudentRaiting WHERE NameSubjectAvgMin = 'Математика'", connection);
            using SqliteDataReader reader = await command.ExecuteReaderAsync();
            DataTable dataTable = new ();
            dataTable.Load(reader);

            field.DataSource = dataTable;
        }
    }

    public async Task PrintCountStudentWithMaxAverage(DataGridView field)
    {
        if (this.access)
        {
            field.DataSource = string.Empty;
            using SqliteConnection connection = new (this.connectionString);
            await connection.OpenAsync();

            SqliteCommand command = new ("SELECT NameSubjectAvgMax AS 'Предмет з максимальною середньою оцінкою', COUNT(*) AS 'Клькість студентів' FROM AllStudentRaiting WHERE NameSubjectAvgMax = 'Математика'", connection);
            using SqliteDataReader reader = await command.ExecuteReaderAsync();
            DataTable dataTable = new ();
            dataTable.Load(reader);

            field.DataSource = dataTable;
        }
    }

    public async Task PrintCountStudentsOnGroup(DataGridView field)
    {
        if (this.access)
        {
            field.DataSource = string.Empty;
            using SqliteConnection connection = new (this.connectionString);
            await connection.OpenAsync();

            SqliteCommand command = new ("SELECT GroupName AS 'Група', COUNT(*) AS 'Клькість студентів' FROM AllStudentRaiting GROUP BY GroupName", connection);
            using SqliteDataReader reader = await command.ExecuteReaderAsync();
            DataTable dataTable = new ();
            dataTable.Load(reader);

            field.DataSource = dataTable;
        }
    }

    public async Task PrintAverageOnGroup(DataGridView field)
    {
        if (this.access)
        {
            field.DataSource = string.Empty;
            using SqliteConnection connection = new (this.connectionString);
            await connection.OpenAsync();

            SqliteCommand command = new ("SELECT GroupName AS 'Група',AVG(AverageScore) AS 'Середній бал' FROM AllStudentRaiting GROUP BY GroupName", connection);
            using SqliteDataReader reader = await command.ExecuteReaderAsync();
            DataTable dataTable = new ();
            dataTable.Load(reader);

            field.DataSource = dataTable;
        }
    }
}
