//Type is in global namespace

public class NsAocManager
{
	private const string mountHead = "MdAoc"; //Field offset: 0x0
	private const string abAssetNameHead = "mdaoc"; //Field offset: 0x0
	private const ulong m_AppId = 72213862335389696; //Field offset: 0x0
	private const int maxAocCount = 256; //Field offset: 0x0
	private static int m_AocCount; //Field offset: 0x0
	private static Int32[] m_AocList; //Field offset: 0x8
	private static Dictionary<Int32, AocDetail> m_AocDetails; //Field offset: 0x10
	private static List<Int32> m_LoadingAoc; //Field offset: 0x18

	private static NsAocManager() { }

	public NsAocManager() { }

	private static void AddAocDetail(int aocIndex, string mountName, string abName) { }

	public static int GetAocIndex(string name) { }

	public static void Init() { }

	public static bool IsLoadingAoc(int index) { }

	public static bool IsMountAoc(int index) { }

	public static T LoadFormName(string name) { }

	public static T LoadFormName(string name, int aocIndex) { }

	public static void ShowShop() { }

}

