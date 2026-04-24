namespace ZenFulcrum.VR.OpenVRBinding;

public struct VREvent_t
{
	public uint eventType; //Field offset: 0x0
	public uint trackedDeviceIndex; //Field offset: 0x4
	public float eventAgeSeconds; //Field offset: 0x8
	public VREvent_Data_t data; //Field offset: 0x10

}

