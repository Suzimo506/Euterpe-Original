namespace System.Threading;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DebuggerTypeProxy(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct SpinLock
{
	public class SystemThreading_SpinLockDebugView
	{
		private SpinLock m_spinLock; //Field offset: 0x10

		public bool IsHeld
		{
			 get { } //Length: 76
		}

		public Nullable<Boolean> IsHeldByCurrentThread
		{
			 get { } //Length: 109
		}

		public Nullable<Int32> OwnerThreadID
		{
			 get { } //Length: 117
		}

		public SystemThreading_SpinLockDebugView(SpinLock spinLock) { }

		public bool get_IsHeld() { }

		public Nullable<Boolean> get_IsHeldByCurrentThread() { }

		public Nullable<Int32> get_OwnerThreadID() { }

	}

	private static int MAXIMUM_WAITERS; //Field offset: 0x0
	private int m_owner; //Field offset: 0x0

	public bool IsHeld
	{
		[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 66
	}

	public bool IsHeldByCurrentThread
	{
		[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 167
	}

	public bool IsThreadOwnerTrackingEnabled
	{
		[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 28
	}

	private static SpinLock() { }

	public SpinLock(bool enableThreadOwnerTracking) { }

	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	private void DecrementWaiters() { }

	public void Enter(ref bool lockTaken) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void Exit(bool useMemoryBarrier) { }

	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool get_IsHeld() { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool get_IsThreadOwnerTrackingEnabled() { }

	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

}

