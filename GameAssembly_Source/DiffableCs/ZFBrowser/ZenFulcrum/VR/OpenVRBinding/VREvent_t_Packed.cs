namespace ZenFulcrum.VR.OpenVRBinding;

public struct VREvent_t_Packed
{
	public uint eventType; //Field offset: 0x0
	public uint trackedDeviceIndex; //Field offset: 0x4
	public float eventAgeSeconds; //Field offset: 0x8
	public VREvent_Data_t data; //Field offset: 0xC

	public VREvent_t_Packed(VREvent_t unpacked) { }

	public void Unpack(ref VREvent_t unpacked) { }

}

