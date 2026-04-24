namespace ZenFulcrum.VR.OpenVRBinding;

public struct VRControllerState_t_Packed
{
	public uint unPacketNum; //Field offset: 0x0
	public ulong ulButtonPressed; //Field offset: 0x4
	public ulong ulButtonTouched; //Field offset: 0xC
	public VRControllerAxis_t rAxis0; //Field offset: 0x14
	public VRControllerAxis_t rAxis1; //Field offset: 0x1C
	public VRControllerAxis_t rAxis2; //Field offset: 0x24
	public VRControllerAxis_t rAxis3; //Field offset: 0x2C
	public VRControllerAxis_t rAxis4; //Field offset: 0x34

	public VRControllerState_t_Packed(VRControllerState_t unpacked) { }

	public void Unpack(ref VRControllerState_t unpacked) { }

}

