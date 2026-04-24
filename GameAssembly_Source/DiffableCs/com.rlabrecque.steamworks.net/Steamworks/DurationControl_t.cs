namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct DurationControl_t
{
	public const int k_iCallback = 167; //Field offset: 0x0
	public EResult m_eResult; //Field offset: 0x0
	public AppId_t m_appid; //Field offset: 0x4
	public bool m_bApplicable; //Field offset: 0x8
	public int m_csecsLast5h; //Field offset: 0xC
	public EDurationControlProgress m_progress; //Field offset: 0x10
	public EDurationControlNotification m_notification; //Field offset: 0x14
	public int m_csecsToday; //Field offset: 0x18
	public int m_csecsRemaining; //Field offset: 0x1C

}

