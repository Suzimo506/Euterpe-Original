namespace ZenFulcrum.VR.OpenVRBinding;

public struct CameraVideoStreamFrameHeader_t
{
	public EVRTrackedCameraFrameType eFrameType; //Field offset: 0x0
	public uint nWidth; //Field offset: 0x4
	public uint nHeight; //Field offset: 0x8
	public uint nBytesPerPixel; //Field offset: 0xC
	public uint nFrameSequence; //Field offset: 0x10
	public TrackedDevicePose_t standingTrackedDevicePose; //Field offset: 0x14
	public ulong ulFrameExposureTime; //Field offset: 0x68

}

