namespace rail;

public class RailPurchaseProductInfo
{
	public string category; //Field offset: 0x10
	public float original_price; //Field offset: 0x18
	public string description; //Field offset: 0x20
	public RailDiscountInfo discount; //Field offset: 0x28
	public bool is_purchasable; //Field offset: 0x30
	public string name; //Field offset: 0x38
	public string currency_type; //Field offset: 0x40
	public string product_thumbnail; //Field offset: 0x48
	public RailPurchaseProductExtraInfo extra_info; //Field offset: 0x50
	public uint product_id; //Field offset: 0x58

	public RailPurchaseProductInfo() { }

}

