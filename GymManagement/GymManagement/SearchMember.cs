using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GymManagement
{
    public partial class SearchMember : Form
    {
        public SearchMember()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = (LocalDB)\\MSSQLLocalDB; database = Konditerem; Integrated Security=True";
                SqlCommand cnd = new SqlCommand();
                cnd.Connection = con;

                cnd.CommandText = "select * from UjTag where TagID = " + txtID.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cnd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
            else 
            {
                MessageBox.Show("Kérem írjon be egy ID-t!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void SearchMember_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (LocalDB)\\MSSQLLocalDB; database = Konditerem; Integrated Security=True";
            SqlCommand cnd = new SqlCommand();
            cnd.Connection = con;

            cnd.CommandText = "select * from UjTag";

            SqlDataAdapter DA = new SqlDataAdapter(cnd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];

            chartGender.DataSource = dataGridView1;

            var series = chartGender.Series[0];
            series.ChartType = SeriesChartType.Column;
            series.XValueMember = "Nem";
            series.YValueMembers = "Count of Nem";
            series.BorderWidth = 2;
            var legend = chartGender.Legends[0];
            legend.Enabled = false;

            var chartArea = chartGender.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int search = rnd.Next(1, 20);
            txtID.Text = search.ToString();

        }
    }
}
