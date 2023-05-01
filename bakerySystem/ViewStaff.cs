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
    public partial class ViewStaff : Form
    {
        bakerysystemEntities2 ent = new bakerysystemEntities2();
        public ViewStaff()
        {
            InitializeComponent();
        }

        private void ViewStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bakerysystemDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.bakerysystemDataSet.Staff);
            totalItemsLbl.Text = dataGridView1.Rows.Count.ToString() + " items found";

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBox.Text) == true)
            {
                dataGridView1.DataSource = (from i in ent.Staffs
                                            select new
                                            {
                                                i.ID,
                                                i.staffIcNo,
                                                i.staffName,
                                                i.staffPhoneNo,
                                                i.staffPassword
                                            }).ToList();
            }
            else
            {
                dataGridView1.DataSource = (from i in ent.Staffs
                                            where i.ID.ToString().StartsWith(searchBox.Text)
                                            select new
                                            {
                                                i.ID,
                                                i.staffIcNo,
                                                i.staffName,
                                                i.staffPhoneNo,
                                                i.staffPassword
                                            }).ToList();
            }
            totalItemsLbl.Text = dataGridView1.Rows.Count.ToString() + " items found";
        }
    }
}
