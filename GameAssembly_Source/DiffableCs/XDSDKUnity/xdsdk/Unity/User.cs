namespace xdsdk.Unity;

public class User
{
	private string id; //Field offset: 0x10
	private string name; //Field offset: 0x18
	private string friendlyName; //Field offset: 0x20
	private long authorizationState; //Field offset: 0x28
	private bool safety; //Field offset: 0x30

	public long AuthorizationState
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public string FriendlyName
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string Id
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public string Name
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public bool Safety
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public User() { }

	public long get_AuthorizationState() { }

	public string get_FriendlyName() { }

	public string get_Id() { }

	public string get_Name() { }

	public bool get_Safety() { }

	public static User InitWithDict(Dictionary<String, Object> dict) { }

	public void set_AuthorizationState(long value) { }

	public void set_FriendlyName(string value) { }

	public void set_Id(string value) { }

	public void set_Name(string value) { }

	public void set_Safety(bool value) { }

}

