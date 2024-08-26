namespace createDebi.Forms
{
    partial class DepartmentForm
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
            Grid = new DataGridView();
            groupBox1 = new GroupBox();
            Manager_hiredatetxt = new TextBox();
            Dept_Managertxt = new TextBox();
            Dept_Locationtxt = new TextBox();
            Dept_Desctxt = new TextBox();
            Dept_Nametxt = new TextBox();
            Dept_Location = new Label();
            Dept_Manager = new Label();
            Manager_hiredate = new Label();
            Dept_Desc = new Label();
            Dept_Name = new Label();
            Dept_Id = new Label();
            Dept_Idtxt = new TextBox();
            InsertUpdate = new Button();
            LoadDummyData = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            Delete = new Button();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Grid
            // 
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid.Location = new Point(12, 410);
            Grid.Name = "Grid";
            Grid.RowHeadersWidth = 51;
            Grid.Size = new Size(651, 315);
            Grid.TabIndex = 0;
            Grid.CellClick += Grid_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(Manager_hiredatetxt);
            groupBox1.Controls.Add(Dept_Managertxt);
            groupBox1.Controls.Add(Dept_Locationtxt);
            groupBox1.Controls.Add(Dept_Desctxt);
            groupBox1.Controls.Add(Dept_Nametxt);
            groupBox1.Controls.Add(Dept_Location);
            groupBox1.Controls.Add(Dept_Manager);
            groupBox1.Controls.Add(Manager_hiredate);
            groupBox1.Controls.Add(Dept_Desc);
            groupBox1.Controls.Add(Dept_Name);
            groupBox1.Controls.Add(Dept_Id);
            groupBox1.Controls.Add(Dept_Idtxt);
            groupBox1.Controls.Add(InsertUpdate);
            groupBox1.Controls.Add(LoadDummyData);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(651, 318);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insert/Update";
            // 
            // Manager_hiredatetxt
            // 
            Manager_hiredatetxt.Font = new Font("Segoe UI", 13F);
            Manager_hiredatetxt.Location = new Point(347, 218);
            Manager_hiredatetxt.Name = "Manager_hiredatetxt";
            Manager_hiredatetxt.Size = new Size(298, 36);
            Manager_hiredatetxt.TabIndex = 13;
            // 
            // Dept_Managertxt
            // 
            Dept_Managertxt.Font = new Font("Segoe UI", 13F);
            Dept_Managertxt.Location = new Point(347, 156);
            Dept_Managertxt.Name = "Dept_Managertxt";
            Dept_Managertxt.Size = new Size(298, 36);
            Dept_Managertxt.TabIndex = 12;
            // 
            // Dept_Locationtxt
            // 
            Dept_Locationtxt.Font = new Font("Segoe UI", 13F);
            Dept_Locationtxt.Location = new Point(347, 94);
            Dept_Locationtxt.Name = "Dept_Locationtxt";
            Dept_Locationtxt.Size = new Size(298, 36);
            Dept_Locationtxt.TabIndex = 11;
            // 
            // Dept_Desctxt
            // 
            Dept_Desctxt.Font = new Font("Segoe UI", 13F);
            Dept_Desctxt.Location = new Point(6, 218);
            Dept_Desctxt.Name = "Dept_Desctxt";
            Dept_Desctxt.Size = new Size(282, 36);
            Dept_Desctxt.TabIndex = 10;
            // 
            // Dept_Nametxt
            // 
            Dept_Nametxt.Font = new Font("Segoe UI", 13F);
            Dept_Nametxt.Location = new Point(6, 156);
            Dept_Nametxt.Name = "Dept_Nametxt";
            Dept_Nametxt.Size = new Size(282, 36);
            Dept_Nametxt.TabIndex = 9;
            // 
            // Dept_Location
            // 
            Dept_Location.AutoSize = true;
            Dept_Location.Font = new Font("Segoe UI", 9F);
            Dept_Location.Location = new Point(347, 71);
            Dept_Location.Name = "Dept_Location";
            Dept_Location.Size = new Size(105, 20);
            Dept_Location.TabIndex = 8;
            Dept_Location.Text = "Dept_Location";
            // 
            // Dept_Manager
            // 
            Dept_Manager.AutoSize = true;
            Dept_Manager.Font = new Font("Segoe UI", 9F);
            Dept_Manager.Location = new Point(347, 133);
            Dept_Manager.Name = "Dept_Manager";
            Dept_Manager.Size = new Size(107, 20);
            Dept_Manager.TabIndex = 7;
            Dept_Manager.Text = "Dept_Manager";
            // 
            // Manager_hiredate
            // 
            Manager_hiredate.AutoSize = true;
            Manager_hiredate.Font = new Font("Segoe UI", 9F);
            Manager_hiredate.Location = new Point(347, 195);
            Manager_hiredate.Name = "Manager_hiredate";
            Manager_hiredate.Size = new Size(129, 20);
            Manager_hiredate.TabIndex = 6;
            Manager_hiredate.Text = "Manager_hiredate";
            // 
            // Dept_Desc
            // 
            Dept_Desc.AutoSize = true;
            Dept_Desc.Font = new Font("Segoe UI", 9F);
            Dept_Desc.Location = new Point(6, 195);
            Dept_Desc.Name = "Dept_Desc";
            Dept_Desc.Size = new Size(80, 20);
            Dept_Desc.TabIndex = 5;
            Dept_Desc.Text = "Dept_Desc";
            // 
            // Dept_Name
            // 
            Dept_Name.AutoSize = true;
            Dept_Name.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dept_Name.Location = new Point(6, 133);
            Dept_Name.Name = "Dept_Name";
            Dept_Name.Size = new Size(88, 20);
            Dept_Name.TabIndex = 4;
            Dept_Name.Text = "Dept_Name";
            // 
            // Dept_Id
            // 
            Dept_Id.AutoSize = true;
            Dept_Id.Font = new Font("Segoe UI", 9F);
            Dept_Id.Location = new Point(6, 71);
            Dept_Id.Name = "Dept_Id";
            Dept_Id.Size = new Size(61, 20);
            Dept_Id.TabIndex = 3;
            Dept_Id.Text = "Dept_Id";
            // 
            // Dept_Idtxt
            // 
            Dept_Idtxt.Font = new Font("Segoe UI", 13F);
            Dept_Idtxt.Location = new Point(6, 94);
            Dept_Idtxt.Name = "Dept_Idtxt";
            Dept_Idtxt.ReadOnly = true;
            Dept_Idtxt.Size = new Size(282, 36);
            Dept_Idtxt.TabIndex = 2;
            // 
            // InsertUpdate
            // 
            InsertUpdate.Font = new Font("Segoe UI", 13F);
            InsertUpdate.Location = new Point(6, 260);
            InsertUpdate.Name = "InsertUpdate";
            InsertUpdate.Size = new Size(639, 42);
            InsertUpdate.TabIndex = 1;
            InsertUpdate.Text = "Insert / Update";
            InsertUpdate.UseVisualStyleBackColor = true;
            InsertUpdate.Click += InsertUpdate_Click;
            // 
            // LoadDummyData
            // 
            LoadDummyData.Font = new Font("Segoe UI", 13F);
            LoadDummyData.Location = new Point(6, 26);
            LoadDummyData.Name = "LoadDummyData";
            LoadDummyData.Size = new Size(639, 42);
            LoadDummyData.TabIndex = 0;
            LoadDummyData.Text = "Load Dummy Data";
            LoadDummyData.UseVisualStyleBackColor = true;
            LoadDummyData.Click += LoadDummyData_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightCoral;
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(Delete);
            groupBox2.Location = new Point(12, 341);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(651, 58);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Delete";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 20);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 4;
            label1.Text = "Dept_Id";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(92, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 36);
            textBox1.TabIndex = 3;
            // 
            // Delete
            // 
            Delete.Location = new Point(177, 16);
            Delete.Name = "Delete";
            Delete.Size = new Size(468, 36);
            Delete.TabIndex = 0;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 737);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Grid);
            Name = "DepartmentForm";
            Text = "DepartmentForm";
            FormClosing += DepartmentForm_FormClosing;
            Load += DepartmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Grid;
        private GroupBox groupBox1;
        private TextBox Dept_Idtxt;
        private Button InsertUpdate;
        private Button LoadDummyData;
        private GroupBox groupBox2;
        private Button Delete;
        private Label Dept_Id;
        private TextBox Manager_hiredatetxt;
        private TextBox Dept_Managertxt;
        private TextBox Dept_Locationtxt;
        private TextBox Dept_Desctxt;
        private TextBox Dept_Nametxt;
        private Label Dept_Location;
        private Label Dept_Manager;
        private Label Manager_hiredate;
        private Label Dept_Desc;
        private Label Dept_Name;
        private Label label1;
        private TextBox textBox1;
    }
}