using System;
namespace stage1 {
	public abstract class ClsCost {
		private String _Type;
		private Decimal inputAmount;

		public static ClsCost NewCost() {
			throw new System.Exception("Not implemented");
		}
		public abstract Bool ViewEdit();
		public String Type() {
			throw new System.Exception("Not implemented");
		}
		public abstract Decimal Calculate();

		private ClsTour -_Cost;

	}

}
