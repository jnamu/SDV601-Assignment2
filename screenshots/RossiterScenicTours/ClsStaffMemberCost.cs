using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RossiterScenicTours
{
    [Serializable]
    class ClsStaffMemberCost : ClsCost
    {
        public ClsStaffMemberCost(ClsTour prTour) : base(prTour) { }

        private string _Name;
        private static FrmStaffMemberCost _Form = new FrmStaffMemberCost();
        private static string[] _StaffType = { "Driver", "Tour Guide", "Cook", "Specialised Tour Guide" };

        public static string[] StaffType
        {
            get { return ClsStaffMemberCost._StaffType; }
            set { ClsStaffMemberCost._StaffType = value; }
        }

        protected override string typeOfCost()
        {
            return "Staff Member";
        }

        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this);
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public override decimal Balance()
        {
            decimal lcTotal = 0;
            decimal lcDays = (_Tour.EndDate.Date - _Tour.StartDate.Date).Days;
            lcTotal += InputAmount * (lcDays + 1);
            return lcTotal;
        }
    }
}
