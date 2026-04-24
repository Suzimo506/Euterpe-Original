namespace ZenFulcrum.VR.OpenVRBinding;

public class CVRExtendedDisplay
{
	private IVRExtendedDisplay FnTable; //Field offset: 0x10

	internal CVRExtendedDisplay(IntPtr pInterface) { }

	public void GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex) { }

	public void GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight) { }

	public void GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight) { }

}

