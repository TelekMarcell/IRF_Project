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
        private List <NewMemberClass> UjTag = new List<NewMemberClass>();
        private void buttonSave_Click(object sender, EventArgs e)
        {
            NewMemberClass mb = new NewMemberClass(txtVezeteknev.Text,txtKeresztnev.Text,comboBoxNem.Text,dateTimePickerSzul.Text,txtTelefon.Text,txtEmail.Text,dateTimePickerJoin.Text,comboBoxGymTime.Text,richTextBoxAdress.Text,comboBoxDuration.Text);
            UjTag.Add(mb);
            /* string vnev = txtVezeteknev.Text;
            string knev = txtKeresztnev.Text;
            string nem = comboBox1.Text;
            string szuldat = dateTimePickerSzul.Text;
            string mobil = txtTelefon.Text;
            string email = txtEmail.Text;
            string joindate = dateTimePickerJoin.Text;
            string gymtime = comboBoxGymTime.Text;
            string adress = richTextBoxAdress.Text;
            string membership = comboBoxDuration.Text;*/

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (LocalDB)\\MSSQLLocalDB; database = Konditerem; Integrated Security=True";
            SqlCommand cnd = new SqlCommand();
            cnd.Connection = con;
            cnd.CommandText = "Insert into UjTag (Keresztnev,Vezeteknev,Nem,SzuletesiDatum,Mobil,Email,Csatlakozas,KondiIdo,Lakcim,Tagsaghossza) values('" + mb.vnev + "','" + mb.knev + "','" + mb.nem + "','" + mb.szuldat + "','" + mb.mobil + "','" + mb.email + "','" + mb.joindate + "','" + mb.gymtime + "','" + mb.adress + "','" + mb.membership + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cnd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Új tag elmentve!");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtVezeteknev.Clear();
            txtKeresztnev.Clear();
            comboBoxNem.ResetText();
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
