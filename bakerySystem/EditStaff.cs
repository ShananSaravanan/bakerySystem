using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakerySystem
{
    public partial class EditStaff : Form
    {
        bakerysystemEntities2 ent = new bakerysystemEntities2();
        public static int rowSelected;
        public EditStaff()
        {
            InitializeComponent();
        }
        public bool checkEmptyFields()
        {
            bool isEmpty = true;
            if (string.IsNullOrEmpty(nameTxtField.Text) == true || string.IsNullOrEmpty(usernameTxtField.Text) == true ||
                string.IsNullOrEmpty(pwdTxtField.Text) == true || string.IsNullOrEmpty(cpTxtField.Text) == true ||
                string.IsNullOrEmpty(usernameTxtField.Text) == true || string.IsNullOrEmpty(hpTxtField.Text) == true)
            {
                isEmpty = true;
                MessageBox.Show("All required fields must be filled in");
            }
            else
            {
                isEmpty = false;
            }
            return isEmpty;
        }
        public bool checkMatch()
        {
            bool match = false;
            if (pwdTxtField.Text.Equals(cpTxtField.Text))
            {
                match = true;
            }
            else
            {
                match = false;
                MessageBox.Show("Passwords does not match");
            }
            return match;
        }
        public bool checkExistingUser()
        {
            
            bool exist = true;
            string value = (dataGridView1.Rows[rowSelected].Cells[0].Value.ToString());
            string value1 = (dataGridView1.Rows[rowSelected].Cells[1].Value.ToString());
            string value2 = (dataGridView1.Rows[rowSelected].Cells[3].Value.ToString());
            var uFound = ent.Staffs.Where(x => x.ID.ToString().Equals(usernameTxtField.Text) && !(x.ID.ToString().Equals(value))).FirstOrDefault();
            var iFound = ent.Staffs.Where(y => y.staffIcNo.ToString().Equals(icTxtField.Text) && !(y.staffIcNo.ToString().Equals(value1))).FirstOrDefault();
            var pFound = ent.Staffs.Where(z => z.staffPhoneNo.ToString().Equals(hpTxtField.Text) && !(z.staffPhoneNo.ToString().Equals(value2))).FirstOrDefault();
            if (uFound != null || iFound !=null || pFound !=null)
            {
                exist = true;
                MessageBox.Show("Exists");
            }
            else
            {
                exist = false;
            }
            return exist;
        }
        public bool checkIc()
        {
            bool valid = false;
            Regex regexPattern = new Regex(@"^\d{6}-\d{2}-\d{4}$");
            if (regexPattern.IsMatch(icTxtField.Text))
            {
                valid = true;
            }
            else
            {
                valid = false;
                MessageBox.Show("The IC Number is not valid");
            }
            return valid;
        }
        public bool checkPhone()
        {
            bool valid = false;
            Regex rg = new Regex(@"(\+?6?01)[0-46-9]-*[0-9]{7,8}");
            if (rg.IsMatch(hpTxtField.Text))
            {
                valid = true;
            }
            else
            {
                valid = false;
                MessageBox.Show("The Phone Number is not valid");
            }
            return valid;
        }
        private void EditStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bakerysystemDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.bakerysystemDataSet.Staff);
            groupBox1.Visible = false;
            totalItemsLbl.Text = dataGridView1.Rows.Count.ToString() + " items found";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            rowSelected = dataGridView1.CurrentCell.RowIndex;
            groupBox1.Visible = true;
            editBtn.Visible = false;
            removeBtn.Visible = false;
            string id = dataGridView1.Rows[rowSelected].Cells[0].Value.ToString();
            string ic = dataGridView1.Rows[rowSelected].Cells[1].Value.ToString();
            string name = dataGridView1.Rows[rowSelected].Cells[2].Value.ToString();
            string hp = dataGridView1.Rows[rowSelected].Cells[3].Value.ToString();
            string pwd = dataGridView1.Rows[rowSelected].Cells[4].Value.ToString();
            nameTxtField.Text = name;
            icTxtField.Text = ic;
            usernameTxtField.Text = id;
            hpTxtField.Text = hp;
            pwdTxtField.Text = pwd;
            cpTxtField.Text = pwd;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            editBtn.Visible = true;
            removeBtn.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!checkEmptyFields() && checkMatch() && checkIc() && checkPhone() && !checkExistingUser())
            {
                string value = (dataGridView1.Rows[rowSelected].Cells[0].Value.ToString());
                var oldData = ent.Staffs.Where(x => x.ID == value).FirstOrDefault();
                ent.Staffs.Remove(oldData);
                Staff s = new Staff();
                s.ID = usernameTxtField.Text;
                s.staffIcNo = icTxtField.Text;
                s.staffPhoneNo = hpTxtField.Text;
                s.staffPassword = pwdTxtField.Text;
                s.staffName = nameTxtField.Text;
                ent.Staffs.Add(s);
                ent.SaveChanges();
                MessageBox.Show("Staff details edited successfully");
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
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            int rowCount = dataGridView1.CurrentCell.RowIndex;
            string value = dataGridView1.Rows[rowCount].Cells[0].Value.ToString();
            var del = ent.Staffs.Where(x => x.ID == value).FirstOrDefault();
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ent.Staffs.Remove(del);
                MessageBox.Show("Items deleted successfully");
                ent.SaveChanges();
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
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
                dataGridView1.DataSource = (from i in ent.Staffs where i.ID.ToString().StartsWith(searchBox.Text)
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
