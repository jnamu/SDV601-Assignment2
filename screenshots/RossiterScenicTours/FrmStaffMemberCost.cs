using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RossiterScenicTours
{
    public partial class FrmStaffMemberCost : RossiterScenicTours.FrmCost
    {
        private string[] _StaffType = { "Driver", "Tour Guide", "Cook", "Specialised Tour Guide" };

        public FrmStaffMemberCost()
        {
            InitializeComponent();
            cboType.DataSource = _StaffType;
            cboType.SelectedIndex = 0;
        }

        protected override void updateDisplay()
        {
            base.updateDisplay();
            ClsStaffMemberCost lcCost = (ClsStaffMemberCost)_Cost;
            cboType.SelectedItem = Convert.ToString(lcCost.Type);
   //         txtType.Text = lcCost.Name;
        }

        protected override void pushData()
        {
            base.pushData();
            ClsStaffMemberCost lcCost = (ClsStaffMemberCost)_Cost;
            lcCost.Type = Convert.ToString(cboType.SelectedItem);
            lcCost.Name = txtName.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
