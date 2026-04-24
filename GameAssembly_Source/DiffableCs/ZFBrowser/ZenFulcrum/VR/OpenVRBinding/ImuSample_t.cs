namespace ZenFulcrum.VR.OpenVRBinding;

public struct ImuSample_t
{
	public double fSampleTime; //Field offset: 0x0
	public HmdVector3d_t vAccel; //Field offset: 0x8
	public HmdVector3d_t vGyro; //Field offset: 0x20
	public uint unOffScaleFlags; //Field offset: 0x38

}

