namespace Account;

public class UserBindInfo
{
	internal struct BindData
	{
		public string phone; //Field offset: 0x0
		public string email; //Field offset: 0x8
		public bool is_auth; //Field offset: 0x10
		public bool real_name_verify; //Field offset: 0x11

	}

	public int code; //Field offset: 0x10
	public BindData data; //Field offset: 0x18

	public bool isBind
	{
		 get { } //Length: 54
	}

	public UserBindInfo() { }

	public bool get_isBind() { }

}

