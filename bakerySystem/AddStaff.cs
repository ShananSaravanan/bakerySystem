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
    public partial class AddStaffPage : Form
    {
        bakerysystemEntities2 ent = new bakerysystemEntities2();
        public AddStaffPage()
        {
            InitializeComponent();
        }
        public bool checkEmptyFields()
        {
            bool isEmpty = true;
            if(string.IsNullOrEmpty(nameTxtField.Text) == true || string.IsNullOrEmpty(usernameTxtField.Text) == true || 
                string.IsNullOrEmpty(pwdTxtField.Text) == true || string.IsNullOrEmpty(cpTxtField.Text) == true || 
                string.IsNullOrEmpty(icTxtField.Text) == true || string.IsNullOrEmpty(hpTxtField.Text) == true)
            {
                isEmpty = true;
                MessageBox.Show("All required fields must be filled in");
            }
            else
            {
                isEmpty=false;
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
            bool exist = false;
            var uFound = ent.Staffs.Where(x => x.ID.ToString().Equals(usernameTxtField.Text)).FirstOrDefault();
            var pFound = ent.Staffs.Where(y => y.staffPhoneNo.ToString().Equals(hpTxtField.Text.ToString())).FirstOrDefault();
            var iFound = ent.Staffs.Where(z => z.staffIcNo.ToString().Equals(icTxtField.Text.ToString())).FirstOrDefault();
            if(uFound !=null || pFound!=null || iFound != null)
            {
                exist = true;
                MessageBox.Show("Credentials Given already exists in database");
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
                valid=true;
            }
            else
            {
                valid = false;
                MessageBox.Show("The Phone Number is not valid");
            }
            return valid;
        }
        private void AddStaffPage_Load(object sender, EventArgs e)
        {

        }
        
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            if(!checkEmptyFields() && checkMatch() && checkIc() && checkPhone() && !checkExistingUser())
            {
                Staff s = new Staff();
                s.ID = usernameTxtField.Text;
                s.staffIcNo = icTxtField.Text;
                s.staffPhoneNo = hpTxtField.Text;
                s.staffPassword = pwdTxtField.Text;
                s.staffName = nameTxtField.Text;
                ent.Staffs.Add(s);
                ent.SaveChanges();
                MessageBox.Show("New staff registered successfully", "Success");
                this.Hide();
            }
        }

        
    }
}
