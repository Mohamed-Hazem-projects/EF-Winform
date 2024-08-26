
using createDebi.Entities;

namespace createDebi.Forms
{
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();

        }
        DepiContext depiHazem = new DepiContext();
        List<Department> departments = new List<Department>();
        Department selectedDept = new Department();
        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            departments = depiHazem.Departments.ToList();
            Grid.DataSource = departments;
        }

        private void DepartmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            depiHazem?.Dispose();
        }

        private void LoadDummyData_Click(object sender, EventArgs e)
        {
            depiHazem.Departments.AddRange(DatabaseManager.Data.getDepartmentData());
            depiHazem.SaveChanges();
            Grid.DataSource = depiHazem.Departments.ToList();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            selectedDept = departments[index];
            Dept_Idtxt.Text = selectedDept.Dept_Id.ToString();
            Dept_Desctxt.Text = selectedDept.Dept_Desc;
            Dept_Locationtxt.Text = selectedDept.Dept_Location;
            Dept_Nametxt.Text = selectedDept.Dept_Name;
            Dept_Managertxt.Text = selectedDept.Dept_Manager.ToString();
            Manager_hiredatetxt.Text = selectedDept.Dept_Manager.ToString();
        }

        private void InsertUpdate_Click(object sender, EventArgs e)
        {
            if (Dept_Idtxt.Text == "")
            {
                selectedDept.Dept_Desc = Dept_Desctxt.Text;
                selectedDept.Dept_Location = Dept_Locationtxt.Text;
                selectedDept.Dept_Name = Dept_Nametxt.Text;
                depiHazem.Departments.Add(selectedDept);
                selectedDept = new Department();
            }
            else
            {
                selectedDept = depiHazem.Departments.Find(int.Parse(Dept_Idtxt.Text));
                if (selectedDept != null)
                {
                    selectedDept.Dept_Desc = Dept_Desctxt.Text;
                    selectedDept.Dept_Location = Dept_Locationtxt.Text;
                    selectedDept.Dept_Name = Dept_Nametxt.Text;
                    depiHazem.Departments.Update(selectedDept);
                    selectedDept = new Department();
                }
            }
            depiHazem.SaveChanges();
            departments = depiHazem.Departments.ToList();
            Grid.DataSource = departments;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            depiHazem.Departments.Remove(depiHazem.Departments.FirstOrDefault(d => d.Dept_Id == int.Parse(textBox1.Text)));
        }
    }
}
