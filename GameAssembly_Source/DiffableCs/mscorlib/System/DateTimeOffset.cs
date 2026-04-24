namespace System;

public struct DateTimeOffset : IComparable, IFormattable, ISerializable, IDeserializationCallback, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>
{
	public static readonly DateTimeOffset MinValue; //Field offset: 0x0
	public static readonly DateTimeOffset MaxValue; //Field offset: 0x10
	private DateTime m_dateTime; //Field offset: 0x0
	private short m_offsetMinutes; //Field offset: 0x8

	private DateTime ClockDateTime
	{
		private get { } //Length: 301
	}

	public DateTime DateTime
	{
		 get { } //Length: 7
	}

	public int Day
	{
		 get { } //Length: 38
	}

	public int Hour
	{
		 get { } //Length: 88
	}

	public DateTime LocalDateTime
	{
		 get { } //Length: 36
	}

	public int Minute
	{
		 get { } //Length: 92
	}

	public int Month
	{
		 get { } //Length: 38
	}

	public static DateTimeOffset Now
	{
		 get { } //Length: 102
	}

	public TimeSpan Offset
	{
		 get { } //Length: 46
	}

	public int Second
	{
		 get { } //Length: 92
	}

	public long Ticks
	{
		 get { } //Length: 29
	}

	public DateTime UtcDateTime
	{
		 get { } //Length: 119
	}

	public int Year
	{
		 get { } //Length: 36
	}

	private static DateTimeOffset() { }

	private DateTimeOffset(SerializationInfo info, StreamingContext context) { }

	public DateTimeOffset(long ticks, TimeSpan offset) { }

	public DateTimeOffset(DateTime dateTime) { }

	public DateTimeOffset(DateTime dateTime, TimeSpan offset) { }

	public static int Compare(DateTimeOffset first, DateTimeOffset second) { }

	public override int CompareTo(DateTimeOffset other) { }

	public override bool Equals(DateTimeOffset other) { }

	public virtual bool Equals(object obj) { }

	private DateTime get_ClockDateTime() { }

	public DateTime get_DateTime() { }

	public int get_Day() { }

	public int get_Hour() { }

	public DateTime get_LocalDateTime() { }

	public int get_Minute() { }

	public int get_Month() { }

	public static DateTimeOffset get_Now() { }

	public TimeSpan get_Offset() { }

	public int get_Second() { }

	public long get_Ticks() { }

	public DateTime get_UtcDateTime() { }

	public int get_Year() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(DateTimeOffset left, DateTimeOffset right) { }

	public static DateTimeOffset op_Implicit(DateTime dateTime) { }

	public static bool op_Inequality(DateTimeOffset left, DateTimeOffset right) { }

	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider) { }

	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles) { }

	private override int System.IComparable.CompareTo(object obj) { }

	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

	public string ToString(IFormatProvider formatProvider) { }

	public virtual string ToString() { }

	public long ToUnixTimeSeconds() { }

	public static bool TryParse(string input, out DateTimeOffset result) { }

	public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset) { }

	private static short ValidateOffset(TimeSpan offset) { }

	private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName) { }

}

