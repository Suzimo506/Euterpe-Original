namespace System.Diagnostics.Tracing;

internal class ManifestBuilder
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public StringBuilder stringBuilder; //Field offset: 0x10
		public string eventMessage; //Field offset: 0x18
		public int writtenSoFar; //Field offset: 0x20

		public <>c__DisplayClass22_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_1
	{
		public int i; //Field offset: 0x10
		public <>c__DisplayClass22_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass22_1() { }

		internal void <TranslateToManifestConvention>b__0(char ch, string escape) { }

	}

	private Dictionary<Int32, String> opcodeTab; //Field offset: 0x10
	private Dictionary<Int32, String> taskTab; //Field offset: 0x18
	private Dictionary<UInt64, String> keywordTab; //Field offset: 0x20
	private Dictionary<String, Type> mapsTab; //Field offset: 0x28
	private Dictionary<String, String> stringTab; //Field offset: 0x30
	private StringBuilder sb; //Field offset: 0x38
	private StringBuilder events; //Field offset: 0x40
	private StringBuilder templates; //Field offset: 0x48
	private ResourceManager resources; //Field offset: 0x50
	private EventManifestOptions flags; //Field offset: 0x58
	private IList<String> errors; //Field offset: 0x60
	private Dictionary<String, List`1<Int32>> perEventByteArrayArgIndices; //Field offset: 0x68
	private string eventName; //Field offset: 0x70
	private int numParams; //Field offset: 0x78
	private List<Int32> byteArrArgIndices; //Field offset: 0x80

	public IList<String> Errors
	{
		 get { } //Length: 5
	}

	public ManifestBuilder(string providerName, Guid providerGuid, string dllName, ResourceManager resources, EventManifestOptions flags) { }

	public void AddEventParameter(Type type, string name) { }

	public void AddKeyword(string name, ulong value) { }

	public void AddOpcode(string name, int value) { }

	public void AddTask(string name, int value) { }

	public Byte[] CreateManifest() { }

	private string CreateManifestString() { }

	public void EndEvent() { }

	public IList<String> get_Errors() { }

	private string GetKeywords(ulong keywords, string eventName) { }

	private static string GetLevelName(EventLevel level) { }

	internal string GetLocalizedMessage(string key, CultureInfo ci, bool etwFormat) { }

	private string GetOpcodeName(EventOpcode opcode, string eventName) { }

	private static List<CultureInfo> GetSupportedCultures(ResourceManager resources) { }

	private string GetTaskName(EventTask task, string eventName) { }

	private string GetTypeName(Type type) { }

	public void ManifestError(string msg, bool runtimeCritical = false) { }

	public void StartEvent(string eventName, EventAttribute eventAttribute) { }

	private int TranslateIndexToManifestConvention(int idx, string evtName) { }

	private string TranslateToManifestConvention(string eventMessage, string evtName) { }

	private static void UpdateStringBuilder(ref StringBuilder stringBuilder, string eventMessage, int startIndex, int count) { }

	private void WriteMessageAttrib(StringBuilder stringBuilder, string elementName, string name, string value) { }

	private void WriteNameAndMessageAttribs(StringBuilder stringBuilder, string elementName, string name) { }

}

