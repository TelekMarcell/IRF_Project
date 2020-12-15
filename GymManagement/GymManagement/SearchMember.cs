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
            ListGenerate();
        }
        private void Search()
        {
            if (txtID.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Temp\\Konditerem.mdf;Integrated Security=True";
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

        private string Gender()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Temp\\Konditerem.mdf;Integrated Security=True";
            SqlCommand cnd = new SqlCommand();
            cnd.Connection = con;

            con.Open();
            String syntax = String.Format("SELECT Nem FROM UjTag where TagID = " + txtID.Text + "");
            cnd = new SqlCommand(syntax, con);
            SqlDataReader dr = cnd.ExecuteReader();
            dr.Read();

            string temp = dr[0].ToString();
            con.Close();

            return temp;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }


        List <NemClass> NemList = new List <NemClass>();
        private void ListGenerate()
        {
            int index = 1;
            txtID.Text = index.ToString();
            for (int i = 0; i < SorokSzama(); i++)
            {
                NemClass nem = new NemClass(Gender());
                NemList.Add(nem);
                index++;
            }
            //MessageBox.Show(NemList.Count.ToString());
        }
        private int SorokSzama()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Temp\\Konditerem.mdf;Integrated Security=True";
            SqlCommand cnd = new SqlCommand();
            cnd.Connection = con;

            con.Open();
            String syntax = String.Format("SELECT COUNT(*) FROM UjTag");
            cnd = new SqlCommand(syntax, con);
            SqlDataReader dr  = cnd.ExecuteReader();
            dr.Read();

            int temp = (int)dr[0];
            con.Close();

            return temp;
        }
        
        private void SearchMember_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Temp\\Konditerem.mdf; Integrated Security = True";
            SqlCommand cnd = new SqlCommand();
            cnd.Connection = con;

            cnd.CommandText = "select * from UjTag";

            SqlDataAdapter DA = new SqlDataAdapter(cnd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];


            chartGender.DataSource =
                from x in NemList
                group NemList by x.nem into g
                select new
                {
                    Nem = g.Key,
                    Darab = g.Count()
                };

            var series = chartGender.Series[0];
            series.ChartType = SeriesChartType.Column;
            series.YValueMembers = "Nem";
            series.YValueMembers = "Darab";
            series.BorderWidth = 2;

            var legend = chartGender.Legends[0];
            legend.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int search = rnd.Next(1, 20);
            txtID.Text = search.ToString();

        }
    }
}
