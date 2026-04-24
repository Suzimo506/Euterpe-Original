namespace Rewired.Utils.Classes.Utility;

[CustomClassObfuscation]
[CustomObfuscation]
internal sealed class Stopwatch : StopwatchBase
{
	private const long aRhDgocDShNgbgwhvRQzjuJnmrdsA = 10000000; //Field offset: 0x0
	public static readonly Stopwatch Global; //Field offset: 0x0
	private static long ZfyupmLzOENqjzDEJRcEPEDAUMty; //Field offset: 0x8
	private Stopwatch noNALiiiuMOSuYtYkChputGVDJsT; //Field offset: 0x10
	private long jfbRDAVlSFAHpiRnCRATBrhIKOAp; //Field offset: 0x18

	public virtual long elapsedMilliseconds
	{
		 get { } //Length: 185
	}

	public virtual long elapsedMillisecondsRaw
	{
		 get { } //Length: 29
	}

	public virtual double elapsedSeconds
	{
		 get { } //Length: 168
	}

	public virtual double elapsedSecondsRaw
	{
		 get { } //Length: 134
	}

	public virtual long elapsedTicks
	{
		 get { } //Length: 40
	}

	public virtual long elapsedTicksRaw
	{
		 get { } //Length: 29
	}

	public static long frequency
	{
		 get { } //Length: 87
	}

	public virtual bool isRunning
	{
		 get { } //Length: 27
	}

	public virtual double offsetSeconds
	{
		 get { } //Length: 114
		 set { } //Length: 124
	}

	public virtual long offsetTicks
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	private static Stopwatch() { }

	public Stopwatch() { }

	public static long ConvertTo100NSTicks(long ticks) { }

	public virtual long get_elapsedMilliseconds() { }

	public virtual long get_elapsedMillisecondsRaw() { }

	public virtual double get_elapsedSeconds() { }

	public virtual double get_elapsedSecondsRaw() { }

	public virtual long get_elapsedTicks() { }

	public virtual long get_elapsedTicksRaw() { }

	public static long get_frequency() { }

	public virtual bool get_isRunning() { }

	public virtual double get_offsetSeconds() { }

	public virtual long get_offsetTicks() { }

	public virtual void Reset() { }

	public virtual void set_offsetSeconds(double value) { }

	public virtual void set_offsetTicks(long value) { }

	public virtual void Start() { }

	public static Stopwatch StartNew() { }

	public virtual void Stop() { }

}

