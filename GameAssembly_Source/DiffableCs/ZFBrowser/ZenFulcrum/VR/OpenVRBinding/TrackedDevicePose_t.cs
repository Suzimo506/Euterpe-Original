namespace ZenFulcrum.VR.OpenVRBinding;

public struct TrackedDevicePose_t
{
	public HmdMatrix34_t mDeviceToAbsoluteTracking; //Field offset: 0x0
	public HmdVector3_t vVelocity; //Field offset: 0x30
	public HmdVector3_t vAngularVelocity; //Field offset: 0x3C
	public ETrackingResult eTrackingResult; //Field offset: 0x48
	public bool bPoseIsValid; //Field offset: 0x4C
	public bool bDeviceIsConnected; //Field offset: 0x4D

}

