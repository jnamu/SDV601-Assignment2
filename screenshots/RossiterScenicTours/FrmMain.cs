using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RossiterScenicTours
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            cboSortBy.DataSource = _SortStrings;
            cboSortBy.SelectedIndex = 0;

            try
            {
                ClsTourCompany.Retrieve();
                updateDisplay();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private IComparer<ClsTour>[] _Comparer = { new ClsTourNameComparer(), new ClsStartDateComparer() };
        private readonly string[] _SortStrings = { "Tour Name", "Start Date" };

        class ClsStartDateComparer : IComparer<ClsTour>
        {
            public int Compare(ClsTour prTourX, ClsTour prTourY)
            {
                return prTourX.StartDate.Date.CompareTo(prTourY.StartDate.Date);
            }
        }

        class ClsTourNameComparer : IComparer<ClsTour>
        {
            public int Compare(ClsTour prTourX, ClsTour prTourY)
            {
                return prTourX.TourName.CompareTo(prTourY.TourName);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            ClsTourCompany.Save();
        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            ClsTour lcTour = ClsTourCompany.NewTour();
            if (lcTour != null && lcTour.ViewEdit())
            {
                ClsTourCompany.TourList.Add(lcTour.TourID, lcTour);
                updateDisplay();
            }
        }

        private void editTour(ClsTour prTour)
        {
            if (prTour != null && prTour.ViewEdit())
            {
                updateDisplay();
            }
        }

        private void updateDisplay()
        {
            List<ClsTour> lcTourList = ClsTourCompany.TourList.Values.ToList();
            lcTourList.Sort(_Comparer[cboSortBy.SelectedIndex]);
            //lstTours.DataSource = null;  // needed??
            lstTours.DataSource = lcTourList;
        }

        private void btnEditTour_Click(object sender, EventArgs e)
        {
            ClsTour lcTour = (ClsTour)lstTours.SelectedItem;
            if (lcTour == null)
                MessageBox.Show("You must create a tour before you can modify a tour");
            else
                editTour(lcTour);
            updateDisplay();
        }

        private void btnDeleteTour_Click(object sender, EventArgs e)
        {
            if (lstTours.SelectedIndex > -1) //something is selected
            {
                ClsTour lcTour = (ClsTour)lstTours.SelectedItem;
                string message = "Are you sure you would like to delete tour " + lcTour.TourName;
                string caption = "Deleting tour";
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // if the yes button is pressed
                if (result == DialogResult.Yes)
                {
                    ClsTourCompany.TourList.Remove(lcTour.TourID);
                    updateDisplay();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("You have no tours to delete");
            }
        }

        private void cboSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDisplay();
        }
    }
}
