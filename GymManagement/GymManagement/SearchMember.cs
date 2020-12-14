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
            con.ConnectionString = "Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\\Temp\\Konditerem.mdf; Integrated Security = True";
            SqlCommand cnd = new SqlCommand();
            cnd.Connection = con;

            cnd.CommandText = "select * from UjTag";

            SqlDataAdapter DA = new SqlDataAdapter(cnd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];

            /*chartGender.Series.Add(new Series());
            chartGender.Series[0].XValueMember = dataGridView1.Columns["Nem"].HeaderText;
            chartGender.Series[0].YValueMembers = dataGridView1.Columns["Nem"].DataPropertyName;
            chartGender.DataSource = dataGridView1.DataSource;

            chartGender.Series[0].ChartType = SeriesChartType.Column;*/

            /*chartGender.DataSource = UjTag;

            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;

            var legend = chartRateData.Legends[0];
            legend.Enabled = false;

            var chartArea = chartRateData.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int search = rnd.Next(1, 20);
            txtID.Text = search.ToString();

        }
    }
}
