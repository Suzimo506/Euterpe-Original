namespace ZenFulcrum.VR.OpenVRBinding;

public class CVRChaperoneSetup
{
	private IVRChaperoneSetup FnTable; //Field offset: 0x10

	internal CVRChaperoneSetup(IntPtr pInterface) { }

	public bool CommitWorkingCopy(EChaperoneConfigFile configFile) { }

	public bool ExportLiveToBuffer(StringBuilder pBuffer, ref uint pnBufferLength) { }

	public bool GetLiveCollisionBoundsInfo(out HmdQuad_t[] pQuadsBuffer) { }

	public bool GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose) { }

	public bool GetWorkingCollisionBoundsInfo(out HmdQuad_t[] pQuadsBuffer) { }

	public bool GetWorkingPlayAreaRect(ref HmdQuad_t rect) { }

	public bool GetWorkingPlayAreaSize(ref float pSizeX, ref float pSizeZ) { }

	public bool GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose) { }

	public bool GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose) { }

	public void HideWorkingSetPreview() { }

	public bool ImportFromBufferToWorking(string pBuffer, uint nImportFlags) { }

	public void ReloadFromDisk(EChaperoneConfigFile configFile) { }

	public void RevertWorkingCopy() { }

	public void SetWorkingCollisionBoundsInfo(HmdQuad_t[] pQuadsBuffer) { }

	public void SetWorkingPerimeter(HmdVector2_t[] pPointBuffer) { }

	public void SetWorkingPlayAreaSize(float sizeX, float sizeZ) { }

	public void SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose) { }

	public void SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose) { }

	public void ShowWorkingSetPreview() { }

}

