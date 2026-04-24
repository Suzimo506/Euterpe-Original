namespace Rewired.Utils.Classes.Utility;

[CustomClassObfuscation]
[CustomObfuscation]
internal class DualThreadLowLevelInputEventQueue : IDisposable
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal interface INewEventWrapper : IDisposable
	{

		public LowLevelInputEvent Event
		{
			 get { } //Length: 0
			 set { } //Length: 0
		}

		public LowLevelInputEvent get_Event() { }

		public void set_Event(LowLevelInputEvent value) { }

	}

	private class xLIbANjZBtvxBexgGOgLeHTqyIxq : LockedObject<LowLevelInputEvent>, IDisposable, INewEventWrapper
	{

		public override LowLevelInputEvent Event
		{
			 get { } //Length: 19
			 set { } //Length: 16
		}

		public xLIbANjZBtvxBexgGOgLeHTqyIxq(object unnamed_param_0) { }

		public override LowLevelInputEvent get_Event() { }

		public override void set_Event(LowLevelInputEvent value) { }

	}

	private readonly LowLevelInputEventQueue zrJwVGOGHqTezpMPnHWuWpCtGKCb; //Field offset: 0x10
	private readonly LowLevelInputEventQueue KqgagNmfzmhrwxjofdOrQGxQGYxcA; //Field offset: 0x18
	private readonly object uXjdPAGYPnhCpGAVGfcttqAKDPqS; //Field offset: 0x20
	private uint RNxwbRFBqiMuCJURDVXWjxHTqMIw; //Field offset: 0x28
	private bool pjzUdrYACUMGqFHpsvQhskXAGbfZ; //Field offset: 0x2C
	private int LkwSSGXVyvIgIiXfYSuskNrqYOAt; //Field offset: 0x30
	private int MXcPSquPpTKOLRxBiWsWWNlnDOOCA; //Field offset: 0x34
	private xLIbANjZBtvxBexgGOgLeHTqyIxq DADEeKZwhKaJfaNBFRCHdofeJDeY; //Field offset: 0x38
	public LowLevelInputEvent currentEvent; //Field offset: 0x40
	private bool HJIqUdpanNSGICxZbMmGqcqhazEs; //Field offset: 0x60

	public int count
	{
		 get { } //Length: 158
	}

	public uint lastProcessedEventId
	{
		 get { } //Length: 4
	}

	public DualThreadLowLevelInputEventQueue(int unnamed_param_0, int unnamed_param_1, int unnamed_param_2, int unnamed_param_3) { }

	public void Clear() { }

	public override void Dispose() { }

	protected void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public int get_count() { }

	public uint get_lastProcessedEventId() { }

	public void ImportAll(DualThreadLowLevelInputEventQueue other) { }

	public bool ProcessNewEvents() { }

	public void StopProcessingEvents() { }

	public INewEventWrapper T_CreateEvent() { }

	public void Update() { }

}

