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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addMusherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var window = new AddMusherForm();
            window.MdiParent = this;
            window.FormBorderStyle = FormBorderStyle.None;
            window.Show();
        }

        private void importArrivalsFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                var filePath = openFileDialog1.FileName;
                DataManager.ProcessArrivals(filePath);
            }
        }
    }
}
