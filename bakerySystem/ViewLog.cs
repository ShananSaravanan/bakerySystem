using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakerySystem
{
    public partial class ViewLog : Form
    {
        bakerysystemEntities2 ent = new bakerysystemEntities2();
        public ViewLog()
        {
            InitializeComponent();
        }

        private void ViewLog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bakerysystemDataSet.Log' table. You can move, or remove it, as needed.
            this.logTableAdapter.Fill(this.bakerysystemDataSet.Log);
            totalItemsLbl.Text = dataGridView1.Rows.Count.ToString() + " items found";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)

        {
            if (string.IsNullOrEmpty(searchBox.Text) == true)
            {
                dataGridView1.DataSource = (from i in ent.Logs
                                            select new
                                            {
                                                i.logID,
                                                i.logInTime,
                                                i.staffID
                                            }).ToList();
            }
            else
            {
                dataGridView1.DataSource = (from i in ent.Logs
                                            where i.staffID.ToString().StartsWith(searchBox.Text)
                                            select new
                                            {
                                                i.logID,
                                                i.logInTime,
                                                i.staffID
                                            }).ToList();
            }
            totalItemsLbl.Text = dataGridView1.Rows.Count.ToString() + " items found";
        }
    }
}
