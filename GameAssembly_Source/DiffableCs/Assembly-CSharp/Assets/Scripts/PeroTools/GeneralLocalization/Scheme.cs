namespace Assets.Scripts.PeroTools.GeneralLocalization;

public class Scheme
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GlobalOptionPair, String> <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <GetAllOptionsName>b__4_0(GlobalOptionPair pair) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public string optionName; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <Exist>b__0(GlobalOptionPair pair) { }

	}

	public OptionEntry activeOption; //Field offset: 0x10
	public List<GlobalOptionPair> optionPairs; //Field offset: 0x18
	public SchemeEntry schemeEntry; //Field offset: 0x20

	public Scheme() { }

	public bool Exist(string optionName) { }

	public List<String> GetAllOptionsName() { }

	public void GetAllOptionsName(List<String> list) { }

	public string GetOptionName(int index) { }

	public int OptionCount() { }

}

