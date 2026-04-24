namespace ZenFulcrum.VR.OpenVRBinding;

public class CVRResources
{
	private IVRResources FnTable; //Field offset: 0x10

	internal CVRResources(IntPtr pInterface) { }

	public uint GetResourceFullPath(string pchResourceName, string pchResourceTypeDirectory, StringBuilder pchPathBuffer, uint unBufferLen) { }

	public uint LoadSharedResource(string pchResourceName, string pchBuffer, uint unBufferLen) { }

}

