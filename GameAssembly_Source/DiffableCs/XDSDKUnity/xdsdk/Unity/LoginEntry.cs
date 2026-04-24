namespace xdsdk.Unity;

public class LoginEntry
{
	internal enum Type
	{
		WX = 0,
		Tap = 1,
		QQ = 2,
		Guest = 3,
		XD = 4,
		None = 5,
	}

	private Type first; //Field offset: 0x10
	private Type second; //Field offset: 0x14
	private Type third; //Field offset: 0x18
	private Type fourth; //Field offset: 0x1C

	public Type First
	{
		 get { } //Length: 4
	}

	public Type Fourth
	{
		 get { } //Length: 4
	}

	public Type Second
	{
		 get { } //Length: 4
	}

	public Type Third
	{
		 get { } //Length: 4
	}

	public LoginEntry() { }

	public LoginEntry(String[] entries) { }

	private String[] CurrentEntriesToStringArray() { }

	private static string EntryToString(Type entry) { }

	public Type get_First() { }

	public Type get_Fourth() { }

	public Type get_Second() { }

	public Type get_Third() { }

	public void HideGuest() { }

	public void HideQQ() { }

	public void HideTapTap() { }

	public void HideWX() { }

	private static Type ParseEntryToType(string entry) { }

	private static String[] RemoveStringFromArray(string s, String[] array) { }

	private void SetDefaultEntries() { }

	public void SetEntries(String[] entries) { }

	private void SetStringArrayToCurrentEntries(String[] entries) { }

	private static String[] TrimStringArray(String[] array) { }

}

