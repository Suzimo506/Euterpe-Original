namespace System.Buffers;

public abstract class ReadOnlySequenceSegment
{
	[CompilerGenerated]
	private ReadOnlyMemory<T> <Memory>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private ReadOnlySequenceSegment<T> <Next>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private long <RunningIndex>k__BackingField; //Field offset: 0x0

	public ReadOnlyMemory<T> Memory
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public ReadOnlySequenceSegment<T> Next
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public long RunningIndex
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[CompilerGenerated]
	public ReadOnlyMemory<T> get_Memory() { }

	[CompilerGenerated]
	public ReadOnlySequenceSegment<T> get_Next() { }

	[CompilerGenerated]
	public long get_RunningIndex() { }

}

