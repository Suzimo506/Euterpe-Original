namespace ZenFulcrum.VR.OpenVRBinding;

public struct Compositor_FrameTiming
{
	public uint m_nSize; //Field offset: 0x0
	public uint m_nFrameIndex; //Field offset: 0x4
	public uint m_nNumFramePresents; //Field offset: 0x8
	public uint m_nNumMisPresented; //Field offset: 0xC
	public uint m_nNumDroppedFrames; //Field offset: 0x10
	public uint m_nReprojectionFlags; //Field offset: 0x14
	public double m_flSystemTimeInSeconds; //Field offset: 0x18
	public float m_flPreSubmitGpuMs; //Field offset: 0x20
	public float m_flPostSubmitGpuMs; //Field offset: 0x24
	public float m_flTotalRenderGpuMs; //Field offset: 0x28
	public float m_flCompositorRenderGpuMs; //Field offset: 0x2C
	public float m_flCompositorRenderCpuMs; //Field offset: 0x30
	public float m_flCompositorIdleCpuMs; //Field offset: 0x34
	public float m_flClientFrameIntervalMs; //Field offset: 0x38
	public float m_flPresentCallCpuMs; //Field offset: 0x3C
	public float m_flWaitForPresentCpuMs; //Field offset: 0x40
	public float m_flSubmitFrameMs; //Field offset: 0x44
	public float m_flWaitGetPosesCalledMs; //Field offset: 0x48
	public float m_flNewPosesReadyMs; //Field offset: 0x4C
	public float m_flNewFrameReadyMs; //Field offset: 0x50
	public float m_flCompositorUpdateStartMs; //Field offset: 0x54
	public float m_flCompositorUpdateEndMs; //Field offset: 0x58
	public float m_flCompositorRenderStartMs; //Field offset: 0x5C
	public TrackedDevicePose_t m_HmdPose; //Field offset: 0x60
	public uint m_nNumVSyncsReadyForUse; //Field offset: 0xB0
	public uint m_nNumVSyncsToFirstView; //Field offset: 0xB4

}

