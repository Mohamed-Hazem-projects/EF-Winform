namespace createDebi
{
    partial class MainForm
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
            TopicTable = new Button();
            Courses = new Button();
            InsCourses = new Button();
            Students = new Button();
            StudCourses = new Button();
            Instructors = new Button();
            Departments = new Button();
            SuspendLayout();
            // 
            // TopicTable
            // 
            TopicTable.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TopicTable.Location = new Point(38, 503);
            TopicTable.Name = "TopicTable";
            TopicTable.Size = new Size(356, 134);
            TopicTable.TabIndex = 0;
            TopicTable.Text = "Topics";
            TopicTable.UseVisualStyleBackColor = true;
            TopicTable.Click += TopicTable_Click;
            // 
            // Courses
            // 
            Courses.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Courses.Location = new Point(786, 503);
            Courses.Name = "Courses";
            Courses.Size = new Size(356, 134);
            Courses.TabIndex = 1;
            Courses.Text = "Courses";
            Courses.UseVisualStyleBackColor = true;
            // 
            // InsCourses
            // 
            InsCourses.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InsCourses.Location = new Point(433, 272);
            InsCourses.Name = "InsCourses";
            InsCourses.Size = new Size(314, 134);
            InsCourses.TabIndex = 2;
            InsCourses.Text = "Ins_Courses";
            InsCourses.UseVisualStyleBackColor = true;
            // 
            // Students
            // 
            Students.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Students.Location = new Point(786, 41);
            Students.Name = "Students";
            Students.Size = new Size(356, 134);
            Students.TabIndex = 3;
            Students.Text = "Students";
            Students.UseVisualStyleBackColor = true;
            // 
            // StudCourses
            // 
            StudCourses.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudCourses.Location = new Point(786, 272);
            StudCourses.Name = "StudCourses";
            StudCourses.Size = new Size(356, 134);
            StudCourses.TabIndex = 4;
            StudCourses.Text = "Stud_Courses";
            StudCourses.UseVisualStyleBackColor = true;
            // 
            // Instructors
            // 
            Instructors.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Instructors.Location = new Point(38, 272);
            Instructors.Name = "Instructors";
            Instructors.Size = new Size(356, 134);
            Instructors.TabIndex = 6;
            Instructors.Text = "Instructors";
            Instructors.UseVisualStyleBackColor = true;
            Instructors.Click += Instructors_Click;
            // 
            // Departments
            // 
            Departments.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Departments.Location = new Point(38, 41);
            Departments.Name = "Departments";
            Departments.Size = new Size(356, 134);
            Departments.TabIndex = 7;
            Departments.Text = "Departments";
            Departments.UseVisualStyleBackColor = true;
            Departments.Click += Departments_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 679);
            Controls.Add(Departments);
            Controls.Add(Instructors);
            Controls.Add(StudCourses);
            Controls.Add(Students);
            Controls.Add(InsCourses);
            Controls.Add(Courses);
            Controls.Add(TopicTable);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button TopicTable;
        private Button Courses;
        private Button InsCourses;
        private Button Students;
        private Button StudCourses;
        private Button Instructors;
        private Button Departments;
    }
}
