namespace ThinkingSDK.PC.Time;

public class ThinkingSDKTime : ThinkingSDKTimeInter
{
	private TimeZoneInfo mTimeZone; //Field offset: 0x10
	private DateTime mDate; //Field offset: 0x18

	public ThinkingSDKTime(TimeZoneInfo timezone, DateTime date) { }

	public override string GetTime() { }

	public override double GetZoneOffset() { }

}

