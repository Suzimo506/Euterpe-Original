namespace Assets.Scripts.Purchase;

public class Product : ICloneable
{
	[CompilerGenerated]
	private string <id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <title>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private decimal <oriPrice>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private decimal <price>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private string <currencySymbol>k__BackingField; //Field offset: 0x40
	private int m_Discount; //Field offset: 0x48
	[CompilerGenerated]
	private DateTime <discountStartTime>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private DateTime <discountEndTime>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private string <localizedOriPrice>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private string <localizedPrice>k__BackingField; //Field offset: 0x68

	public private string currencySymbol
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public int discount
	{
		 get { } //Length: 4
	}

	public private DateTime discountEndTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private DateTime discountStartTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private string id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public bool isAvailable
	{
		 get { } //Length: 399
	}

	public bool isUnlockAll
	{
		 get { } //Length: 70
	}

	public string localizedOriPrice
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public string localizedPrice
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public private decimal oriPrice
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private decimal price
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public int showDiscount
	{
		 get { } //Length: 9
	}

	public private string title
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public Product(string productId) { }

	public Product(Product clone) { }

	public override object Clone() { }

	[CompilerGenerated]
	public string get_currencySymbol() { }

	public int get_discount() { }

	[CompilerGenerated]
	public DateTime get_discountEndTime() { }

	[CompilerGenerated]
	public DateTime get_discountStartTime() { }

	[CompilerGenerated]
	public string get_id() { }

	public bool get_isAvailable() { }

	public bool get_isUnlockAll() { }

	[CompilerGenerated]
	public string get_localizedOriPrice() { }

	[CompilerGenerated]
	public string get_localizedPrice() { }

	[CompilerGenerated]
	public decimal get_oriPrice() { }

	[CompilerGenerated]
	public decimal get_price() { }

	public int get_showDiscount() { }

	[CompilerGenerated]
	public string get_title() { }

	public decimal GetPrice(DateTime utcTime) { }

	public int GetPriceDiscount(DateTime utcTime) { }

	public int GetShowPriceDiscount(DateTime utcTime) { }

	public bool IsOnDiscount(DateTime utcTime) { }

	[CompilerGenerated]
	private void set_currencySymbol(string value) { }

	[CompilerGenerated]
	private void set_discountEndTime(DateTime value) { }

	[CompilerGenerated]
	private void set_discountStartTime(DateTime value) { }

	[CompilerGenerated]
	private void set_id(string value) { }

	[CompilerGenerated]
	public void set_localizedOriPrice(string value) { }

	[CompilerGenerated]
	public void set_localizedPrice(string value) { }

	[CompilerGenerated]
	private void set_oriPrice(decimal value) { }

	[CompilerGenerated]
	private void set_price(decimal value) { }

	[CompilerGenerated]
	private void set_title(string value) { }

	public void SetBaseInfo(string productTitle, decimal productOriPrice, decimal productPrice, string productCurrencySymbol) { }

	public void SetDiscount(int discount, DateTime startTime, DateTime endTime) { }

	public void SetShowDiscount(int showDiscount, DateTime startTime, DateTime endTime) { }

}

