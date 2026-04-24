namespace ZenFulcrum.VR.OpenVRBinding;

public class CVRIOBuffer
{
	private IVRIOBuffer FnTable; //Field offset: 0x10

	internal CVRIOBuffer(IntPtr pInterface) { }

	public EIOBufferError Close(ulong ulBuffer) { }

	public EIOBufferError Open(string pchPath, EIOBufferMode mode, uint unElementSize, uint unElements, ref ulong pulBuffer) { }

	public ulong PropertyContainer(ulong ulBuffer) { }

	public EIOBufferError Read(ulong ulBuffer, IntPtr pDst, uint unBytes, ref uint punRead) { }

	public EIOBufferError Write(ulong ulBuffer, IntPtr pSrc, uint unBytes) { }

}

