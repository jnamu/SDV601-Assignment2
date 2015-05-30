using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RossiterScenicTours
{
    public partial class FrmOtherCost : RossiterScenicTours.FrmCost
    {
        public FrmOtherCost()
        {
            InitializeComponent();
        }

        protected override void updateDisplay()
        {
            base.updateDisplay();
            ClsOtherCost lcCost = (ClsOtherCost)_Cost;
        }

        protected override void pushData()
        {
            base.pushData();
            ClsOtherCost lcCost = (ClsOtherCost)_Cost;
        }
    }
}
