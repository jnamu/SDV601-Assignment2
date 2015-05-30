using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace RossiterScenicTours
{
    [Serializable]
    public class ClsTour
    {
        // declaring variables
        private string _TourID;
        private string _TourName;
        private string _TourDescription;
        private string _Distance;
        private DateTime _StartDate = DateTime.Today;
        private DateTime _EndDate = DateTime.Today;
        private decimal _MaxNOP;
        private string _TotalCosts;
        private decimal _Markup;
        private decimal _PricePerPerson;

        private static FrmTour _TourForm = new FrmTour();

        public virtual Boolean ViewEdit()
        {
            return _TourForm.ShowDialog(this);
        }

        // Encapsulation of variables
        public override string ToString()
        {
            return _TourID + "\t" + _TourName + "\t" + _StartDate.ToShortDateString() + "\t" + _PricePerPerson;
        }

        public string TourID
        {
            get { return _TourID; }
            set
            {
                if (!string.IsNullOrEmpty(value.Trim())) //means no empty ids and it trims the leading or following blanks
                    _TourID = value;
                else
                    throw new Exception("TourID cannot be empty");
            }
        }

        public string TourName
        {
            get { return _TourName; }
            set { _TourName = value; }
        }

        public string TourDescription
        {
            get { return _TourDescription; }
            set { _TourDescription = value; }
        }

        public string Distance
        {
            get { return _Distance; }
            set { _Distance = value; }
        }

        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        public decimal MaxNOP
        {
            get { return _MaxNOP; }
            set { _MaxNOP = value; }
        }

        public string TotalCosts
        {
            get { return _TotalCosts; }
            set { _TotalCosts = value; }
        }

        public decimal Markup
        {
            get { return _Markup; }
            set { _Markup = value; }
        }

        public decimal PricePerPerson
        {
            get { return _PricePerPerson; }
            set { _PricePerPerson = value; }
        }

        private List<ClsCost> _CostList = new List<ClsCost>();

        public List<ClsCost> CostList
        {
            get 
            {
                if (_CostList == null)
                    _CostList = new List<ClsCost>();
                return _CostList; 
            }
     //       set { _CostList = value; }
        }

        public static decimal TotalBalance(ClsTour prTour)
        {
            decimal lcTotal = 0;
            foreach (ClsCost lcCost in _TourForm._Tour.CostList)
            lcTotal += lcCost.Balance();
            return lcTotal;
        }

        public static decimal WorkOutPricePerPerson(ClsTour prTour)
        {
            decimal lcTotal = 0;
            decimal pre = Convert.ToDecimal(prTour.TotalCosts);
            lcTotal = (((prTour.Markup / 100) * pre) + pre) / prTour.MaxNOP;
        //    lcTotal += ((pre * prTour.Markup) / 100);
            return lcTotal;
        }
    }
}
