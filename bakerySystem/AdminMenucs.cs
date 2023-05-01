using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakerySystem
{
    public partial class AdminMenu : Form
    {
        bakerysystemEntities2 ent = new bakerysystemEntities2();
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void addNewCakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCakePage ac = new AddCakePage();
            ac.Show();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            

        }

        private void registerStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStaffPage ac = new AddStaffPage();
            ac.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewCake ac = new ViewCake();
            ac.Show();
        }

        private void cakeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditCakePage ac = new EditCakePage();
            ac.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStaff ac = new EditStaff();
            ac.Show();
        }

        private void viewSystemLogDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewLog ac = new ViewLog();
            ac.Show();
        }

        private void viewStaffListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStaff ac = new ViewStaff();
            ac.Show();
        }
    }
}
