namespace ThinkingSDK.PC.Time;

public class ThinkingSDKCalibratedTime : ThinkingSDKTimeInter
{
	private ThinkingSDKTimeCalibration mCalibratedTime; //Field offset: 0x10
	private TimeZoneInfo mTimeZone; //Field offset: 0x18
	private DateTime mDate; //Field offset: 0x20

	public ThinkingSDKCalibratedTime(ThinkingSDKTimeCalibration calibrateTimeInter, TimeZoneInfo timeZoneInfo) { }

	public override string GetTime() { }

	public override double GetZoneOffset() { }

}

