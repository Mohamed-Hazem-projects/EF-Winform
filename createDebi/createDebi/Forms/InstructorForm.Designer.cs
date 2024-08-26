namespace createDebi
{
    partial class InstructorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InstructorTable = new DataGridView();
            InsertDefault = new Button();
            LoadData = new Button();
            ClearData = new Button();
            Salarytxt = new TextBox();
            InsertIntoTable = new Button();
            FilterByID = new Button();
            IDfilter = new TextBox();
            Namefilter = new Button();
            Nametext = new TextBox();
            FirstInstructor = new Button();
            LastInstructor = new Button();
            DistinctInstructor = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            Degreelabel = new Label();
            label1 = new Label();
            Nametxt = new TextBox();
            Degreetxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)InstructorTable).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // InstructorTable
            // 
            InstructorTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InstructorTable.Location = new Point(569, 29);
            InstructorTable.Name = "InstructorTable";
            InstructorTable.RowHeadersWidth = 51;
            InstructorTable.Size = new Size(544, 562);
            InstructorTable.TabIndex = 0;
            // 
            // InsertDefault
            // 
            InsertDefault.Location = new Point(62, 74);
            InsertDefault.Name = "InsertDefault";
            InsertDefault.Size = new Size(483, 37);
            InsertDefault.TabIndex = 1;
            InsertDefault.Text = "Insert Default Data (Click Only Once)";
            InsertDefault.UseVisualStyleBackColor = true;
            InsertDefault.Click += InsertDefault_Click;
            // 
            // LoadData
            // 
            LoadData.Location = new Point(62, 29);
            LoadData.Name = "LoadData";
            LoadData.Size = new Size(483, 39);
            LoadData.TabIndex = 2;
            LoadData.Text = "Load Data";
            LoadData.UseVisualStyleBackColor = true;
            LoadData.Click += LoadData_Click;
            // 
            // ClearData
            // 
            ClearData.Location = new Point(62, 117);
            ClearData.Name = "ClearData";
            ClearData.Size = new Size(483, 39);
            ClearData.TabIndex = 3;
            ClearData.Text = "Clear Data";
            ClearData.UseVisualStyleBackColor = true;
            ClearData.Click += ClearData_Click;
            // 
            // Salarytxt
            // 
            Salarytxt.Location = new Point(127, 128);
            Salarytxt.Name = "Salarytxt";
            Salarytxt.Size = new Size(302, 32);
            Salarytxt.TabIndex = 4;
            // 
            // InsertIntoTable
            // 
            InsertIntoTable.Location = new Point(39, 11);
            InsertIntoTable.Name = "InsertIntoTable";
            InsertIntoTable.Size = new Size(390, 44);
            InsertIntoTable.TabIndex = 5;
            InsertIntoTable.Text = "Insert Into Table";
            InsertIntoTable.UseVisualStyleBackColor = true;
            InsertIntoTable.Click += InsertIntoTable_Click;
            // 
            // FilterByID
            // 
            FilterByID.Location = new Point(62, 339);
            FilterByID.Name = "FilterByID";
            FilterByID.Size = new Size(240, 39);
            FilterByID.TabIndex = 6;
            FilterByID.Text = "Filter By ID";
            FilterByID.UseVisualStyleBackColor = true;
            FilterByID.Click += FilterByID_Click;
            // 
            // IDfilter
            // 
            IDfilter.Location = new Point(308, 345);
            IDfilter.Name = "IDfilter";
            IDfilter.Size = new Size(237, 27);
            IDfilter.TabIndex = 7;
            // 
            // Namefilter
            // 
            Namefilter.Location = new Point(62, 384);
            Namefilter.Name = "Namefilter";
            Namefilter.Size = new Size(240, 39);
            Namefilter.TabIndex = 8;
            Namefilter.Text = "Filter By Name";
            Namefilter.UseVisualStyleBackColor = true;
            Namefilter.Click += Namefilter_Click;
            // 
            // Nametext
            // 
            Nametext.Location = new Point(308, 390);
            Nametext.Name = "Nametext";
            Nametext.Size = new Size(237, 27);
            Nametext.TabIndex = 9;
            // 
            // FirstInstructor
            // 
            FirstInstructor.Location = new Point(62, 439);
            FirstInstructor.Name = "FirstInstructor";
            FirstInstructor.Size = new Size(483, 39);
            FirstInstructor.TabIndex = 10;
            FirstInstructor.Text = "First Instructor";
            FirstInstructor.UseVisualStyleBackColor = true;
            FirstInstructor.Click += FirstInstructor_Click;
            // 
            // LastInstructor
            // 
            LastInstructor.Location = new Point(62, 496);
            LastInstructor.Name = "LastInstructor";
            LastInstructor.Size = new Size(483, 39);
            LastInstructor.TabIndex = 11;
            LastInstructor.Text = "Last Instructor";
            LastInstructor.UseVisualStyleBackColor = true;
            LastInstructor.Click += LastInstructor_Click;
            // 
            // DistinctInstructor
            // 
            DistinctInstructor.Location = new Point(62, 552);
            DistinctInstructor.Name = "DistinctInstructor";
            DistinctInstructor.Size = new Size(483, 39);
            DistinctInstructor.TabIndex = 12;
            DistinctInstructor.Text = "Distinct Instructor";
            DistinctInstructor.UseVisualStyleBackColor = true;
            DistinctInstructor.Click += DistinctInstructor_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Degreelabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Nametxt);
            groupBox1.Controls.Add(Degreetxt);
            groupBox1.Controls.Add(InsertIntoTable);
            groupBox1.Controls.Add(Salarytxt);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(62, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 171);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(39, 128);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 10;
            label3.Text = "Salary";
            // 
            // Degreelabel
            // 
            Degreelabel.AutoSize = true;
            Degreelabel.Font = new Font("Segoe UI", 11F);
            Degreelabel.Location = new Point(38, 94);
            Degreelabel.Name = "Degreelabel";
            Degreelabel.Size = new Size(73, 25);
            Degreelabel.TabIndex = 9;
            Degreelabel.Text = "Degree";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(38, 58);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(127, 62);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(302, 32);
            Nametxt.TabIndex = 7;
            // 
            // Degreetxt
            // 
            Degreetxt.Location = new Point(127, 95);
            Degreetxt.Name = "Degreetxt";
            Degreetxt.Size = new Size(302, 32);
            Degreetxt.TabIndex = 6;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 636);
            Controls.Add(groupBox1);
            Controls.Add(DistinctInstructor);
            Controls.Add(LastInstructor);
            Controls.Add(FirstInstructor);
            Controls.Add(Nametext);
            Controls.Add(Namefilter);
            Controls.Add(IDfilter);
            Controls.Add(FilterByID);
            Controls.Add(ClearData);
            Controls.Add(LoadData);
            Controls.Add(InsertDefault);
            Controls.Add(InstructorTable);
            Name = "InstructorForm";
            Text = "Instructors";
            ((System.ComponentModel.ISupportInitialize)InstructorTable).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView InstructorTable;
        private Button InsertDefault;
        private Button LoadData;
        private Button ClearData;
        private TextBox Salarytxt;
        private Button InsertIntoTable;
        private Button FilterByID;
        private TextBox IDfilter;
        private Button Namefilter;
        private TextBox Nametext;
        private Button FirstInstructor;
        private Button LastInstructor;
        private Button DistinctInstructor;
        private GroupBox groupBox1;
        private TextBox Nametxt;
        private TextBox Degreetxt;
        private Label label3;
        private Label Degreelabel;
        private Label label1;
    }
}