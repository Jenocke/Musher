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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                MessageBox.Show("Submitted");
            else
                MessageBox.Show(errorMessage);
        }
    }
}
