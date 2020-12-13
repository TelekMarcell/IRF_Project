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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
