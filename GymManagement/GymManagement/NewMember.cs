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
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string vnev = txtVezeteknev.Text;
            string knev = txtKeresztnev.Text;

            string nem = "";
            bool IsChecked = radioButton1.Checked;
            if(IsChecked)
            {
                nem = radioButton1.Text;
            }
            else
            {
                nem = radioButton2.Text;
            }

            string szuldat = dateTimePickerSzul.Text;
            string mobil = txtTelefon.Text;
            string email = txtEmail.Text;
            string joindate = dateTimePickerJoin.Text;
            string gymtime = comboBoxGymTime.Text;
            string adress = richTextBoxAdress.Text;
            string membership = comboBoxDuration.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (LocalDB)\\MSSQLLocalDB; database = Konditerem; Integrated Security=True";
            SqlCommand cnd = new SqlCommand();
            cnd.Connection = con;
            cnd.CommandText = "Insert into UjTag (Keresztnev,Vezeteknev,Nem,SzuletesiDatum,Mobil,Email,Csatlakozas,KondiIdo,Lakcim,Tagsaghossza) values('" + vnev + "','" + knev + "','" + nem + "','" + szuldat + "','" + mobil + "','" + email + "','" + joindate + "','" + gymtime + "','" + adress + "','" + membership + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cnd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Új tag elmentve!");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtVezeteknev.Clear();
            txtKeresztnev.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            txtTelefon.Clear();
            txtEmail.Clear();

            comboBoxGymTime.ResetText();
            comboBoxDuration.ResetText();
            richTextBoxAdress.Clear();

            dateTimePickerSzul.Value = DateTime.Now;
            dateTimePickerJoin.Value = DateTime.Now;
        } 
    }
}
