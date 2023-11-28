namespace Task2M1StudentRaiting
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Connect = new Button();
            Disconnect = new Button();
            AllInfo = new RadioButton();
            Names = new RadioButton();
            AverageScores = new RadioButton();
            Min = new RadioButton();
            NumericMin = new NumericUpDown();
            SubjectsMin = new RadioButton();
            MinMark = new RadioButton();
            MaxMark = new RadioButton();
            CountMinMath = new RadioButton();
            CountMaxMath = new RadioButton();
            CountStudentsInGroup = new RadioButton();
            AverageMarkOnGroup = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericMin).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(722, 323);
            dataGridView1.TabIndex = 0;
            // 
            // Connect
            // 
            Connect.Location = new Point(12, 12);
            Connect.Name = "Connect";
            Connect.Size = new Size(89, 23);
            Connect.TabIndex = 1;
            Connect.Text = "Під’єднатися";
            Connect.UseVisualStyleBackColor = true;
            Connect.Click += Connect_Click;
            // 
            // Disconnect
            // 
            Disconnect.Location = new Point(107, 12);
            Disconnect.Name = "Disconnect";
            Disconnect.Size = new Size(90, 23);
            Disconnect.TabIndex = 2;
            Disconnect.Text = "Від’єднатися";
            Disconnect.UseVisualStyleBackColor = true;
            Disconnect.Click += Disconnect_Click;
            // 
            // AllInfo
            // 
            AllInfo.AutoSize = true;
            AllInfo.Checked = true;
            AllInfo.Location = new Point(15, 47);
            AllInfo.Name = "AllInfo";
            AllInfo.Size = new Size(71, 19);
            AllInfo.TabIndex = 3;
            AllInfo.TabStop = true;
            AllInfo.Text = "Вся база";
            AllInfo.UseVisualStyleBackColor = true;
            AllInfo.CheckedChanged += AllInfo_CheckedChanged;
            // 
            // Names
            // 
            Names.AutoSize = true;
            Names.Location = new Point(15, 72);
            Names.Name = "Names";
            Names.Size = new Size(121, 19);
            Names.TabIndex = 4;
            Names.TabStop = true;
            Names.Text = "ПІБ усіх студентів";
            Names.UseVisualStyleBackColor = true;
            Names.CheckedChanged += Names_CheckedChanged;
            // 
            // AverageScores
            // 
            AverageScores.AutoSize = true;
            AverageScores.Location = new Point(15, 97);
            AverageScores.Name = "AverageScores";
            AverageScores.Size = new Size(132, 19);
            AverageScores.TabIndex = 5;
            AverageScores.TabStop = true;
            AverageScores.Text = "Середні оцінки всіх";
            AverageScores.UseVisualStyleBackColor = true;
            AverageScores.CheckedChanged += AverageScores_CheckedChanged;
            // 
            // Min
            // 
            Min.AutoSize = true;
            Min.Location = new Point(15, 122);
            Min.Name = "Min";
            Min.Size = new Size(194, 19);
            Min.TabIndex = 6;
            Min.TabStop = true;
            Min.Text = "Мінімальна оцінка більша ніж";
            Min.UseVisualStyleBackColor = true;
            Min.CheckedChanged += Min_CheckedChanged;
            // 
            // NumericMin
            // 
            NumericMin.Location = new Point(215, 118);
            NumericMin.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            NumericMin.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericMin.Name = "NumericMin";
            NumericMin.Size = new Size(33, 23);
            NumericMin.TabIndex = 7;
            NumericMin.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumericMin.ValueChanged += Min_CheckedChanged;
            // 
            // SubjectsMin
            // 
            SubjectsMin.AutoSize = true;
            SubjectsMin.Location = new Point(15, 147);
            SubjectsMin.Name = "SubjectsMin";
            SubjectsMin.Size = new Size(127, 19);
            SubjectsMin.TabIndex = 8;
            SubjectsMin.TabStop = true;
            SubjectsMin.Text = "Всі пердмети (мін)";
            SubjectsMin.UseVisualStyleBackColor = true;
            SubjectsMin.CheckedChanged += SubjectsMin_CheckedChanged;
            // 
            // MinMark
            // 
            MinMark.AutoSize = true;
            MinMark.Location = new Point(343, 47);
            MinMark.Name = "MinMark";
            MinMark.Size = new Size(176, 19);
            MinMark.TabIndex = 9;
            MinMark.TabStop = true;
            MinMark.Text = "Мінімальна середня оцінка";
            MinMark.UseVisualStyleBackColor = true;
            MinMark.CheckedChanged += MinMark_CheckedChanged;
            // 
            // MaxMark
            // 
            MaxMark.AutoSize = true;
            MaxMark.Location = new Point(343, 72);
            MaxMark.Name = "MaxMark";
            MaxMark.Size = new Size(188, 19);
            MaxMark.TabIndex = 10;
            MaxMark.TabStop = true;
            MaxMark.Text = "Максимальна середня оцінка";
            MaxMark.UseVisualStyleBackColor = true;
            MaxMark.CheckedChanged += MaxMark_CheckedChanged;
            // 
            // CountMinMath
            // 
            CountMinMath.AutoSize = true;
            CountMinMath.Location = new Point(343, 97);
            CountMinMath.Name = "CountMinMath";
            CountMinMath.Size = new Size(279, 19);
            CountMinMath.TabIndex = 11;
            CountMinMath.TabStop = true;
            CountMinMath.Text = "Кількість студентів з мінімальною середньою ";
            CountMinMath.UseVisualStyleBackColor = true;
            CountMinMath.CheckedChanged += CountMinMath_CheckedChanged;
            // 
            // CountMaxMath
            // 
            CountMaxMath.AutoSize = true;
            CountMaxMath.Location = new Point(343, 118);
            CountMaxMath.Name = "CountMaxMath";
            CountMaxMath.Size = new Size(291, 19);
            CountMaxMath.TabIndex = 12;
            CountMaxMath.TabStop = true;
            CountMaxMath.Text = "Кількість студентів з максимальною середньою ";
            CountMaxMath.UseVisualStyleBackColor = true;
            CountMaxMath.CheckedChanged += CountMaxMath_CheckedChanged;
            // 
            // CountStudentsInGroup
            // 
            CountStudentsInGroup.AutoSize = true;
            CountStudentsInGroup.Location = new Point(343, 143);
            CountStudentsInGroup.Name = "CountStudentsInGroup";
            CountStudentsInGroup.Size = new Size(167, 19);
            CountStudentsInGroup.TabIndex = 13;
            CountStudentsInGroup.TabStop = true;
            CountStudentsInGroup.Text = "Кількість студентів у групі";
            CountStudentsInGroup.UseVisualStyleBackColor = true;
            CountStudentsInGroup.CheckedChanged += CountStudentsInGroup_CheckedChanged;
            // 
            // AverageMarkOnGroup
            // 
            AverageMarkOnGroup.AutoSize = true;
            AverageMarkOnGroup.Location = new Point(343, 164);
            AverageMarkOnGroup.Name = "AverageMarkOnGroup";
            AverageMarkOnGroup.Size = new Size(148, 19);
            AverageMarkOnGroup.TabIndex = 14;
            AverageMarkOnGroup.TabStop = true;
            AverageMarkOnGroup.Text = " Середня оцінка групи";
            AverageMarkOnGroup.UseVisualStyleBackColor = true;
            AverageMarkOnGroup.CheckedChanged += AverageMarkOnGroup_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 549);
            Controls.Add(AverageMarkOnGroup);
            Controls.Add(CountStudentsInGroup);
            Controls.Add(CountMaxMath);
            Controls.Add(CountMinMath);
            Controls.Add(MaxMark);
            Controls.Add(MinMark);
            Controls.Add(SubjectsMin);
            Controls.Add(NumericMin);
            Controls.Add(Min);
            Controls.Add(AverageScores);
            Controls.Add(Names);
            Controls.Add(AllInfo);
            Controls.Add(Disconnect);
            Controls.Add(Connect);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Студенти";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericMin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Connect;
        private Button Disconnect;
        private RadioButton AllInfo;
        private RadioButton Names;
        private RadioButton AverageScores;
        private RadioButton Min;
        private NumericUpDown NumericMin;
        private RadioButton SubjectsMin;
        private RadioButton MinMark;
        private RadioButton MaxMark;
        private RadioButton CountMinMath;
        private RadioButton CountMaxMath;
        private RadioButton CountStudentsInGroup;
        private RadioButton AverageMarkOnGroup;
    }
}
