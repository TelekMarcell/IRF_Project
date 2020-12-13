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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMember nm = new NewMember();
            nm.Show();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStaff ns = new NewStaff();
            ns.Show();
        }

        private void tartozékokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment eq = new Equipment();
            eq.Show();
        }

        private void tagKereséseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMember sm = new SearchMember();
            sm.Show();

        }

        private void tagTörléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMember dm = new DeleteMember();
            dm.Show();
        }

        private void bezárásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ez be fogja záni az Ön applikációját! Biztosan folytatni kivánja?", "Bezárás", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Üdv itt nálunk újra!", "Üdvözlő", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void kijelentkezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan ki akar jelentkezni?", "Kijelentkezés", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                LogIn lg = new LogIn();
                lg.Show();
            }
        }
    }
}
