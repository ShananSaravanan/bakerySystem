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
    public partial class EditCakePage : Form
    {
        bakerysystemEntities2 ent = new bakerysystemEntities2();
        public EditCakePage()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            var cakes = (from i in ent.Cakes
                         join k in ent.CakeTypes on i.typeID equals k.ID
                         select new
                         {
                             i.ID,
                             i.cakeName,
                             i.pricePerSlice,
                             k.TypeName,
                             i.cakeImage
                         });
            foreach (var cake in cakes)
            {
                byte[] image = cake.cakeImage;
                using (MemoryStream ms = new MemoryStream(image))
                {
                    dataGridView1.Rows.Add(cake.ID, cake.cakeName, cake.TypeName,cake.pricePerSlice, Image.FromStream(ms));
                }

            }
        }
        private void addOptionBtn_Click(object sender, EventArgs e)
        {
            addOptionBtn.Visible = false;
            cnclBtn.Visible = true;
            cfmBtn.Visible = true;
            typeTxtBox.Enabled = true;
            typeCmbBox.Enabled = false;
            chooseImg.Enabled = false;
            priceTxtField.Enabled = false;
            cakeIDTxtField.Enabled = false;
            nameTxtField.Enabled = false;
            typeTxtBox.Visible = true;
        }

        private void cfmBtn_Click(object sender, EventArgs e)
        {
            CakeType ct = new CakeType();
            ct.ID = (ent.CakeTypes.Count() + 1).ToString();
            ct.TypeName = typeTxtBox.Text;
            ent.CakeTypes.Add(ct);
            ent.SaveChanges();
            MessageBox.Show("New cake type added successfully");
            typeCmbBox.Items.Clear();
            addOptionBtn.Visible = true;
            cnclBtn.Visible = false;
            cfmBtn.Visible = false;
            typeTxtBox.Enabled = false;
            typeCmbBox.Enabled = true;
            chooseImg.Enabled = true;
            priceTxtField.Enabled = true;
            cakeIDTxtField.Enabled = true;
            nameTxtField.Enabled = true;
            typeTxtBox.Visible = false;
            loadCmbBoxData();
        }

        private void cnclBtn_Click(object sender, EventArgs e)
        {
            addOptionBtn.Visible = true;
            cnclBtn.Visible = false;
            cfmBtn.Visible = false;
            typeTxtBox.Enabled = false;
            typeCmbBox.Enabled = true;
            chooseImg.Enabled = true;
            priceTxtField.Enabled = true;
            cakeIDTxtField.Enabled = true;
            nameTxtField.Enabled = true;
            typeTxtBox.Visible = false;
        }
        public void loadCmbBoxData()
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
            if (pictureBox1 != null)
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
            if (string.IsNullOrEmpty(nameTxtField.Text) == true || string.IsNullOrEmpty(priceTxtField.Text) == true)
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
        private void EditCakePage_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            loadData();
            loadCmbBoxData();
            cfmBtn.Visible = false;
            cnclBtn.Visible = false;
            typeTxtBox.Visible = false;
            totalItemsLbl.Text = dataGridView1.Rows.Count.ToString() + " items found";

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int rowcount = dataGridView1.CurrentCell.RowIndex;
            groupBox1.Visible=true;
            editBtn.Visible=false;
            removeBtn.Visible=false;
            cakeIDTxtField.Text = dataGridView1.Rows[rowcount].Cells[0].Value.ToString();
            nameTxtField.Text = dataGridView1.Rows[rowcount].Cells[1].Value.ToString();
            string type = dataGridView1.Rows[rowcount].Cells[2].Value.ToString();
            typeCmbBox.SelectedText = type;
            priceTxtField.Text = dataGridView1.Rows[rowcount].Cells[3].Value.ToString();
            var img = (from i in ent.Cakes
                       where i.ID.ToString().Equals(cakeIDTxtField.Text)
                       select new
                       {
                           i.cakeImage
                       }).FirstOrDefault();
            byte[] image = img.cakeImage;
            using (MemoryStream ms = new MemoryStream(image))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            editBtn.Visible = true;
            removeBtn.Visible = true;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (!checkEmptyFields() && checkImage() && checkPrice())
            {
                var type = (from y in ent.CakeTypes where y.TypeName.ToString().Equals(typeCmbBox.SelectedItem.ToString()) select new
                {
                    y.ID
                }).FirstOrDefault();
                var oldData = ent.Cakes.Where(x => x.ID == cakeIDTxtField.Text).FirstOrDefault();
                ent.Cakes.Remove(oldData);
                Cake c = new Cake();
                c.ID = cakeIDTxtField.Text;
                c.pricePerSlice = double.Parse(priceTxtField.Text);
                c.typeID = type.ID;
                c.cakeName = nameTxtField.Text;
                ImageConverter imgCon = new ImageConverter();
                c.cakeImage = (byte[])imgCon.ConvertTo(pictureBox1.Image, typeof(byte[]));
                ent.Cakes.Add(c);
                ent.SaveChanges();
                MessageBox.Show("Selected Item edited successfully", "Success");
                groupBox1.Visible = false;
                editBtn.Visible = true;
                removeBtn.Visible = true;
                dataGridView1.Rows.Clear();
                loadData();
            }
        }

        private void chooseImg_Click(object sender, EventArgs e)
        {
            pictureDialog.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";
            if (pictureDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(pictureDialog.FileName);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            int rowcount = dataGridView1.CurrentCell.RowIndex;
            string value = dataGridView1.Rows[rowcount].Cells[0].Value.ToString();
            var del = ent.Cakes.Where(x => x.ID == value).FirstOrDefault();
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ent.Cakes.Remove(del);
                MessageBox.Show("Items deleted successfully");
                dataGridView1.Rows.Clear();
                ent.SaveChanges();
                loadData();
            }
            else
            {
                return;
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();
            if (string.IsNullOrEmpty(searchBox.Text) == true)
            {
                loadData();
            }
            else
            {
                var searches = (from x in ent.Cakes
                                join y in ent.CakeTypes on x.typeID equals y.ID
                                where x.cakeName.StartsWith(searchBox.Text)
                                select new
                                {
                                    x.ID,
                                    x.cakeName,
                                    x.pricePerSlice,
                                    y.TypeName,
                                    x.cakeImage
                                });
                foreach (var search in searches)
                {
                    byte[] image = search.cakeImage;
                    using (MemoryStream ms = new MemoryStream(image))
                    {
                        dataGridView1.Rows.Add(search.ID, search.cakeName, search.TypeName,search.pricePerSlice, Image.FromStream(ms));
                    }

                }
            }
            totalItemsLbl.Text = dataGridView1.Rows.Count.ToString() + " items found";
        }
    }
}
