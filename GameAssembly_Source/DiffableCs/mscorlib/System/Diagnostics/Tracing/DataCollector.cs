namespace System.Diagnostics.Tracing;

internal struct DataCollector
{
	[ThreadStatic]
	internal static DataCollector ThreadInstance; //Field offset: 0x80000000
	private Byte* scratchEnd; //Field offset: 0x0
	private EventData* datasEnd; //Field offset: 0x8
	private GCHandle* pinsEnd; //Field offset: 0x10
	private EventData* datasStart; //Field offset: 0x18
	private Byte* scratch; //Field offset: 0x20
	private EventData* datas; //Field offset: 0x28
	private GCHandle* pins; //Field offset: 0x30
	private Byte[] buffer; //Field offset: 0x38
	private int bufferPos; //Field offset: 0x40
	private int bufferNesting; //Field offset: 0x44
	private bool writingScalars; //Field offset: 0x48

	internal void AddArray(Array value, int length, int itemSize) { }

	internal void AddBinary(string value, int size) { }

	internal void AddBinary(Array value, int size) { }

	internal void AddScalar(Void* value, int size) { }

	internal void BeginBuffered() { }

	internal int BeginBufferedArray() { }

	internal void Disable() { }

	internal void Enable(Byte* scratch, int scratchSize, EventData* datas, int dataCount, GCHandle* pins, int pinCount) { }

	internal void EndBuffered() { }

	internal void EndBufferedArray(int bookmark, int count) { }

	private void EnsureBuffer() { }

	private void EnsureBuffer(int additionalSize) { }

	internal EventData* Finish() { }

	private void GrowBuffer(int required) { }

	private void PinArray(object value, int size) { }

	private void ScalarsBegin() { }

	private void ScalarsEnd() { }

}

