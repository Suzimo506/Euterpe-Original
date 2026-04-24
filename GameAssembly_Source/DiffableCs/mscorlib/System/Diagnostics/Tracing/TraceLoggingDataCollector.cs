namespace System.Diagnostics.Tracing;

internal class TraceLoggingDataCollector
{
	internal static readonly TraceLoggingDataCollector Instance; //Field offset: 0x6B1F0

	private static TraceLoggingDataCollector() { }

	private TraceLoggingDataCollector() { }

	public void AddArray(Char[] value) { }

	public void AddArray(Double[] value) { }

	public void AddArray(Single[] value) { }

	public void AddArray(UIntPtr[] value) { }

	public void AddArray(IntPtr[] value) { }

	public void AddArray(UInt64[] value) { }

	public void AddArray(Int64[] value) { }

	public void AddArray(UInt32[] value) { }

	public void AddArray(Int32[] value) { }

	public void AddArray(UInt16[] value) { }

	public void AddArray(Int16[] value) { }

	public void AddArray(SByte[] value) { }

	public void AddArray(Boolean[] value) { }

	public void AddArray(Guid[] value) { }

	public void AddBinary(string value) { }

	public void AddBinary(Byte[] value) { }

	public void AddScalar(Guid value) { }

	public void AddScalar(char value) { }

	public void AddScalar(double value) { }

	public void AddScalar(float value) { }

	public void AddScalar(UIntPtr value) { }

	public void AddScalar(IntPtr value) { }

	public void AddScalar(ulong value) { }

	public void AddScalar(long value) { }

	public void AddScalar(uint value) { }

	public void AddScalar(int value) { }

	public void AddScalar(ushort value) { }

	public void AddScalar(short value) { }

	public void AddScalar(byte value) { }

	public void AddScalar(sbyte value) { }

	public void AddScalar(bool value) { }

	public int BeginBufferedArray() { }

	public void EndBufferedArray(int bookmark, int count) { }

}

