using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RossiterScenicTours
{
    [Serializable]
    class ClsVehicleCost : ClsCost
    {
        public ClsVehicleCost(ClsTour prTour) : base(prTour) { }

        private int _NoS;
        private string _Name;
        private static FrmVehicleCost _Form = new FrmVehicleCost();

        protected override string typeOfCost()
        {
            return "Vehicle";
        }

        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this);
        }

        public int NoS
        {
            get { return _NoS; }
            set { _NoS = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public override decimal Balance()
        {
            decimal lcTotal = 0;
            decimal ks = Convert.ToDecimal(_Tour.Distance);
            lcTotal += InputAmount * ks;
            return lcTotal;
        }
    }
}
