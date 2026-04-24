namespace Assets.Scripts.PeroTools.GeneralLocalization;

public class LocalizationSettings : SingletonScriptableObject<LocalizationSettings>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public string schemeName; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <GetActiveOption>b__0(Scheme scheme) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public string schemeName; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <ActiveOption>b__0(Scheme s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public string optionEntryName; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <ActiveOption>b__0(GlobalOptionPair pair) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public SchemeEntry entry; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <GetScheme>b__0(Scheme scheme) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public string schemeName; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <GetScheme>b__0(Scheme scheme) { }

	}

	public List<Localization> glConfigs; //Field offset: 0x58
	public List<Scheme> schemes; //Field offset: 0x60

	public LocalizationSettings() { }

	public void ActiveOption(string schemeName, string optionEntryName) { }

	public void ActiveOption(Scheme scheme, string optionEntryName) { }

	public void ActiveOption(SchemeEntry schemeEntry, OptionEntry optionEntry) { }

	public void ActiveOptionToLocalization(Localization localization, SchemeEntry schemeEntry, OptionEntry optionEntry) { }

	public OptionEntry GetActiveOption(SchemeEntry entry) { }

	public string GetActiveOption(string schemeName) { }

	public Scheme GetScheme(SchemeEntry entry) { }

	public Scheme GetScheme(string schemeName) { }

	public void Register(Localization localization) { }

	public void UnRegister(Localization localization) { }

}

