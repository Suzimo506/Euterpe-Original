namespace PeroTools2.Managers;

public class Product
{
	public bool isAvailable; //Field offset: 0x10
	public string id; //Field offset: 0x18
	public string title; //Field offset: 0x20
	public float price; //Field offset: 0x28
	public string currencySymbol; //Field offset: 0x30
	private string m_LocalizedPrice; //Field offset: 0x38

	public string localizedPrice
	{
		 get { } //Length: 130
		 set { } //Length: 12
	}

	public Product() { }

	public string get_localizedPrice() { }

	public void set_localizedPrice(string value) { }

	public virtual string ToString() { }

}

