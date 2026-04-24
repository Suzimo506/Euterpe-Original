namespace ZenFulcrum.VR.OpenVRBinding;

public class CVRDriverManager
{
	private IVRDriverManager FnTable; //Field offset: 0x10

	internal CVRDriverManager(IntPtr pInterface) { }

	public uint GetDriverCount() { }

	public ulong GetDriverHandle(string pchDriverName) { }

	public uint GetDriverName(uint nDriver, StringBuilder pchValue, uint unBufferSize) { }

}

