namespace System;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version>
{
	public enum ParseFailureKind
	{
		ArgumentNullException = 0,
		ArgumentException = 1,
		ArgumentOutOfRangeException = 2,
		FormatException = 3,
	}

	public struct VersionResult
	{
		internal Version m_parsedVersion; //Field offset: 0x0
		internal ParseFailureKind m_failure; //Field offset: 0x8
		internal string m_exceptionArgument; //Field offset: 0x10
		internal string m_argumentName; //Field offset: 0x18
		internal bool m_canThrow; //Field offset: 0x20

		internal Exception GetVersionParseException() { }

		internal void Init(string argumentName, bool canThrow) { }

		internal void SetFailure(ParseFailureKind failure) { }

		internal void SetFailure(ParseFailureKind failure, string argument) { }

	}

	private static readonly Char[] SeparatorsArray; //Field offset: 0x0
	private const int ZERO_CHAR_VALUE = 48; //Field offset: 0x0
	private int _Major; //Field offset: 0x10
	private int _Minor; //Field offset: 0x14
	private int _Build; //Field offset: 0x18
	private int _Revision; //Field offset: 0x1C

	public int Build
	{
		 get { } //Length: 4
	}

	public int Major
	{
		 get { } //Length: 4
	}

	public int Minor
	{
		 get { } //Length: 4
	}

	public int Revision
	{
		 get { } //Length: 4
	}

	private static Version() { }

	public Version() { }

	public Version(string version) { }

	public Version(int major, int minor, int build, int revision) { }

	public Version(int major, int minor, int build) { }

	public Version(int major, int minor) { }

	private static void AppendPositiveNumber(int num, StringBuilder sb) { }

	public override object Clone() { }

	public override int CompareTo(object version) { }

	public override int CompareTo(Version value) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(Version obj) { }

	public int get_Build() { }

	public int get_Major() { }

	public int get_Minor() { }

	public int get_Revision() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(Version v1, Version v2) { }

	public static bool op_GreaterThan(Version v1, Version v2) { }

	public static bool op_GreaterThanOrEqual(Version v1, Version v2) { }

	public static bool op_Inequality(Version v1, Version v2) { }

	public static bool op_LessThan(Version v1, Version v2) { }

	public static bool op_LessThanOrEqual(Version v1, Version v2) { }

	public static Version Parse(string input) { }

	public virtual string ToString() { }

	public string ToString(int fieldCount) { }

	public static bool TryParse(string input, out Version result) { }

	private static bool TryParseComponent(string component, string componentName, ref VersionResult result, out int parsedComponent) { }

	private static bool TryParseVersion(string version, ref VersionResult result) { }

}

