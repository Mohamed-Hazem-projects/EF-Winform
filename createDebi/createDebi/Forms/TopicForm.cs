using System.Data;
using createDebi.Entities;

namespace createDebi
{
    public partial class TopicForm : Form
    {
        DepiContext DepiHazem = new DepiContext();
        public TopicForm()
        {
            InitializeComponent();
        }
        private void TopicForm_Load(object sender, EventArgs e)
        {

        }
        private void InsertDefault_Click(object sender, EventArgs e)
        {
            Topic Topic1 = new Topic { Top_Name = "Programming" };
            Topic Topic2 = new Topic { Top_Name = "DB" };
            Topic Topic3 = new Topic { Top_Name = "Web" };
            Topic Topic4 = new Topic { Top_Name = "Operating System" };
            Topic Topic5 = new Topic { Top_Name = "Design" };
            DepiHazem.Topics.Add(Topic1);
            DepiHazem.Topics.Add(Topic2);
            DepiHazem.Topics.Add(Topic3);
            DepiHazem.Topics.Add(Topic4);
            DepiHazem.Topics.Add(Topic5);
            DepiHazem.SaveChanges();
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            TopicTable.DataSource = DepiHazem.Topics
                .Select(t => new { Top_ID = t.Top_Id, Top_Name = t.Top_Name }).ToList();
        }

        private void ClearData_Click(object sender, EventArgs e)
        {
            DepiHazem.Topics.RemoveRange(DepiHazem.Topics);
        }

        private void InsertIntoTable_Click(object sender, EventArgs e)
        {
            DepiHazem.Topics.Add(new Topic { Top_Name = TopicName.Text });
            DepiHazem.SaveChanges();
        }

        private void FilterByID_Click(object sender, EventArgs e)
        {
            TopicTable.DataSource = IDfilter.Text == "" ? DepiHazem.Topics.ToList() :
                DepiHazem.Topics.Where(topic => topic.Top_Id.ToString() == IDfilter.Text)
                .ToList() ?? DepiHazem.Topics.ToList();
        }

        private void Namefilter_Click(object sender, EventArgs e)
        {
            TopicTable.DataSource = Nametext.Text == "" ? DepiHazem.Topics.ToList() :
                DepiHazem.Topics.Where(topic => topic.Top_Name.ToString().ToLower()
                                     .Contains(Nametext.Text.ToLower()))
                .ToList() ?? DepiHazem.Topics.ToList();

        }

        private void FirstTopic_Click(object sender, EventArgs e)
        {
            TopicTable.DataSource = new List<Topic>
            {

                DepiHazem.Topics.FirstOrDefault() ?? new Topic()
            };
        }

        private void LastTopic_Click(object sender, EventArgs e)
        {
            TopicTable.DataSource = new List<Topic>
            {

                DepiHazem.Topics.OrderBy(x => x.Top_Id).LastOrDefault() ?? new Topic()
            };
        }

        private void DistinctTopics_Click(object sender, EventArgs e)
        {
            TopicTable.DataSource = DepiHazem.Topics.ToList().Distinct(new TopicComparer()).ToList();
        }
    }
}
