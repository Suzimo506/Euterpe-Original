namespace PaperPlaneTools;

public class RateBoxStatistics
{
	[SerializeField]
	private int sessionsCount; //Field offset: 0x10
	[SerializeField]
	private int customEventCount; //Field offset: 0x14
	[SerializeField]
	private int appInstallAt; //Field offset: 0x18
	[SerializeField]
	private int appLaunchAt; //Field offset: 0x1C
	[SerializeField]
	private int dialogShownAt; //Field offset: 0x20
	[SerializeField]
	private bool dialogIsRejected; //Field offset: 0x24
	[SerializeField]
	private bool dialogIsRated; //Field offset: 0x25
	[SerializeField]
	private string applicationVersion; //Field offset: 0x28

	public int AppInstallAt
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int AppLaunchAt
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public string ApplicationVersion
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public int CustomEventCount
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public bool DialogIsRated
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool DialogIsRejected
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public int DialogShownAt
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int SessionsCount
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public RateBoxStatistics() { }

	public int get_AppInstallAt() { }

	public int get_AppLaunchAt() { }

	public string get_ApplicationVersion() { }

	public int get_CustomEventCount() { }

	public bool get_DialogIsRated() { }

	public bool get_DialogIsRejected() { }

	public int get_DialogShownAt() { }

	public int get_SessionsCount() { }

	public void set_AppInstallAt(int value) { }

	public void set_AppLaunchAt(int value) { }

	public void set_ApplicationVersion(string value) { }

	public void set_CustomEventCount(int value) { }

	public void set_DialogIsRated(bool value) { }

	public void set_DialogIsRejected(bool value) { }

	public void set_DialogShownAt(int value) { }

	public void set_SessionsCount(int value) { }

}

