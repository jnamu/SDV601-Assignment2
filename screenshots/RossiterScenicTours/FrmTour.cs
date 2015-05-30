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
    public partial class FrmTour : Form
    {
        public ClsTour _Tour;
        public ClsCost _Cost;

        public FrmTour()
        {
            InitializeComponent();
            cboTypeOfCost.DataSource = ClsCost.CostType;
            cboTypeOfCost.SelectedIndex = 0;
        }

        // Shows form
        public bool ShowDialog(ClsTour prTour)
        {
            _Tour = prTour;
            updateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTourID.Enabled && ClsTourCompany.TourList.ContainsKey(txtTourID.Text))
                    MessageBox.Show("Tour with that ID already exists", "Duplicate ID");
                else
                {
                    pushData();
                    DialogResult = DialogResult.OK;
                }
             }
             catch (Exception ex)
             {
                MessageBox.Show(ex.Message);
             }
        }

        // Updates display
        protected virtual void updateDisplay()
        {
            txtTourID.Text = _Tour.TourID;
            txtTourName.Text = _Tour.TourName;
            txtTourDescription.Text = _Tour.TourDescription;
            txtDistance.Text = Convert.ToString(_Tour.Distance);
            dtpStartDate.Value = _Tour.StartDate;
            dtpEndDate.Value = _Tour.EndDate;
            txtMaxNOP.Text = Convert.ToString(_Tour.MaxNOP);
            lblShowTotalCosts.Text = _Tour.TotalCosts;
            txtMarkup.Text = Convert.ToString(_Tour.Markup);
            txtTourID.Enabled = String.IsNullOrEmpty(_Tour.TourID);
        }

        protected virtual void pushData()
        {
            _Tour.TourID = txtTourID.Text;
            _Tour.TourName = txtTourName.Text;
            _Tour.TourDescription = txtTourDescription.Text;
            _Tour.Distance = txtDistance.Text;
            _Tour.StartDate = dtpStartDate.Value;
            _Tour.EndDate = dtpEndDate.Value;
            _Tour.MaxNOP = Convert.ToDecimal(txtMaxNOP.Text);
            _Tour.TotalCosts = lblShowTotalCosts.Text;
            _Tour.Markup = Convert.ToDecimal(txtMarkup.Text);
        }

        private void updateCostDisplay()
        {
            List<ClsCost> lcCostList = _Tour.CostList.ToList();
          //  List<ClsCost> lcCostList = ClsTour.CostList.ToList();
            lstCosts.DataSource = lcCostList;
        }

        private void btnAddCost_Click(object sender, EventArgs e)
        {
            ClsCost _Cost = ClsCost.NewCost(cboTypeOfCost.SelectedIndex, _Tour);
            if (_Cost.ViewEdit())
            {
                pushData();
                _Tour.CostList.Add(_Cost);
                updateCostDisplay();
                UpdatelblShowTotalCosts();
            }
        }

        private void btnEditCost_Click(object sender, EventArgs e)
        {
            ClsCost _Cost = (ClsCost)lstCosts.SelectedItem;
            if (_Cost == null)
                MessageBox.Show("You must create a cost before you can modify a cost");
            else
                editCost();
            updateCostDisplay();
            UpdatelblShowTotalCosts();
        }

        private void editCost()
        {
            ClsCost _Cost = (ClsCost)lstCosts.SelectedItem;
            _Cost.ViewEdit();
            updateDisplay();
        }

        private void btnRemoveCost_Click(object sender, EventArgs e)
        {
            if (lstCosts.SelectedIndex > -1) //something is selected
            {
                ClsCost _Cost = (ClsCost)lstCosts.SelectedItem;
                string message = "Are you sure you would like to delete cost " + _Cost.Type;
                string caption = "Deleting cost";
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // if the yes button is pressed
                if (result == DialogResult.Yes)
                {
                    _Tour.CostList.Remove(_Cost);
                   // ClsTour.CostList.Remove(_Cost);
                    updateCostDisplay();
                    UpdatelblShowTotalCosts();
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

        public void UpdatelblShowTotalCosts()
        {
            _Tour.TotalCosts = Convert.ToString(ClsTour.TotalBalance(_Tour));
            lblShowTotalCosts.Text = _Tour.TotalCosts;
         //   lblShowTotalCosts.Text = Convert.ToString(ClsTour.TotalBalance(_Tour));
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            _Tour.PricePerPerson = (ClsTour.WorkOutPricePerPerson(_Tour));
            lblShowPricePP.Text = _Tour.PricePerPerson.ToString("c");  //string.Format(Convert.ToString(_Tour.PricePerPerson));
          //  lblShowPricePP.Text = string.Format(Convert.ToString(ClsTour.WorkOutPricePerPerson(_Tour)));
        }
    }
}
