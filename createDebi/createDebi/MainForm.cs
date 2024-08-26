using createDebi.Forms;

namespace createDebi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void TopicTable_Click(object sender, EventArgs e)
        {
            TopicForm TopicForm = new TopicForm();
            TopicForm.Show();
        }

        private void Instructors_Click(object sender, EventArgs e)
        {
            InstructorForm InstructorForm = new InstructorForm();
            InstructorForm.Show();
        }

        private void Departments_Click(object sender, EventArgs e)
        {
            DepartmentForm departmentForm = new DepartmentForm();
            departmentForm.Show();
        }
    }
}
