using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musher
{
    public partial class AddMusherForm : Form
    {
        private readonly MusherChipControlEntities musherChipControlEntities;
        public AddMusherForm()
        {
            InitializeComponent();
            musherChipControlEntities = new MusherChipControlEntities();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string musherName = txtBox_MushName.Text;
            int musherNumber = (int)num_MushNumber.Value;
            string musherCategory = cbb_Category.Text;

            string errorMessage = "";
            bool isValid = false;
            if (string.IsNullOrEmpty(txtBox_MushName.Text))
                errorMessage = "Please enter the musher's name";
            else if (string.IsNullOrEmpty(musherCategory))
                errorMessage = "Please enter the category";
            else
                isValid = true;

            if(isValid)
            {
                var musher = new Musher_Table();

                musher.MusherName = musherName;
                musher.MusherNumber = musherNumber;
                musher.Category = (int)cbb_Category.SelectedValue;

                musherChipControlEntities.Musher_Table.Add(musher);
                musherChipControlEntities.SaveChanges();

                MessageBox.Show("Submitted");
            }
            else
                MessageBox.Show(errorMessage);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var categories = musherChipControlEntities.Category_Table.ToList();
            cbb_Category.Items.Clear();
            cbb_Category.DisplayMember = "Name";
            cbb_Category.ValueMember = "Id";
            cbb_Category.DataSource = categories;
        }
    }
}
