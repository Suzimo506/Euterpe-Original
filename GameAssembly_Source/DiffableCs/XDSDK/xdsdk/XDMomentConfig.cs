namespace xdsdk;

public class XDMomentConfig
{
	public static int ORIENTATION_DEFAULT; //Field offset: 0x0
	public static int ORIENTATION_LANDSCAPE; //Field offset: 0x4
	public static int ORIENTATION_PORTRAIT; //Field offset: 0x8
	public static int ORIENTATION_SENSOR; //Field offset: 0xC
	private int orientation; //Field offset: 0x10

	private static XDMomentConfig() { }

	public XDMomentConfig() { }

	public string GetConfigString() { }

	public int GetOrientation() { }

	public void SetOrientation(int orientation) { }

}

