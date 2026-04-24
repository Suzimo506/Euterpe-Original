namespace Account;

public struct AccountErrorMessage
{
	public int http_code; //Field offset: 0x0
	public string msg; //Field offset: 0x8
	public int biz_code; //Field offset: 0x10
	public string data; //Field offset: 0x18
	public string param; //Field offset: 0x20
	public string host; //Field offset: 0x28

	public virtual string ToString() { }

}

