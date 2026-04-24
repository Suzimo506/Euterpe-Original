namespace Rewired.Utils.Classes.Utility;

[CustomClassObfuscation]
[CustomObfuscation]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class LowLevelInputEventQueue : IDisposable
{
	private LowLevelInputEvent mMrditbltRcNNhZmEiXeKWKInRTub; //Field offset: 0x10
	private readonly NativeRingBuffer zkDISWXyiTwiseoQCtUEaMFFhatJA; //Field offset: 0x30
	private readonly int TshEvKgeTSbAhQpxLCDjEaXdzmKT; //Field offset: 0x38
	private readonly int bMWUdVcbaRUQKxqfXXruqPutnJrS; //Field offset: 0x3C
	private readonly int cyfFVebqzmzeTUpnEODWZlOmRYhw; //Field offset: 0x40
	private readonly int UClCjSQoIQzdJXKZBFhphvifjskIA; //Field offset: 0x44
	private readonly int fHFzqBypypzEdxCsGjiRCvUHhtXo; //Field offset: 0x48
	private uint hxzVCGBLdBintsgrucslQeafhLMd; //Field offset: 0x4C
	private bool HJIqUdpanNSGICxZbMmGqcqhazEs; //Field offset: 0x50

	public int Capacity
	{
		 get { } //Length: 4
	}

	public int Count
	{
		 get { } //Length: 30
	}

	public LowLevelInputEvent Item
	{
		 get { } //Length: 104
	}

	public LowLevelInputEventQueue(int unnamed_param_0, int unnamed_param_1, int unnamed_param_2, int unnamed_param_3) { }

	public void Clear() { }

	public void CopyAllFrom(LowLevelInputEventQueue other) { }

	public void CopyNewEventsFrom(LowLevelInputEventQueue other) { }

	public LowLevelInputEvent CreateEvent() { }

	public override void Dispose() { }

	protected void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public int FindNextIndex(uint id) { }

	public int get_Capacity() { }

	public int get_Count() { }

	public LowLevelInputEvent get_Item(int index) { }

	public bool TryGetNext(int index, out LowLevelInputEvent event) { }

}

