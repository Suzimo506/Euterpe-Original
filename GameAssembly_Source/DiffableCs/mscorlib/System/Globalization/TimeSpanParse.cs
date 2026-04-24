namespace System.Globalization;

internal static class TimeSpanParse
{
	private enum ParseFailureKind
	{
		None = 0,
		ArgumentNull = 1,
		Format = 2,
		FormatWithParameter = 3,
		Overflow = 4,
	}

	private struct TimeSpanRawInfo
	{
		internal TTT lastSeenTTT; //Field offset: 0x0
		internal int tokenCount; //Field offset: 0x4
		internal int SepCount; //Field offset: 0x8
		internal int NumCount; //Field offset: 0xC
		internal String[] literals; //Field offset: 0x10
		internal TimeSpanToken[] numbers; //Field offset: 0x18
		private FormatLiterals m_posLoc; //Field offset: 0x20
		private FormatLiterals m_negLoc; //Field offset: 0x48
		private bool m_posLocInit; //Field offset: 0x70
		private bool m_negLocInit; //Field offset: 0x71
		private string m_fullPosPattern; //Field offset: 0x78
		private string m_fullNegPattern; //Field offset: 0x80

		internal FormatLiterals NegativeInvariant
		{
			internal get { } //Length: 245
		}

		internal FormatLiterals NegativeLocalized
		{
			internal get { } //Length: 103
		}

		internal FormatLiterals PositiveInvariant
		{
			internal get { } //Length: 244
		}

		internal FormatLiterals PositiveLocalized
		{
			internal get { } //Length: 100
		}

		private bool AddNum(TimeSpanToken num, ref TimeSpanResult result) { }

		private bool AddSep(string sep, ref TimeSpanResult result) { }

		internal bool FullAppCompatMatch(FormatLiterals pattern) { }

		internal bool FullDHMMatch(FormatLiterals pattern) { }

		internal bool FullDHMSMatch(FormatLiterals pattern) { }

		internal bool FullDMatch(FormatLiterals pattern) { }

		internal bool FullHMMatch(FormatLiterals pattern) { }

		internal bool FullHMSFMatch(FormatLiterals pattern) { }

		internal bool FullHMSMatch(FormatLiterals pattern) { }

		internal bool FullMatch(FormatLiterals pattern) { }

		internal FormatLiterals get_NegativeInvariant() { }

		internal FormatLiterals get_NegativeLocalized() { }

		internal FormatLiterals get_PositiveInvariant() { }

		internal FormatLiterals get_PositiveLocalized() { }

		internal void Init(DateTimeFormatInfo dtfi) { }

		internal bool PartialAppCompatMatch(FormatLiterals pattern) { }

		internal bool ProcessToken(ref TimeSpanToken tok, ref TimeSpanResult result) { }

	}

	private struct TimeSpanResult
	{
		internal TimeSpan parsedTimeSpan; //Field offset: 0x0
		internal TimeSpanThrowStyle throwStyle; //Field offset: 0x8
		internal ParseFailureKind m_failure; //Field offset: 0xC
		internal string m_failureMessageID; //Field offset: 0x10
		internal object m_failureMessageFormatArgument; //Field offset: 0x18
		internal string m_failureArgumentName; //Field offset: 0x20

		internal Exception GetTimeSpanParseException() { }

		internal void Init(TimeSpanThrowStyle canThrow) { }

		internal void SetFailure(ParseFailureKind failure, string failureMessageID) { }

		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName) { }

	}

	[Flags]
	private enum TimeSpanStandardStyles
	{
		None = 0,
		Invariant = 1,
		Localized = 2,
		RequireFull = 4,
		Any = 3,
	}

	private enum TimeSpanThrowStyle
	{
		None = 0,
		All = 1,
	}

	private struct TimeSpanToken
	{
		internal TTT ttt; //Field offset: 0x0
		internal int num; //Field offset: 0x4
		internal int zeroes; //Field offset: 0x8
		internal string sep; //Field offset: 0x10

		public TimeSpanToken(int number) { }

		public bool IsInvalidNumber(int maxValue, int maxPrecision) { }

	}

	private struct TimeSpanTokenizer
	{
		private int m_pos; //Field offset: 0x0
		private string m_value; //Field offset: 0x8

		internal char CurrentChar
		{
			internal get { } //Length: 49
		}

		internal bool EOL
		{
			internal get { } //Length: 33
		}

		internal char NextChar
		{
			internal get { } //Length: 51
		}

		internal char get_CurrentChar() { }

		internal bool get_EOL() { }

		internal char get_NextChar() { }

		internal TimeSpanToken GetNextToken() { }

		internal void Init(string input) { }

		internal void Init(string input, int startPosition) { }

	}

	private enum TTT
	{
		None = 0,
		End = 1,
		Num = 2,
		Sep = 3,
		NumOverflow = 4,
	}

	private static readonly TimeSpanToken zero; //Field offset: 0x6B080

	private static TimeSpanParse() { }

	internal static TimeSpan Parse(string input, IFormatProvider formatProvider) { }

	private static bool ProcessTerminal_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	private static bool ProcessTerminal_DHMSF(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	private static bool ProcessTerminal_HM(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	private static bool ProcessTerminal_HM_S_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	private static bool ProcessTerminal_HMS_F_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	private static bool ProcessTerminalState(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result) { }

	private static bool TryParseTimeSpan(string input, TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanResult result) { }

	private static bool TryTimeToTicks(bool positive, TimeSpanToken days, TimeSpanToken hours, TimeSpanToken minutes, TimeSpanToken seconds, TimeSpanToken fraction, out long result) { }

}

