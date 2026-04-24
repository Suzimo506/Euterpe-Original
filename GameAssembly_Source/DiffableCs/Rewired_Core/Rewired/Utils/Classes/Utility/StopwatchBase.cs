namespace Rewired.Utils.Classes.Utility;

[CustomClassObfuscation]
[CustomObfuscation]
internal abstract class StopwatchBase
{

	public abstract long elapsedMilliseconds
	{
		 get { } //Length: 0
	}

	public abstract long elapsedMillisecondsRaw
	{
		 get { } //Length: 0
	}

	public abstract double elapsedSeconds
	{
		 get { } //Length: 0
	}

	public abstract double elapsedSecondsRaw
	{
		 get { } //Length: 0
	}

	public abstract long elapsedTicks
	{
		 get { } //Length: 0
	}

	public abstract long elapsedTicksRaw
	{
		 get { } //Length: 0
	}

	public abstract bool isRunning
	{
		 get { } //Length: 0
	}

	public abstract double offsetSeconds
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract long offsetTicks
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	protected StopwatchBase() { }

	public abstract long get_elapsedMilliseconds() { }

	public abstract long get_elapsedMillisecondsRaw() { }

	public abstract double get_elapsedSeconds() { }

	public abstract double get_elapsedSecondsRaw() { }

	public abstract long get_elapsedTicks() { }

	public abstract long get_elapsedTicksRaw() { }

	public abstract bool get_isRunning() { }

	public abstract double get_offsetSeconds() { }

	public abstract long get_offsetTicks() { }

	public abstract void Reset() { }

	public abstract void set_offsetSeconds(double value) { }

	public abstract void set_offsetTicks(long value) { }

	public abstract void Start() { }

	public abstract void Stop() { }

}

