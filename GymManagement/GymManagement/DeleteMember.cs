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
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ez törölni fogja az Ön által kiválasztott adatot! Biztosan folytatni kivánja?", "Adat törlése", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = (LocalDB)\\MSSQLLocalDB; database = Konditerem; Integrated Security=True";
                SqlCommand cnd = new SqlCommand();
                cnd.Connection = con;

                cnd.CommandText = "delete from UjTag where TagID = " + txtBID.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cnd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }
            else
            {
                this.Activate();
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
        }

        private void DeleteMember_Load(object sender, EventArgs e)
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
