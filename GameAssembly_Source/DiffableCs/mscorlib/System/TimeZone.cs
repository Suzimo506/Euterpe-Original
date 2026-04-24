namespace System;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class TimeZone
{
	private static TimeZone currentTimeZone; //Field offset: 0x0
	private static object tz_lock; //Field offset: 0x8
	private static long timezone_check; //Field offset: 0x10

	public static TimeZone CurrentTimeZone
	{
		 get { } //Length: 478
	}

	private static TimeZone() { }

	protected TimeZone() { }

	public static TimeZone get_CurrentTimeZone() { }

	public abstract TimeSpan GetUtcOffset(DateTime time) { }

	public override DateTime ToLocalTime(DateTime time) { }

}

