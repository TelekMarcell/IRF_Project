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
        private List <NewMemberClass> newmem = new List<NewMemberClass>();
        private void buttonSave_Click(object sender, EventArgs e)
        {
            NewMemberClass mb = new NewMemberClass(txtVezeteknev.Text,txtKeresztnev.Text,comboBoxNem.Text,dateTimePickerSzul.Text,txtTelefon.Text,txtEmail.Text,dateTimePickerJoin.Text,comboBoxGymTime.Text,richTextBoxAdress.Text,comboBoxDuration.Text);
            newmem.Add(mb);
         
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Temp\\Konditerem.mdf;Integrated Security=True";
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
