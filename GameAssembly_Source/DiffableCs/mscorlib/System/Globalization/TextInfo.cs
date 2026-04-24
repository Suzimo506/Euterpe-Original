namespace System.Globalization;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TextInfo : ICloneable, IDeserializationCallback
{
	internal static TextInfo s_Invariant; //Field offset: 0x0
	private const int wordSeparatorMask = 536672256; //Field offset: 0x0
	[OptionalField]
	private string m_listSeparator; //Field offset: 0x10
	[OptionalField]
	private bool m_isReadOnly; //Field offset: 0x18
	[OptionalField]
	private string m_cultureName; //Field offset: 0x20
	private CultureData m_cultureData; //Field offset: 0x28
	private string m_textInfoName; //Field offset: 0x30
	private Nullable<Boolean> m_IsAsciiCasingSameAsInvariant; //Field offset: 0x38
	[OptionalField]
	private string customCultureName; //Field offset: 0x40
	[OptionalField]
	internal int m_nDataItem; //Field offset: 0x48
	[OptionalField]
	internal bool m_useUserOverride; //Field offset: 0x4C
	[OptionalField]
	internal int m_win32LangID; //Field offset: 0x50

	[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string CultureName
	{
		 get { } //Length: 5
	}

	internal static TextInfo Invariant
	{
		internal get { } //Length: 251
	}

	private bool IsAsciiCasingSameAsInvariant
	{
		private get { } //Length: 200
	}

	public override int OEMCodePage
	{
		 get { } //Length: 26
	}

	internal TextInfo() { }

	internal TextInfo(CultureData cultureData) { }

	private static int AddNonLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen) { }

	private int AddTitlecaseLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen) { }

	[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override object Clone() { }

	internal static int CompareOrdinalIgnoreCase(string str1, string str2) { }

	internal static int CompareOrdinalIgnoreCaseEx(string strA, int indexA, string strB, int indexB, int lengthA, int lengthB) { }

	public virtual bool Equals(object obj) { }

	public string get_CultureName() { }

	internal static TextInfo get_Invariant() { }

	private bool get_IsAsciiCasingSameAsInvariant() { }

	public override int get_OEMCodePage() { }

	internal int GetCaseInsensitiveHashCode(string str, bool forceRandomizedHashing, long additionalEntropy) { }

	internal int GetCaseInsensitiveHashCode(string str) { }

	public virtual int GetHashCode() { }

	internal static int GetHashCodeOrdinalIgnoreCase(string s) { }

	internal static int GetHashCodeOrdinalIgnoreCase(string s, bool forceRandomizedHashing, long additionalEntropy) { }

	private int GetInvariantCaseInsensitiveHashCode(string str) { }

	internal static int IndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	private static int InternalCompareStringOrdinalIgnoreCase(string strA, int indexA, string strB, int indexB, int lenA, int lenB) { }

	private static bool IsAscii(char c) { }

	private static bool IsLetterCategory(UnicodeCategory uc) { }

	private static bool IsWordSeparator(UnicodeCategory category) { }

	internal static int LastIndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx) { }

	private void OnDeserialized() { }

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx) { }

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx) { }

	internal void SetReadOnlyState(bool readOnly) { }

	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	public override string ToLower(string str) { }

	public override char ToLower(char c) { }

	private static char ToLowerAsciiInvariant(char c) { }

	private string ToLowerInternal(string str) { }

	private char ToLowerInternal(char c) { }

	public virtual string ToString() { }

	public string ToTitleCase(string str) { }

	public override char ToUpper(char c) { }

	public override string ToUpper(string str) { }

	private static char ToUpperAsciiInvariant(char c) { }

	private char ToUpperInternal(char c) { }

	private string ToUpperInternal(string str) { }

}

