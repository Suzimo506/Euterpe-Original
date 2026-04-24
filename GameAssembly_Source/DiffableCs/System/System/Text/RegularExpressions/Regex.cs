namespace System.Text.RegularExpressions;

public class Regex : ISerializable
{
	internal const int MaxOptionShift = 10; //Field offset: 0x0
	private static readonly TimeSpan MaximumMatchTimeout; //Field offset: 0x0
	private const string DefaultMatchTimeout_ConfigKeyName = "REGEX_DEFAULT_MATCH_TIMEOUT"; //Field offset: 0x0
	public static readonly TimeSpan InfiniteMatchTimeout; //Field offset: 0x8
	internal static readonly TimeSpan FallbackDefaultMatchTimeout; //Field offset: 0x10
	internal static readonly TimeSpan DefaultMatchTimeout; //Field offset: 0x18
	internal static LinkedList<CachedCodeEntry> livecode; //Field offset: 0x20
	internal static int cacheSize; //Field offset: 0x28
	protected private string pattern; //Field offset: 0x10
	protected private RegexRunnerFactory factory; //Field offset: 0x18
	protected private RegexOptions roptions; //Field offset: 0x20
	[OptionalField]
	protected private TimeSpan internalMatchTimeout; //Field offset: 0x28
	protected private Hashtable caps; //Field offset: 0x30
	protected private Hashtable capnames; //Field offset: 0x38
	protected private String[] capslist; //Field offset: 0x40
	protected private int capsize; //Field offset: 0x48
	internal ExclusiveReference runnerref; //Field offset: 0x50
	internal SharedReference replref; //Field offset: 0x58
	internal RegexCode code; //Field offset: 0x60
	internal bool refsInitialized; //Field offset: 0x68

	public TimeSpan MatchTimeout
	{
		 get { } //Length: 5
	}

	public RegexOptions Options
	{
		 get { } //Length: 4
	}

	public bool RightToLeft
	{
		 get { } //Length: 8
	}

	private static Regex() { }

	protected Regex(SerializationInfo info, StreamingContext context) { }

	private Regex(string pattern, RegexOptions options, TimeSpan matchTimeout, bool useCache) { }

	protected Regex() { }

	public Regex(string pattern) { }

	public Regex(string pattern, RegexOptions options) { }

	private CachedCodeEntry CacheCode(string key) { }

	public static string Escape(string str) { }

	public TimeSpan get_MatchTimeout() { }

	public RegexOptions get_Options() { }

	public bool get_RightToLeft() { }

	public string GroupNameFromNumber(int i) { }

	private static TimeSpan InitDefaultMatchTimeout() { }

	protected void InitializeReferences() { }

	public static bool IsMatch(string input, string pattern, RegexOptions options) { }

	public bool IsMatch(string input, int startat) { }

	public bool IsMatch(string input) { }

	public static bool IsMatch(string input, string pattern) { }

	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	private static CachedCodeEntry LookupCachedAndUpdate(string key) { }

	public static Match Match(string input, string pattern) { }

	public static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	public Match Match(string input) { }

	public Match Match(string input, int startat) { }

	public MatchCollection Matches(string input) { }

	public MatchCollection Matches(string input, int startat) { }

	public static MatchCollection Matches(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	public static MatchCollection Matches(string input, string pattern) { }

	public static MatchCollection Matches(string input, string pattern, RegexOptions options) { }

	public static string Replace(string input, string pattern, string replacement) { }

	public static string Replace(string input, string pattern, string replacement, RegexOptions options) { }

	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	public string Replace(string input, string replacement) { }

	public string Replace(string input, string replacement, int count, int startat) { }

	public static string Replace(string input, string pattern, MatchEvaluator evaluator) { }

	public static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout) { }

	public string Replace(string input, MatchEvaluator evaluator) { }

	public string Replace(string input, MatchEvaluator evaluator, int count, int startat) { }

	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	public String[] Split(string input, int count, int startat) { }

	public static String[] Split(string input, string pattern, RegexOptions options) { }

	public static String[] Split(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	public String[] Split(string input) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	public virtual string ToString() { }

	internal bool UseOptionInvariant() { }

	protected bool UseOptionR() { }

	protected private static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

}

