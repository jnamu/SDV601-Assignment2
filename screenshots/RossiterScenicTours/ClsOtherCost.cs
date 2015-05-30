using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RossiterScenicTours
{
    [Serializable]
    class ClsOtherCost : ClsCost
    {
        public ClsOtherCost(ClsTour prTour) : base(prTour) { }

        private static FrmOtherCost _Form = new FrmOtherCost();

        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this);
        }

        protected override string typeOfCost()
        {
            return "Other";
        }

        public override decimal Balance()
        {
            decimal lcTotal = 0;
            lcTotal += InputAmount;
            return lcTotal;
        }
    }
}
