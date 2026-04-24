namespace Assets.Scripts.Common;

public class CloudDataChangeHandler : MonoBehaviour
{
	[Space]
	public GameObject txtLocal; //Field offset: 0x18
	public GameObject txtCloud; //Field offset: 0x20
	[Space]
	public GameObject highLevelCloudAsk; //Field offset: 0x28
	public GameObject highLevelLocalAsk; //Field offset: 0x30
	[Space]
	public GameObject highTips; //Field offset: 0x38
	public GameObject lowTips; //Field offset: 0x40
	[Space]
	public GameObject highLevelCloud; //Field offset: 0x48
	public GameObject lowLevelCloud; //Field offset: 0x50
	[Space]
	public GameObject highLevelLocal; //Field offset: 0x58
	public GameObject lowLevelLocal; //Field offset: 0x60
	[Space]
	public GameObject highYes; //Field offset: 0x68
	public GameObject lowYes; //Field offset: 0x70
	[Space]
	public GameObject highNo; //Field offset: 0x78
	public GameObject lowNo; //Field offset: 0x80
	[Space]
	public Button btnLocal; //Field offset: 0x88
	public Button btnCloud; //Field offset: 0x90
	[Space]
	public Button btnYes; //Field offset: 0x98
	[Space]
	public Text strLevelCloud; //Field offset: 0xA0
	public Text strExpCloud; //Field offset: 0xA8
	public Text strDateCloud; //Field offset: 0xB0
	[Space]
	public Text strLevelLocal; //Field offset: 0xB8
	public Text strExpLocal; //Field offset: 0xC0
	[Space]
	public Text confirmLevelCloud; //Field offset: 0xC8
	public Text confirmExpCloud; //Field offset: 0xD0
	public Text confirmDateCloud; //Field offset: 0xD8
	[Space]
	public Text confirmLevelLocal; //Field offset: 0xE0
	public Text confirmExpLocal; //Field offset: 0xE8
	private Action<Boolean> m_AndroidSyncCallback; //Field offset: 0xF0
	public bool isLocal; //Field offset: 0xF8
	private bool isRunOnce; //Field offset: 0xF9
	private int m_TotleKey; //Field offset: 0xFC
	private int m_DoneKey; //Field offset: 0x100
	private bool m_IsHanding; //Field offset: 0x104

	public static bool hasHandleCloudDataInit
	{
		 get { } //Length: 55
		 set { } //Length: 58
	}

	public CloudDataChangeHandler() { }

	[CompilerGenerated]
	private void <Init>b__38_0() { }

	[CompilerGenerated]
	private void <Init>b__38_1() { }

	[CompilerGenerated]
	private void <Init>b__38_2() { }

	private int CacularCurExp(int exp) { }

	private int CacularLevel(int exp) { }

	public static bool get_hasHandleCloudDataInit() { }

	public void Init(int cloudExp, string cloudSaveTime, int localExp, Action<Boolean> callback) { }

	private void OnApplicationFocus(bool isFocus) { }

	public static void set_hasHandleCloudDataInit(bool value) { }

}

