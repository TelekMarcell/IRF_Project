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
    public partial class NewStaff : Form
    {
        public NewStaff()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string vnev = txtVeznev.Text;
            string knev = txtKernev.Text;

            string nem = "";
            bool IsChecked = radioButtonFerf.Checked;
            if (IsChecked)
            {
                nem = radioButtonFerf.Text;
            }
            else
            {
                nem = radioButtonNoi.Text;
            }

            string szuldat = dateTimePickerDOB.Text;
            string mobil = txtPhone.Text;
            string email = txtMaile.Text;
            string joindate = dateTimePickerWork.Text;
            string state = txtState.Text;
            string city = txtCity.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (LocalDB)\\MSSQLLocalDB; database = Konditerem; Integrated Security=True";
            SqlCommand cnd = new SqlCommand();
            cnd.Connection = con;
            cnd.CommandText = "Insert into UjMunkatars (Keresztnev,Vezeteknev,Nem,SzuletesiDatum,Mobil,Email,Csatlakozas,Megye,Varos) values('" + vnev + "','" + knev + "','" + nem + "','" + szuldat + "','" + mobil + "','" + email + "','" + joindate + "','" + state + "','" + city + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cnd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Új munkatárs elmentve!");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtVeznev.Clear();
            txtKernev.Clear();
            radioButtonFerf.Checked = false;
            radioButtonNoi.Checked = false;
            txtPhone.Clear();
            txtMaile.Clear();
            txtState.Clear();
            txtCity.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerWork.Value = DateTime.Now;
        }
    }
}
