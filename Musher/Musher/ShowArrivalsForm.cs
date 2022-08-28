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
    public partial class ShowArrivalsForm : Form
    {
        private readonly MusherChipControlEntities _dbArrivals;
        public ShowArrivalsForm()
        {
            InitializeComponent();
            _dbArrivals = new MusherChipControlEntities();
        }

        private void ShowArrivalsForm_Load(object sender, EventArgs e)
        {

            var dogsArrivals = _dbArrivals.DogsTable.Select(q => new { MusherID = q.LinkedMusher, ChipID = q.DogChip}).ToList();
            /*foreach (var arri in arrivals)
            {

            }*/
            arrivalsView.DataSource = dogsArrivals;
            //arrivalsView.Columns[0].HeaderText = "Linked ID";
            //arrivalsView.Columns[1].HeaderText = "Chip ID";
           // arrivalsView.Columns[2].HeaderText = "Arrival Date";
        }
    }
}
