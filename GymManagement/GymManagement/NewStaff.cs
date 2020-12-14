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

        private List<NewStaffClass> UjMunkatars = new List<NewStaffClass>();
        private void buttonSave_Click(object sender, EventArgs e)
        {
            NewStaffClass stf = new NewStaffClass(txtVeznev.Text, txtKernev.Text, comboBoxNem.Text, dateTimePickerDOB.Text, txtPhone.Text, txtMaile.Text, dateTimePickerWork.Text, txtState.Text, txtCity.Text);
            UjMunkatars.Add(stf);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Temp\\Konditerem.mdf;Integrated Security=True";
            SqlCommand cnd = new SqlCommand();
            cnd.Connection = con;
            cnd.CommandText = "Insert into UjMunkatars (Keresztnev,Vezeteknev,Nem,SzuletesiDatum,Mobil,Email,Csatlakozas,Megye,Varos) values('" + stf.vnev + "','" + stf.knev + "','" + stf.nem + "','" + stf.szuldat + "','" + stf.mobil + "','" + stf.email + "','" + stf.joindate + "','" + stf.state + "','" + stf.city + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cnd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Új munkatárs elmentve!");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtVeznev.Clear();
            txtKernev.Clear();
            comboBoxNem.ResetText();
            txtPhone.Clear();
            txtMaile.Clear();
            txtState.Clear();
            txtCity.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerWork.Value = DateTime.Now;
        }
    }
}
