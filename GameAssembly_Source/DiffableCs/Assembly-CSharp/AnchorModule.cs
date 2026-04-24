//Type is in global namespace

public class AnchorModule : Singleton<AnchorModule>
{
	private bool m_IsInited; //Field offset: 0x10
	private bool m_AllowAnchorMode; //Field offset: 0x11
	private bool m_IsAnchorMode; //Field offset: 0x12
	private bool m_IsAnchorModeShowUnuse; //Field offset: 0x13
	private DBConfigAnchor m_DbAnchor; //Field offset: 0x18
	private bool m_IsNetwork; //Field offset: 0x20

	public bool allowAnchorMode
	{
		 get { } //Length: 5
	}

	public bool isAnchorMode
	{
		 get { } //Length: 5
		 set { } //Length: 187
	}

	public bool isAnchorModeShowUnuse
	{
		 get { } //Length: 14
		 set { } //Length: 128
	}

	public AnchorModule() { }

	[CompilerGenerated]
	private void <InitModule>b__6_0(JObject data) { }

	[CompilerGenerated]
	private void <InitModule>b__6_1(JObject o) { }

	private void AnchorModeParse(string txt) { }

	public bool CheckLockByMusicUid(string musicUid) { }

	public bool CheckUiBgmIsLock(string musicName) { }

	public bool get_allowAnchorMode() { }

	public bool get_isAnchorMode() { }

	public bool get_isAnchorModeShowUnuse() { }

	public void InitModule() { }

	public void set_isAnchorMode(bool value) { }

	public void set_isAnchorModeShowUnuse(bool value) { }

}

