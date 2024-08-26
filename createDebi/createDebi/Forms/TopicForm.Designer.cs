namespace createDebi
{
    partial class TopicForm
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
            TopicTable = new DataGridView();
            InsertDefault = new Button();
            LoadData = new Button();
            ClearData = new Button();
            TopicName = new TextBox();
            InsertIntoTable = new Button();
            FilterByID = new Button();
            IDfilter = new TextBox();
            Namefilter = new Button();
            Nametext = new TextBox();
            FirstTopic = new Button();
            LastTopic = new Button();
            DistinctTopics = new Button();
            ((System.ComponentModel.ISupportInitialize)TopicTable).BeginInit();
            SuspendLayout();
            // 
            // TopicTable
            // 
            TopicTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TopicTable.Location = new Point(635, 29);
            TopicTable.Name = "TopicTable";
            TopicTable.RowHeadersWidth = 51;
            TopicTable.Size = new Size(478, 562);
            TopicTable.TabIndex = 0;
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
            // TopicName
            // 
            TopicName.Location = new Point(308, 180);
            TopicName.Name = "TopicName";
            TopicName.Size = new Size(237, 27);
            TopicName.TabIndex = 4;
            // 
            // InsertIntoTable
            // 
            InsertIntoTable.Location = new Point(62, 174);
            InsertIntoTable.Name = "InsertIntoTable";
            InsertIntoTable.Size = new Size(240, 39);
            InsertIntoTable.TabIndex = 5;
            InsertIntoTable.Text = "Insert By Name";
            InsertIntoTable.UseVisualStyleBackColor = true;
            InsertIntoTable.Click += InsertIntoTable_Click;
            // 
            // FilterByID
            // 
            FilterByID.Location = new Point(62, 232);
            FilterByID.Name = "FilterByID";
            FilterByID.Size = new Size(240, 39);
            FilterByID.TabIndex = 6;
            FilterByID.Text = "Filter By ID";
            FilterByID.UseVisualStyleBackColor = true;
            FilterByID.Click += FilterByID_Click;
            // 
            // IDfilter
            // 
            IDfilter.Location = new Point(308, 238);
            IDfilter.Name = "IDfilter";
            IDfilter.Size = new Size(237, 27);
            IDfilter.TabIndex = 7;
            // 
            // Namefilter
            // 
            Namefilter.Location = new Point(62, 298);
            Namefilter.Name = "Namefilter";
            Namefilter.Size = new Size(240, 39);
            Namefilter.TabIndex = 8;
            Namefilter.Text = "Filter By Name";
            Namefilter.UseVisualStyleBackColor = true;
            Namefilter.Click += Namefilter_Click;
            // 
            // Nametext
            // 
            Nametext.Location = new Point(308, 304);
            Nametext.Name = "Nametext";
            Nametext.Size = new Size(237, 27);
            Nametext.TabIndex = 9;
            // 
            // FirstTopic
            // 
            FirstTopic.Location = new Point(62, 439);
            FirstTopic.Name = "FirstTopic";
            FirstTopic.Size = new Size(483, 39);
            FirstTopic.TabIndex = 10;
            FirstTopic.Text = "First Topic";
            FirstTopic.UseVisualStyleBackColor = true;
            FirstTopic.Click += FirstTopic_Click;
            // 
            // LastTopic
            // 
            LastTopic.Location = new Point(62, 496);
            LastTopic.Name = "LastTopic";
            LastTopic.Size = new Size(483, 39);
            LastTopic.TabIndex = 11;
            LastTopic.Text = "Last Topic";
            LastTopic.UseVisualStyleBackColor = true;
            LastTopic.Click += LastTopic_Click;
            // 
            // DistinctTopics
            // 
            DistinctTopics.Location = new Point(62, 552);
            DistinctTopics.Name = "DistinctTopics";
            DistinctTopics.Size = new Size(483, 39);
            DistinctTopics.TabIndex = 12;
            DistinctTopics.Text = "Distinct Topics";
            DistinctTopics.UseVisualStyleBackColor = true;
            DistinctTopics.Click += DistinctTopics_Click;
            // 
            // TopicForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 636);
            Controls.Add(DistinctTopics);
            Controls.Add(LastTopic);
            Controls.Add(FirstTopic);
            Controls.Add(Nametext);
            Controls.Add(Namefilter);
            Controls.Add(IDfilter);
            Controls.Add(FilterByID);
            Controls.Add(InsertIntoTable);
            Controls.Add(TopicName);
            Controls.Add(ClearData);
            Controls.Add(LoadData);
            Controls.Add(InsertDefault);
            Controls.Add(TopicTable);
            Name = "TopicForm";
            Text = "Topics";
            Load += TopicForm_Load;
            ((System.ComponentModel.ISupportInitialize)TopicTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TopicTable;
        private Button InsertDefault;
        private Button LoadData;
        private Button ClearData;
        private TextBox TopicName;
        private Button InsertIntoTable;
        private Button FilterByID;
        private TextBox IDfilter;
        private Button Namefilter;
        private TextBox Nametext;
        private Button FirstTopic;
        private Button LastTopic;
        private Button DistinctTopics;
    }
}