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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private List<EquipmentClass> Eszkozok = new List<EquipmentClass>();
        private void btnMentes_Click(object sender, EventArgs e)
        {
            EquipmentClass esz = new EquipmentClass(txtEszkoz.Text, txtLeiras.Text, txtHI.Text, dateTimePickerDatum.Text, txtAr.Text);
            Eszkozok.Add(esz);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Temp\\Konditerem.mdf;Integrated Security=True";
            SqlCommand cnd = new SqlCommand();
            cnd.Connection = con;
            cnd.CommandText = "Insert into Eszkozok (Eszkoz,Leiras,HasznaltIzmok,Datum,Ar) values('" + esz.equipment + "','" + esz.description + "','" + esz.muscle + "','" + esz.date + "','" + esz.cost + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cnd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Új eszköz elmentve!");
        }

        private void btnVissz_Click(object sender, EventArgs e)
        {
            txtEszkoz.Clear();
            txtLeiras.Clear();
            txtHI.Clear();
            dateTimePickerDatum.Value = DateTime.Now;
            txtAr.Clear();
        }

        private void btnMegtekint_Click(object sender, EventArgs e)
        {
            ViewEquipment vw = new ViewEquipment();
            vw.Show();
        }
    }
}
