// <copyright file="Form1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace Task2M1StudentRaiting;
using Microsoft.Data.Sqlite;
using System.Data;

public partial class Form1 : Form
{
    private readonly DataBase dataBase = new ();

    /// <summary>
    /// Initializes a new instance of the <see cref="Form1"/> class.
    /// </summary>
    public Form1()
    {
        this.InitializeComponent();

        _ = this.dataBase.CreateDataBase();
        _ = this.dataBase.CreateTable();
        _ = this.dataBase.TableFilling();
    }

    private void Connect_Click(object sender, EventArgs e)
    {
        if (this.dataBase.ToConnect())
        {
            _ = this.dataBase.PrintDataBase(this.dataGridView1);
        }

        this.AllInfo.Checked = true;
    }

    private void Disconnect_Click(object sender, EventArgs e)
    {
        this.dataBase.Disconnect(this.dataGridView1);
    }

    private void AllInfo_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintDataBase(this.dataGridView1);
    }

    private void Names_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintNames(this.dataGridView1);
    }

    private void AverageScores_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintAverageScores(this.dataGridView1);
    }

    private void Min_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintNamesWithMinScore(this.dataGridView1, this.NumericMin.Text, this.Min);
    }

    private void SubjectsMin_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintSubjectsWithMinAverage(this.dataGridView1);
    }

    private void MinMark_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintStudentWithMinAverage(this.dataGridView1);
    }

    private void MaxMark_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintStudentWithMaxAverage(this.dataGridView1);
    }

    private void CountMinMath_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintCountStudentWithMinAverage(this.dataGridView1);
    }

    private void CountMaxMath_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintCountStudentWithMaxAverage(this.dataGridView1);
    }

    private void CountStudentsInGroup_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintCountStudentsOnGroup(this.dataGridView1);
    }

    private void AverageMarkOnGroup_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.dataBase.PrintAverageOnGroup(this.dataGridView1);
    }
}
