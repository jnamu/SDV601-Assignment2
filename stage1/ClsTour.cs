using System;
namespace stage1 {
	public class ClsTour {
		private String _TourID;
		private String _TourName;
		private String _TourDescription;
		private String _Distance;
		private DateTime _StartDate;
		private DateTime _EndDate;
		public String[] MaxNOP = {....};
		private Decimal _Markup;

		public ClsTour NewTour() {
			throw new System.Exception("Not implemented");
		}
		public Bool ViewEdit() {
			throw new System.Exception("Not implemented");
		}
		public String TourName() {
			throw new System.Exception("Not implemented");
		}
		public String TourDescription() {
			throw new System.Exception("Not implemented");
		}
		public String Distance() {
			throw new System.Exception("Not implemented");
		}
		public DateTime StartDate() {
			throw new System.Exception("Not implemented");
		}
		public DateTime EndDate() {
			throw new System.Exception("Not implemented");
		}
		public Decimal CalcTotalCost() {
			throw new System.Exception("Not implemented");
		}
		public Decimal CalcPricePP() {
			throw new System.Exception("Not implemented");
		}
		public Decimal Markup() {
			throw new System.Exception("Not implemented");
		}

		private ClsCost[] clsCosts;

		private ClsTourCompany clsTourCompany;

	}

}
