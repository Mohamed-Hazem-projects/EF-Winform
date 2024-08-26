using createDebi.Entities;
using System.Data;


namespace createDebi
{
    public partial class InstructorForm : Form
    {
        DepiContext DepiHazem = new DepiContext();
        public InstructorForm()
        {
            InitializeComponent();
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            InstructorTable.DataSource = DepiHazem.Instructors
                .Select(ins => new
                {
                    ID = ins.Ins_Id,
                    Name = ins.Ins_Name,
                    Degree = ins.Ins_Degree,
                    Salary = ins.Salary
                }).ToList();
        }

        private void ClearData_Click(object sender, EventArgs e)
        {
            DepiHazem.Instructors.RemoveRange(DepiHazem.Instructors);
        }

        private void InsertIntoTable_Click(object sender, EventArgs e)
        {
            DepiHazem.Instructors.Add(new Instructor { Ins_Name=Nametxt.Text,
            Ins_Degree=Degreetxt.Text,Salary=int.Parse(Salarytxt.Text) });
            DepiHazem.SaveChanges();
        }

        private void FilterByID_Click(object sender, EventArgs e)
        {
            InstructorTable.DataSource = IDfilter.Text == "" ? DepiHazem.Instructors.ToList() :
                DepiHazem.Instructors.Where(ins => ins.Ins_Id.ToString() == IDfilter.Text)
                .ToList() ?? DepiHazem.Instructors.ToList();
        }

        private void Namefilter_Click(object sender, EventArgs e)
        {
            InstructorTable.DataSource = Nametext.Text == "" ? DepiHazem.Instructors.ToList() :
                DepiHazem.Instructors.Where(ins => ins.Ins_Name.ToString().ToLower()
                                     .Contains(Nametext.Text.ToLower()))
                .ToList() ?? DepiHazem.Instructors.ToList();

        }
        private void FirstInstructor_Click(object sender, EventArgs e)
        {
            InstructorTable.DataSource = new List<Instructor>
            {

                DepiHazem.Instructors.FirstOrDefault() ?? new Instructor()
            };
        }

        private void LastInstructor_Click(object sender, EventArgs e)
        {
            InstructorTable.DataSource = new List<Instructor>
            {

                DepiHazem.Instructors.OrderBy(x => x.Ins_Id).LastOrDefault() ?? new Instructor()
            };
        }

        private void DistinctInstructor_Click(object sender, EventArgs e)
        {
            InstructorTable.DataSource = DepiHazem.Instructors.ToList()
                .Distinct(new InstructorComparer()).ToList();
        }
        private void InsertDefault_Click(object sender, EventArgs e)
        {
            List<Instructor> list = new List<Instructor>{
            new Instructor{ Ins_Name = "Ahmed",Ins_Degree= "Master",
                Salary = 1000, },
            new Instructor
            {
                Ins_Name = "Hany",
                Ins_Degree = "Master",
                Salary = 2000,
            },
            new Instructor
            {
                Ins_Name = "Reham",
                Ins_Degree = "Master",
                Salary = 30000,
            },
            new Instructor
            {
                Ins_Name = "Yasmin",
                Ins_Degree = "PHD",
                Salary = 40000,
            },
            new Instructor
            {
                Ins_Name = "Amany",
                Ins_Degree = "PHD",
                Salary = 5000,
            },
            new Instructor
            {
                Ins_Name = "Eman",
                Ins_Degree = "Master",
                Salary = 6000,
            },
            new Instructor
            {
                Ins_Name = "Saly",
                Salary = 7000,
            },
            new Instructor
            {
                Ins_Name = "Amr",
                Salary = 8000,
            },
            new Instructor
            {
                Ins_Name = "Hussien",
                Ins_Degree = "Master",
                Salary = 90000,
            },
             new Instructor
            {
                Ins_Name = "Khalid",
                Ins_Degree = "PHD",
                Salary = 10000,
            },
            new Instructor
            {
                Ins_Name = "Salah",
                Ins_Degree = "Bachelor"
            },
            new Instructor
            {
                Ins_Name = "Adel",
                Salary = 10001,
            },
            new Instructor
            {
                Ins_Name = "Fakry",
                Ins_Degree = "Master",
            },
            new Instructor
            {
                Ins_Name = "Amena",
                Ins_Degree = "PHD",
            },
            new Instructor{ Ins_Name = "Ghada"}};

            DepiHazem.Instructors.AddRange(list);
            DepiHazem.SaveChanges();
        }
    }
}
