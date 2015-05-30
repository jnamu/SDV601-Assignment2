using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RossiterScenicTours
{
    public partial class FrmVehicleCost : RossiterScenicTours.FrmCost
    {
        public FrmVehicleCost()
        {
            InitializeComponent();
        }

        protected override void updateDisplay()
        {
            base.updateDisplay();
            ClsVehicleCost lcCost = (ClsVehicleCost)_Cost;
        }

        protected override void pushData()
        {
            base.pushData();
            ClsVehicleCost lcCost = (ClsVehicleCost)_Cost;
        }
    }
}

