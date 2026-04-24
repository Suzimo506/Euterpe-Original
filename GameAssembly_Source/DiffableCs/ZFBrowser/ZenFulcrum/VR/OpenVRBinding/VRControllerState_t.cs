namespace ZenFulcrum.VR.OpenVRBinding;

public struct VRControllerState_t
{
	public uint unPacketNum; //Field offset: 0x0
	public ulong ulButtonPressed; //Field offset: 0x8
	public ulong ulButtonTouched; //Field offset: 0x10
	public VRControllerAxis_t rAxis0; //Field offset: 0x18
	public VRControllerAxis_t rAxis1; //Field offset: 0x20
	public VRControllerAxis_t rAxis2; //Field offset: 0x28
	public VRControllerAxis_t rAxis3; //Field offset: 0x30
	public VRControllerAxis_t rAxis4; //Field offset: 0x38

}

