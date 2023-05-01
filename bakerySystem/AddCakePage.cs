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
    public partial class AddCakePage : Form
    {
        bakerysystemEntities2 ent = new bakerysystemEntities2();
        public AddCakePage()
        {
            InitializeComponent();
        }
        public bool checkPrice()
        {
            bool isValid = false;
            try
            {
                double price = (double)decimal.Parse(priceTxtField.Text);
                isValid = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Price can only consist numbes");
                isValid = false;
            }
            return isValid;
        }
       public bool checkImage()
        {
            bool imagePresent = false;
            if(pictureBox1 != null)
            {
                imagePresent = true;
            }
            else
            {
                imagePresent = false;
                MessageBox.Show("An image must be added for the cake");
            }
            return imagePresent;
        }
        public bool checkEmptyFields()
        {
            bool isEmpty = true;
            if(string.IsNullOrEmpty(nameTxtField.Text)== true || string.IsNullOrEmpty(priceTxtField.Text) == true)
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
        private void AddCakePage_Load(object sender, EventArgs e)
        {
            var types = (from i in ent.CakeTypes
                         select new
                         {
                             i.TypeName
                         }
            );
            foreach (var type in types)
            {
                typeCmbBox.Items.Add(type.TypeName);
            }
            int rowCount = ent.Cakes.Count()+1;
            IDTxtField.ReadOnly = true;
            IDTxtField.Text ="C"+String.Format("{0:0000}",rowCount);
            typeTxtField.Hide();
            cnclBtn.Hide();
            cfmBtn.Hide();
        }

        

        

        private void chooseImg_Click(object sender, EventArgs e)
        {
            pictureDialog.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";
            if (pictureDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(pictureDialog.FileName);
            }
           
        }

        private void addOptionBtn_Click_1(object sender, EventArgs e)
        {
            typeTxtField.Show();
            cnclBtn.Show();
            cfmBtn.Show();
            typeCmbBox.Hide();
            addOptionBtn.Hide();
            IDTxtField.Enabled = false;
            nameTxtField.Enabled = false;
            priceTxtField.Enabled = false;
            chooseImg.Enabled = false;
            cancelBtn.Enabled = false;
            addcakeBtn.Enabled = false;
        }

        private void cnclBtn_Click_1(object sender, EventArgs e)
        {
            typeTxtField.Hide();
            cnclBtn.Hide();
            cfmBtn.Hide();
            typeCmbBox.Show();
            addOptionBtn.Show();
            IDTxtField.Enabled = true;
            nameTxtField.Enabled = true;
            priceTxtField.Enabled = true;
            chooseImg.Enabled = true;
            cancelBtn.Enabled = true;
            addcakeBtn.Enabled = true;
        }

        private void cfmBtn_Click(object sender, EventArgs e)
        {
            CakeType ct = new CakeType();
            ct.ID = (ent.CakeTypes.Count() + 1).ToString();
            ct.TypeName = typeTxtField.Text;
            ent.CakeTypes.Add(ct);
            ent.SaveChanges();
            typeCmbBox.Items.Clear();
            var types = (from i in ent.CakeTypes
                         select new
                         {
                             i.TypeName
                         }
            );
            foreach (var type in types)
            {
                typeCmbBox.Items.Add(type.TypeName);
            }
            MessageBox.Show("Cake Type Has Been Added Successfully", "Success");
            typeTxtField.Hide();
            cnclBtn.Hide();
            cfmBtn.Hide();
            typeCmbBox.Show();
            addOptionBtn.Show();
            IDTxtField.Enabled = true;
            nameTxtField.Enabled = true;
            priceTxtField.Enabled = true;
            chooseImg.Enabled = true;
            cancelBtn.Enabled = true;
            addcakeBtn.Enabled = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void addcakeBtn_Click(object sender, EventArgs e)
        {
            if(!checkEmptyFields() && checkImage() && checkPrice())
            {
                try
                {
                    var id = (from i in ent.CakeTypes
                              where i.TypeName.Equals(typeCmbBox.SelectedItem.ToString())
                              select new
                              {
                                  i.ID
                              }
                    ).FirstOrDefault();
                    Cake c = new Cake();
                    c.ID = IDTxtField.Text;
                    c.cakeName = nameTxtField.Text;
                    c.typeID = id.ID;
                    c.pricePerSlice =double.Parse(priceTxtField.Text);
                    ImageConverter imgCon = new ImageConverter();
                    c.cakeImage = (byte[])imgCon.ConvertTo(pictureBox1.Image, typeof(byte[]));
                    ent.Cakes.Add(c);
                    ent.SaveChanges();
                    MessageBox.Show("Cake Successfully Added to the Menu");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Image.FromFile(pictureDialog.FileName).ToString()+ex.ToString());
                }
            }
        }
    }
}
