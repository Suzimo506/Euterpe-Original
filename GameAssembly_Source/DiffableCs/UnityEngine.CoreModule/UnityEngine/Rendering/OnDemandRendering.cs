namespace UnityEngine.Rendering;

[RequiredByNativeCode]
public class OnDemandRendering
{
	private static int m_RenderFrameInterval; //Field offset: 0x2C927B4

	public static int renderFrameInterval
	{
		 get { } //Length: 85
	}

	private static OnDemandRendering() { }

	public static int get_renderFrameInterval() { }

	[RequiredByNativeCode]
	internal static void GetRenderFrameInterval(out int frameInterval) { }

}

