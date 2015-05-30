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
    public partial class FrmCost : Form
    {
        protected ClsCost _Cost;

        public FrmCost()
        {
            InitializeComponent();
        }

        public bool ShowDialog(ClsCost prCost)
        {
            _Cost = prCost;
            updateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        protected virtual void updateDisplay()
        {
            try
            {
                txtType.Text = _Cost.Type;
                txtInputAmount.Text = Convert.ToString(_Cost.InputAmount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected virtual void pushData()
        {
            _Cost.Type = txtType.Text;
            _Cost.InputAmount = Convert.ToDecimal(txtInputAmount.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                pushData();
            //    ClsTour._Tour.CostList.ToString();
            //    ClsTour.CostList.ToString();
                _Cost.ToString();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
