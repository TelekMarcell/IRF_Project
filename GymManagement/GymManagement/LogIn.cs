using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtusername.Text == "PerfectGym19" && txtpassword.Text == "Konditer1234")
            {
                Form1 fone = new Form1();
                fone.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Helytelen felhasználónév vagy jelszó", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
