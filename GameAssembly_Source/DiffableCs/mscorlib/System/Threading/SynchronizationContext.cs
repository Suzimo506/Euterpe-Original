namespace System.Threading;

public class SynchronizationContext
{
	private static Type s_cachedPreparedType1; //Field offset: 0x0
	private static Type s_cachedPreparedType2; //Field offset: 0x8
	private static Type s_cachedPreparedType3; //Field offset: 0x10
	private static Type s_cachedPreparedType4; //Field offset: 0x18
	private static Type s_cachedPreparedType5; //Field offset: 0x20
	private SynchronizationContextProperties _props; //Field offset: 0x10

	public static SynchronizationContext Current
	{
		 get { } //Length: 57
	}

	internal static SynchronizationContext CurrentNoFlow
	{
		[FriendAccessAllowed]
		internal get { } //Length: 57
	}

	public SynchronizationContext() { }

	public override SynchronizationContext CreateCopy() { }

	public static SynchronizationContext get_Current() { }

	[FriendAccessAllowed]
	internal static SynchronizationContext get_CurrentNoFlow() { }

	private static SynchronizationContext GetThreadLocalContext() { }

	public override void OperationCompleted() { }

	public override void OperationStarted() { }

	public override void Post(SendOrPostCallback d, object state) { }

	public override void Send(SendOrPostCallback d, object state) { }

	public static void SetSynchronizationContext(SynchronizationContext syncContext) { }

}

