namespace PaperPlaneTools;

public class RateBox
{
	private static string statisticsPath; //Field offset: 0x0
	private static RateBox instance; //Field offset: 0x8
	[CompilerGenerated]
	private bool <DebugMode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <RateUrl>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private RateBoxConditions <Conditions>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private RateBoxSettings <Settings>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private RateBoxStatistics <Statistics>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private RateBoxTextSettings <DefaultTextSettings>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private IAlertPlatformAdapter <AlertAdapter>k__BackingField; //Field offset: 0x40

	public IAlertPlatformAdapter AlertAdapter
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public RateBoxConditions Conditions
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public bool DebugMode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public RateBoxTextSettings DefaultTextSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public static RateBox Instance
	{
		 get { } //Length: 733
	}

	public string RateUrl
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public RateBoxSettings Settings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public private RateBoxStatistics Statistics
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	private static RateBox() { }

	private RateBox(RateBoxStatistics stat) { }

	[CompilerGenerated]
	private void <ForceShow>b__37_0() { }

	[CompilerGenerated]
	private void <ForceShow>b__37_1() { }

	public bool CheckConditionsAreMet() { }

	public void ClearStatistics() { }

	private void DebugLog(string str) { }

	public void ForceShow() { }

	public void ForceShow(string title, string message, string rateButtonTitle, string postponeButtonTilte, string rejectButtonTitle = null) { }

	[CompilerGenerated]
	public IAlertPlatformAdapter get_AlertAdapter() { }

	[CompilerGenerated]
	public RateBoxConditions get_Conditions() { }

	[CompilerGenerated]
	public bool get_DebugMode() { }

	[CompilerGenerated]
	public RateBoxTextSettings get_DefaultTextSettings() { }

	public static RateBox get_Instance() { }

	[CompilerGenerated]
	public string get_RateUrl() { }

	[CompilerGenerated]
	public RateBoxSettings get_Settings() { }

	[CompilerGenerated]
	public RateBoxStatistics get_Statistics() { }

	public static string GetStoreUrl(string iTunesAppId, string googlePlayMarketAppBundleId) { }

	private void GoToRateUrl() { }

	public void IncrementCustomCounter(int value = 1) { }

	public void Init(string rateUrl, RateBoxConditions conditions = null, RateBoxTextSettings textSettings = null, RateBoxSettings settings = null) { }

	public bool SaveStatistics() { }

	[CompilerGenerated]
	public void set_AlertAdapter(IAlertPlatformAdapter value) { }

	[CompilerGenerated]
	public void set_Conditions(RateBoxConditions value) { }

	[CompilerGenerated]
	public void set_DebugMode(bool value) { }

	[CompilerGenerated]
	public void set_DefaultTextSettings(RateBoxTextSettings value) { }

	[CompilerGenerated]
	public void set_RateUrl(string value) { }

	[CompilerGenerated]
	public void set_Settings(RateBoxSettings value) { }

	[CompilerGenerated]
	private void set_Statistics(RateBoxStatistics value) { }

	public void Show(string title, string message, string rateButtonTitle, string postponeButtonTilte, string rejectButtonTitle = null) { }

	public void Show() { }

	private int Time() { }

}

