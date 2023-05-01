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
    public partial class ViewCake : Form
    {
        bakerysystemEntities2 ent = new bakerysystemEntities2();
        public ViewCake()
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
                    dataGridView1.Rows.Add(cake.ID, cake.cakeName, cake.TypeName, "RM" + cake.pricePerSlice, Image.FromStream(ms));
                }

            }
        }
        private void ViewCake_Load(object sender, EventArgs e)
        {
            loadData();
            totalItemsLbl.Text = dataGridView1.Rows.Count.ToString() + " items found";
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
                        dataGridView1.Rows.Add(search.ID, search.cakeName, search.TypeName, "RM" + search.pricePerSlice, Image.FromStream(ms));
                    }

                }
            }
            totalItemsLbl.Text = dataGridView1.Rows.Count.ToString() + " items found";
        }
    }
}
