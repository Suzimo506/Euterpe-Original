namespace ZenFulcrum.VR.OpenVRBinding;

public class CVRChaperone
{
	private IVRChaperone FnTable; //Field offset: 0x10

	internal CVRChaperone(IntPtr pInterface) { }

	public bool AreBoundsVisible() { }

	public void ForceBoundsVisible(bool bForce) { }

	public void GetBoundsColor(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor) { }

	public ChaperoneCalibrationState GetCalibrationState() { }

	public bool GetPlayAreaRect(ref HmdQuad_t rect) { }

	public bool GetPlayAreaSize(ref float pSizeX, ref float pSizeZ) { }

	public void ReloadInfo() { }

	public void SetSceneColor(HmdColor_t color) { }

}

