using Business_Layers;
using System.Data;

namespace Disconnected_Ado_Mode
{
    public partial class Form1 : Form
    {
        TopicBl _topBl;
        int _id;
        int rowAffected;
        public Form1()
        {
            InitializeComponent();
            _topBl = new TopicBl();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            GetAllData();
        }
        public void GetAllData()
        {
            dgv_topic.DataSource = _topBl.GetAllInDataTabel();
            dgv_topic.Columns[0].ReadOnly = true;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            int rowAffected = _topBl.Insert(txt_tname.Text);
            if (rowAffected > 0)
            {
                MessageBox.Show($"{rowAffected} Row Affected");
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
            GetAllData();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
             rowAffected = _topBl.Update(_id, txt_tname.Text);
            if (rowAffected > 0)
            {
                MessageBox.Show($"{rowAffected} Row Affected");
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
            GetAllData();
        }

        private void dgv_topic_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dataGridViewRow = dgv_topic.Rows[e.RowIndex];
            txt_tname.Text = dataGridViewRow.Cells[1].Value.ToString();
            if (dataGridViewRow != null)
            {
                _id = ((int)dataGridViewRow.Cells[0].Value);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            rowAffected = _topBl.Delete(_id);
            if (rowAffected > 0)
            {
                MessageBox.Show($"{rowAffected} Row Affected");
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
            GetAllData();
        }
    }
}