namespace rail;

public class RailDiscountInfo
{
	public PurchaseProductDiscountType type; //Field offset: 0x10
	public uint start_time; //Field offset: 0x14
	public float off; //Field offset: 0x18
	public float discount_price; //Field offset: 0x1C
	public uint end_time; //Field offset: 0x20

	public RailDiscountInfo() { }

}

