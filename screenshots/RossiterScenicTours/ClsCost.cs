using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RossiterScenicTours
{
    [Serializable]
    public abstract class ClsCost
    {
        public ClsCost(ClsTour prTour)
        {
            _Tour = prTour;
        }
        protected ClsTour _Tour;

        public abstract Boolean ViewEdit();

        public static readonly string[] CostType = { "Vehicle", "Staff Member", "Other" };

        public static ClsCost NewCost(int prChoice, ClsTour prTour)
        {
            if (prChoice == 0)
                return new ClsVehicleCost(prTour);
            if (prChoice == 1)
                return new ClsStaffMemberCost(prTour);
            else
                return new ClsOtherCost(prTour);
        }

        protected abstract string typeOfCost();

        public override string ToString()
        {
            return _Type + "\t" + typeOfCost() + "\t" + Balance();
        }

        private string _Type;
        private decimal _InputAmount;

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public decimal InputAmount
        {
            get { return _InputAmount; }
            set { _InputAmount = value; }
        }

        public abstract decimal Balance();

    }
}
