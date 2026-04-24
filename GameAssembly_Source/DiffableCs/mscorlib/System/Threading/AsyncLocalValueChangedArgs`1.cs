namespace System.Threading;

public struct AsyncLocalValueChangedArgs
{
	[CompilerGenerated]
	private T <PreviousValue>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private T <CurrentValue>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <ThreadContextChanged>k__BackingField; //Field offset: 0x0

	public private T CurrentValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private T PreviousValue
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private bool ThreadContextChanged
	{
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal AsyncLocalValueChangedArgs`1(T previousValue, T currentValue, bool contextChanged) { }

	[CompilerGenerated]
	public T get_CurrentValue() { }

	[CompilerGenerated]
	public T get_PreviousValue() { }

	[CompilerGenerated]
	private void set_CurrentValue(T value) { }

	[CompilerGenerated]
	private void set_PreviousValue(T value) { }

	[CompilerGenerated]
	private void set_ThreadContextChanged(bool value) { }

}

