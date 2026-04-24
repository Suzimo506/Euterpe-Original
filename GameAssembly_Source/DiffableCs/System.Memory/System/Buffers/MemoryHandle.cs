namespace System.Buffers;

public struct MemoryHandle : IDisposable
{
	private Void* _pointer; //Field offset: 0x0
	private GCHandle _handle; //Field offset: 0x8
	private IPinnable _pinnable; //Field offset: 0x10

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public MemoryHandle(Void* pointer, GCHandle handle = null, IPinnable pinnable = null) { }

	public override void Dispose() { }

}

