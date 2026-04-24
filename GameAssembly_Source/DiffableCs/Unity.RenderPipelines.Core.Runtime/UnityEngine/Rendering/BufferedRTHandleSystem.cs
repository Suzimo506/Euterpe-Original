namespace UnityEngine.Rendering;

public class BufferedRTHandleSystem : IDisposable
{
	private Dictionary<Int32, RTHandle[]> m_RTHandles; //Field offset: 0x10
	private RTHandleSystem m_RTHandleSystem; //Field offset: 0x18
	private bool m_DisposedValue; //Field offset: 0x20

	public int maxHeight
	{
		 get { } //Length: 26
	}

	public int maxWidth
	{
		 get { } //Length: 26
	}

	public RTHandleProperties rtHandleProperties
	{
		 get { } //Length: 49
	}

	public BufferedRTHandleSystem() { }

	public void AllocBuffer(int bufferId, Func<RTHandleSystem, Int32, RTHandle> allocator, int bufferCount) { }

	private void Dispose(bool disposing) { }

	public override void Dispose() { }

	public int get_maxHeight() { }

	public int get_maxWidth() { }

	public RTHandleProperties get_rtHandleProperties() { }

	public RTHandle GetFrameRT(int bufferId, int frameIndex) { }

	public void ReleaseAll() { }

	public void ReleaseBuffer(int bufferId) { }

	private void Swap() { }

	public void SwapAndSetReferenceSize(int width, int height, MSAASamples msaaSamples) { }

}

